using FluentValidation;
using MediatR;
using Microsoft.Extensions.Logging;
using NokoodAssignment.Application.Base;
using NokoodAssignment.Application.Dots;
using NokoodAssignment.Domain.Entities;
using NokoodAssignment.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NokoodAssignment.Application.Featuers.ReservationFeatuers.Commands
{
    public class CreateReservationCommand : IRequest<SinglePageApiResponse<ReservationReadDto>>
    {
        public Guid TripId { get; set; }
        public string CustomerName { get; set; }
        public DateTime ReservationDate { get; set; }
        public string? Notes { get; set; }

        public class CreateReservationCommandHandler : IRequestHandler<CreateReservationCommand, SinglePageApiResponse<ReservationReadDto>>
        {
            private readonly INokoodDBContext nokoodDBContext;
            private readonly ICurrentUser currentUser;

            public CreateReservationCommandHandler(
                INokoodDBContext nokoodDBContext,
                ICurrentUser currentUser)
            {
                this.nokoodDBContext = nokoodDBContext;
                this.currentUser = currentUser;
            }

            public async Task<SinglePageApiResponse<ReservationReadDto>> Handle(CreateReservationCommand request, CancellationToken cancellationToken)
            {
                var validator = new CreateReservationCommandValidator(nokoodDBContext);
                var validation = await validator.ValidateAsync(request);
                if (validation.IsValid)
                {
                    //check if reservation exists
                    if (nokoodDBContext.Reservations.Any(r => r.TripId == request.TripId && r.CustomerName.ToLower() == request.CustomerName.ToLower()))
                    {
                        return new SinglePageApiResponse<ReservationReadDto>
                        {
                            Success = false,
                            Code = 400,
                            Message = "Couldn't create the entity",
                            Error = new EntityAlreadyExistException()
                        };
                    }
                    //creating the onject
                    var reservation = new Reservation(
                        Guid.NewGuid(),
                        Guid.Parse(currentUser.Id),
                        request.TripId,
                        request.CustomerName,
                        request.ReservationDate);
                    reservation.Notes = request.Notes;

                    await nokoodDBContext.Reservations.AddAsync(reservation, cancellationToken);
                    return new SinglePageApiResponse<ReservationReadDto>
                    {
                        Success = true,
                        Code = 201,
                        Message = "Entity Created!",
                        Data = (ReservationReadDto)reservation
                    };
                }
                else
                {
                    return new SinglePageApiResponse<ReservationReadDto>
                    {
                        Success=false,
                        Code=400,
                        Message="Validation error",
                        Error=validation.Errors
                    };
                }
               
            }
        }
    }
    public class CreateReservationCommandValidator : AbstractValidator<CreateReservationCommand>
    {
        public CreateReservationCommandValidator(INokoodDBContext nokoodDBContext)
        {
            RuleFor(c => c.TripId)
                .NotEmpty()
                .NotEmpty();

            RuleFor(c => c.CustomerName)
                .NotEmpty()
                .NotNull();

            RuleFor(c => c.ReservationDate)
                .NotNull()
                .NotEmpty();

            RuleFor(c => c.TripId)
                .Must(c => nokoodDBContext.Trips.Any(t => t.Id == c))
                .WithMessage("Couldn't find a trip with the provided id");
        }
    }
}
