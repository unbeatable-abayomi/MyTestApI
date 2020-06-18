using MyTestApI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTestApI.Services
{
    public interface ICars
    {
        public IEnumerable<Cars> GetCars();
        public Task<Cars> Add(Cars cars);

        public Task<Cars> Delete(long Id);
        public Task<Cars>  Get(long Id);

        public Task<Cars> Update(Cars cars);

   
    }
}
