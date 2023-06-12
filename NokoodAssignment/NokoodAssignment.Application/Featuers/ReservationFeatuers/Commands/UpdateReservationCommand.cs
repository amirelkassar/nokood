using FluentValidation;
using MediatR;
using NokoodAssignment.Application.Base;
using NokoodAssignment.Application.Dots;

namespace NokoodAssignment.Application.Featuers.ReservationFeatuers.Commands
{
    public class UpdateReservationCommand : IRequest<ApiResponse<ReservationReadDto>>
    {
        public Guid ReservationId { get; set; }
        public DateTime ReservationDate { get; set; }
        public string? Notes { get; set; }

        public class UpdateReservationCommandHandler : IRequestHandler<UpdateReservationCommand, ApiResponse<ReservationReadDto>>
        {
            private readonly INokoodDBContext nokoodDBContext;

            public UpdateReservationCommandHandler(INokoodDBContext nokoodDBContext)
            {
                this.nokoodDBContext = nokoodDBContext;
            }
            public async Task<ApiResponse<ReservationReadDto>> Handle(UpdateReservationCommand request, CancellationToken cancellationToken)
            {
                var validator = new UpdateReservationCommandValidator(nokoodDBContext);
                var validation = await validator.ValidateAsync(request);
                if (validation.IsValid)
                {
                    //updating the object
                    var reservation = await nokoodDBContext.Reservations.FindAsync(request.ReservationId);
                    reservation.ReservationDate = reservation.ReservationDate;
                    reservation.Notes = reservation.Notes;

                    nokoodDBContext.Reservations.Update(reservation);
                    await nokoodDBContext.CommitAsync();
                    return new ApiResponse<ReservationReadDto>
                    {
                        Success = true,
                        Code = 200,
                        Message = "Entity Updated!",
                        Data = (ReservationReadDto)reservation
                    };
                }
                else
                {
                    return new ApiResponse<ReservationReadDto>
                    {
                        Success = false,
                        Code = 400,
                        Message = "Validation error",
                        Error = validation.Errors
                    };
                }
            }
        }
    }

    public class UpdateReservationCommandValidator : AbstractValidator<UpdateReservationCommand>
    {
        public UpdateReservationCommandValidator(INokoodDBContext nokoodDBContext)
        {
            RuleFor(r => r.ReservationId)
                .NotEmpty()
                .NotNull()
                .NotEqual(Guid.Empty);


            RuleFor(c => c.ReservationDate)
                .NotNull()
                .NotEmpty();

            RuleFor(c => c.ReservationId)
                .Must(c => nokoodDBContext.Reservations.Any(t => t.Id == c))
                .WithMessage("Couldn't find a reservation with the provided id");
        }
    }
}
