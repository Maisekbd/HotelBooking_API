using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;
using TrackableEntities.Common.Core;
using URF.Core.Abstractions.Trackable;



namespace HotelBooking.Repository
{
    // Example: extending IRepository<TEntity> and/or ITrackableRepository<TEntity>, scope: application-wide
    public interface IRepositoryX<TEntity> : ITrackableRepository<TEntity> where TEntity : class, ITrackable
    {
        // Example: adding synchronous Find, scope: application wide for all repositories
        //TEntity Find(object[] keyValues, CancellationToken cancellationToken = default);
    }
}
