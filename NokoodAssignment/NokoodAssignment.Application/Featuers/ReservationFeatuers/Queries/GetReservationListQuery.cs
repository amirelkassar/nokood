using MediatR;
using Microsoft.EntityFrameworkCore;
using NokoodAssignment.Application.Base;
using NokoodAssignment.Application.Dots;
using System.Linq.Dynamic.Core;

namespace NokoodAssignment.Application.Featuers.ReservationFeatuers.Queries
{
    public class GetReservationListQuery : ListQueryArgs, IRequest<ApiResponse<IEnumerable<ReservationReadDto>>>
    {
        public class GetReservationListQueryHandler : IRequestHandler<GetReservationListQuery, ApiResponse<IEnumerable<ReservationReadDto>>>
        {
            private readonly INokoodDBContext nokoodDBContext;

            public GetReservationListQueryHandler(INokoodDBContext nokoodDBContext)
            {
                this.nokoodDBContext = nokoodDBContext;
            }
            public async Task<ApiResponse<IEnumerable<ReservationReadDto>>> Handle(GetReservationListQuery request, CancellationToken cancellationToken)
            {
                request.Sorting ??= "ReservationDate";
                var reservationsQueryable = nokoodDBContext.Reservations.AsQueryable();
                if (!string.IsNullOrWhiteSpace(request.Search))
                {
                    reservationsQueryable = reservationsQueryable.Where(r => r.CustomerName.ToLower().StartsWith(request.Search.ToLower()));
                }
                var reservations = await reservationsQueryable
                    .OrderBy(request.Sorting)
                    .Skip((request.PageNumber - 1) * request.PageSize)
                    .Take(request.PageSize)
                    .ToArrayAsync(cancellationToken);

                var reservationDtos = new List<ReservationReadDto>();
                foreach (var reservation in reservations)
                {
                    reservationDtos.Add((ReservationReadDto)reservation);
                }
                return new ApiResponse<IEnumerable<ReservationReadDto>>
                {
                    Success = true,
                    Code = 200,
                    Data = reservationDtos,
                    Message = "Retrieved"
                };
            }
        }
    }
}
