using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class CarFindeksManager : ICarFindeksService
    {
        private ICarFindeksDal _carFindeksDal;

        public CarFindeksManager(ICarFindeksDal carFindeksDal)
        {
            _carFindeksDal = carFindeksDal;
        }

        public IResult Add(CarFindeks carFindeks)
        {
            
               _carFindeksDal.Add(carFindeks);
            return new SuccessResult(Messages.CarFindeksAdded);
        }

        public IResult Delete(CarFindeks carFindeks)
        {
            _carFindeksDal.Delete(carFindeks);
            return new SuccessResult(Messages.CarFindeksDeleted);
        }

        public IDataResult<List<CarFindeks>> GetAll()
        {
            return new SuccessDataResult<List<CarFindeks>>(_carFindeksDal.GetAll());
        }

        public IDataResult<List<CarFindeksDetailDto>> GetCarFindeksDetail()
        {
            return new SuccessDataResult<List<CarFindeksDetailDto>>(_carFindeksDal.GetFindeksDetail());
        }

        public IDataResult<List<CarFindeksDetailDto>> GetCarFindeksDetailByCarId(int carId)
        {
            List<CarFindeksDetailDto> carFindeksDetail = _carFindeksDal.GetFindeksDetail(x => x.CarId == carId);
            return new SuccessDataResult<List<CarFindeksDetailDto>>(carFindeksDetail);
        }

        public IDataResult<List<CarFindeksDetailDto>> GetCarFindeksDetailById(int findeksId)
        {
            List<CarFindeksDetailDto> carFindeksDetail = _carFindeksDal.GetFindeksDetail(x => x.FindeksId == findeksId);
            return new SuccessDataResult<List<CarFindeksDetailDto>>(carFindeksDetail);
        }

        public IResult Update(CarFindeks carFindeks)
        {
           _carFindeksDal.Update(carFindeks);
           return new SuccessResult(Messages.CarFindeksUpdated);
        }
    }
}
