using FluentValidation;
using MediatR;
using NokoodAssignment.Application.Base;

namespace NokoodAssignment.Application.Featuers.ReservationFeatuers.Commands
{
    public class DeleteReservationCommand : IRequest<bool>
    {
        public Guid Id { get; set; }

        public class DeleteReservationCommandHandler : IRequestHandler<DeleteReservationCommand, bool>
        {
            private readonly INokoodDBContext nokoodDBContext;

            public DeleteReservationCommandHandler(INokoodDBContext nokoodDBContext)
            {
                this.nokoodDBContext = nokoodDBContext;
            }
            public async Task<bool> Handle(DeleteReservationCommand request, CancellationToken cancellationToken)
            {
                var validator = new DeleteReservationCommandValidator(nokoodDBContext);
                var validation = await validator.ValidateAsync(request);
                if (validation.IsValid)
                {
                    var reservation = await nokoodDBContext.Reservations.FindAsync(request.Id);
                    nokoodDBContext.Reservations.Remove(reservation);
                    return await nokoodDBContext.CommitAsync() > 0 ? true : false;
                }
                return false;
            }
        }
    }

    public class DeleteReservationCommandValidator : AbstractValidator<DeleteReservationCommand>
    {
        public DeleteReservationCommandValidator(INokoodDBContext nokoodDBContext)
        {
            RuleFor(r => r.Id)
                .NotEmpty()
                .NotNull()
                .NotEqual(Guid.Empty);

            RuleFor(r => r)
                .Must(r => nokoodDBContext.Reservations.Any(dt => dt.Id == r.Id))
                .WithErrorCode("Couldn't find an entity with the provided id!");
        }
    }
}
