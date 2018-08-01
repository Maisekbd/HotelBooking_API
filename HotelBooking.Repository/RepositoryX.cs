using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackableEntities.Common.Core;
using URF.Core.EF.Trackable;

namespace HotelBooking.Repository
{
    public class RepositoryX<TEntity> : TrackableRepository<TEntity>, IRepositoryX<TEntity> where TEntity : class, ITrackable
    {
        public RepositoryX(DbContext context) : base(context)
        {

        }

    }
}
