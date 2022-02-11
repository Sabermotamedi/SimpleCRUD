using Simple.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simple.API.Service.Interface
{
    public interface IProductService
    {
        public AppResult GetAll();
        public AppResult GetByID(int Id);
        public AppResult Add(ProductViewModel product);
        public AppResult Edite(ProductViewModel product);
        public AppResult Delete(int Id);
    }
}
