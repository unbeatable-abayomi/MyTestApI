using MyTestApI.Data;
using MyTestApI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTestApI.Services
{
    public class CarsDataRepository: ICars
    {
        private readonly DataContext _dataContext;

        public CarsDataRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<Cars> Delete(long Id)
        {
          Cars car =   _dataContext.CarsTable.Find(Id);
            if(car != null)
            {
                _dataContext.CarsTable.Remove(car);
                await _dataContext.SaveChangesAsync();
            }
            return car;
           
        }
        public async Task<Cars> Get(long Id)
        {
          Cars car =  _dataContext.CarsTable.Find(Id);
            await _dataContext.SaveChangesAsync();
            return car;
        }


        public async Task<Cars> Update(Cars cars) {
             _dataContext.CarsTable.Update(cars);
            await _dataContext.SaveChangesAsync();
            return cars;

        }
        public async Task<Cars> Add(Cars cars)
        {
             _dataContext.CarsTable.Add(cars);
            await _dataContext.SaveChangesAsync();
            return cars;
        }

        public IEnumerable<Cars> GetCars()
        {
          return _dataContext.CarsTable;
        
        }
    }

}
