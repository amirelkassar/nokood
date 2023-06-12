using FluentValidation;
using MediatR;
using NokoodAssignment.Application.Base;

namespace NokoodAssignment.Application.Featuers.ReservationFeatuers.Commands
{
    public class DeleteReservationCommand : IRequest<bool>
    {
        public Guid ReservationId { get; set; }

        public class DeleteReservationCommandHandler : IRequestHandler<DeleteReservationCommand, bool>
        {
            private readonly INokoodDBContext nokoodDBContext;

            public DeleteReservationCommandHandler(INokoodDBContext nokoodDBContext)
            {
                this.nokoodDBContext = nokoodDBContext;
            }
            public async Task<bool> Handle(DeleteReservationCommand request, CancellationToken cancellationToken)
            {
                var reservation = await nokoodDBContext.Reservations.FindAsync(request.ReservationId);
                nokoodDBContext.Reservations.Remove(reservation);
                return await nokoodDBContext.CommitAsync() > 0 ? true : false;
            }
        }
    }

    public class DeleteReservationCommandValidator : AbstractValidator<DeleteReservationCommand>
    {
        public DeleteReservationCommandValidator(INokoodDBContext nokoodDBContext)
        {
            RuleFor(r => r.ReservationId)
                .NotEmpty()
                .NotNull()
                .NotEqual(Guid.Empty);

            RuleFor(r => r)
                .Must(r => nokoodDBContext.Reservations.Any(dt => dt.Id == r.ReservationId))
                .WithErrorCode("Couldn't find an entity with the provided id!");
        }
    }
}
