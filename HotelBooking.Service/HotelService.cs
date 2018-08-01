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
    public class HotelService : Service<Hotel>, IHotelService
    {
        readonly IRepositoryAsync<Hotel> _repository;
        readonly IUnitOfWorkAsync _unitOfWorkAsync;

        public HotelService(
            IRepositoryAsync<Hotel> repository,
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

        public IQueryable<Hotel> GetAll()
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

        public int InsertHotel(Hotel hotel)
        {
            try
            {

                _unitOfWorkAsync.BeginTransaction();
                hotel.ObjectState = ObjectState.Added;
                Insert(hotel);
                _unitOfWorkAsync.SaveChanges();
                _unitOfWorkAsync.Commit();
                return hotel.Id;
            }
            catch { _unitOfWorkAsync.Rollback(); throw; }
        }

        public void UpdateHotel(Hotel hotel)
        {
            try
            {
                _unitOfWorkAsync.BeginTransaction();
                var obEntity = Find(hotel.Id);
                obEntity.Name = hotel.Name;
                obEntity.RoomsNo = hotel.RoomsNo;
                obEntity.Description = hotel.Description;
                obEntity.Location = hotel.Location;
                hotel.ObjectState = ObjectState.Modified;
                Update(obEntity);
                _unitOfWorkAsync.SaveChanges();
                _unitOfWorkAsync.Commit();
            }
            catch { _unitOfWorkAsync.Rollback(); throw; }
        }
    }
}