using HotelBooking.Model;
using Repository.Pattern.Infrastructure;
using Repository.Pattern.Repositories;
using Repository.Pattern.UnitOfWork;
using Service.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBooking.Service
{
    public class HotelReservationService : Service<HotelReservation>, IHotelReservationService
    {
        readonly IRepositoryAsync<HotelReservation> _repository;
        readonly IUnitOfWorkAsync _unitOfWorkAsync;

        public HotelReservationService(
            IRepositoryAsync<HotelReservation> repository,
            IUnitOfWorkAsync unitOfWorkAsync
            ) : base(repository)
        {
            _repository = repository;
            _unitOfWorkAsync = unitOfWorkAsync;
        }

        public void Delete(int id)
        {
            try
            {
                //TODO:Throw clear exception once delete object has childs
                _unitOfWorkAsync.BeginTransaction();
                _repository.Delete(id);
                _unitOfWorkAsync.SaveChanges();
                _unitOfWorkAsync.Commit();
            }
            catch { _unitOfWorkAsync.Rollback(); throw; }
        }

        public IQueryable<HotelReservation> GetAll()
        {
            try
            {
                return _repository.Query().SelectQueryable();
            }
            catch { throw; }
        }

        public Hotel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int InsertHotelReservation(HotelReservation hotelReservation)
        {
            try
            {

                _unitOfWorkAsync.BeginTransaction();
                hotelReservation.ObjectState = ObjectState.Added;
                Insert(hotelReservation);
                _unitOfWorkAsync.SaveChanges();
                _unitOfWorkAsync.Commit();
                return hotelReservation.Id;
            }
            catch { _unitOfWorkAsync.Rollback(); throw; }
        }

        public void UpdateHotelReservation(HotelReservation hotelReservation)
        {
            try
            {
                _unitOfWorkAsync.BeginTransaction();
                Update(hotelReservation);
                _unitOfWorkAsync.SaveChanges();
                _unitOfWorkAsync.Commit();
            }
            catch { _unitOfWorkAsync.Rollback(); throw; }
        }
    }
}