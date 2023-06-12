using FluentValidation;
using MediatR;
using NokoodAssignment.Application.Base;
using NokoodAssignment.Application.Dots;
using NokoodAssignment.Domain.Exceptions;

namespace NokoodAssignment.Application.Featuers.ReservationFeatuers.Queries
{
    public class GetReservationByIdQuery : IRequest<ApiResponse<ReservationReadDto>>
    {
        public Guid Id { get; set; }

        public class GetReservationByIdQueryHandler : IRequestHandler<GetReservationByIdQuery, ApiResponse<ReservationReadDto>>
        {
            private readonly INokoodDBContext nokoodDBContext;

            public GetReservationByIdQueryHandler(INokoodDBContext nokoodDBContext)
            {
                this.nokoodDBContext = nokoodDBContext;
            }
            public async Task<ApiResponse<ReservationReadDto>> Handle(GetReservationByIdQuery request, CancellationToken cancellationToken)
            {
                if (!nokoodDBContext.Reservations.Any(r => r.Id == request.Id))
                {
                    return new ApiResponse<ReservationReadDto>
                    {
                        Success = false,
                        Code = 404,
                        Message = "Couldn't find the entity",
                        Error = new EntityNotFoundException(request.Id)
                    };
                }

                var reservation = await nokoodDBContext.Reservations.FindAsync(request.Id);
                return new ApiResponse<ReservationReadDto>
                {
                    Success = true,
                    Code = 200,
                    Message = "Entity retrieved",
                    Data = (ReservationReadDto)reservation
                };
            }
        }
    }

    public class GetReservationByIdQueryValidator : AbstractValidator<GetReservationByIdQuery>
    {
        public GetReservationByIdQueryValidator()
        {
            RuleFor(r => r.Id)
                .NotEmpty()
                .NotNull()
                .NotEqual(Guid.Empty);
        }
    }
}
