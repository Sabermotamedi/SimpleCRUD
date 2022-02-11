using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Simple.API.Entity;
using Simple.API.Model;
using Simple.API.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simple.API.Service
{
    public class ProductService : IProductService
    {
        private readonly Context _context;
        private readonly IMapper _mapper;

        public ProductService(Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public AppResult Add(ProductViewModel product)
        {
            try
            {
                Product _product = _mapper.Map<Product>(product);
                var res = _context.Products.Add(_product);
                _context.SaveChanges();
                return AppResult.Ok(_product);
            }
            catch (Exception)
            {

                return AppResult.Fail();
            }
        }

        public AppResult Delete(int Id)
        {
            try
            {
                var product = _context.Products.FirstOrDefault(x => x.Id == Id);
                if (product != null)
                {
                    var res = _context.Products.Remove(product);
                    _context.SaveChanges();
                }
                return AppResult.Ok();
            }
            catch (Exception)
            {

                return AppResult.Fail();
            }
        }

        public AppResult Edite(ProductViewModel product)
        {
            try
            {
                //Product _product = _mapper.Map<Product>(product);
                var res = _context.Products.FirstOrDefault(x => x.Id == product.Id);
                res.Name = product.Name;
                res.Color = product.Color;
                res.Company = product.Company;
                res.Count = product.Count;
                res.UpdateDate = DateTime.Now;

                _context.SaveChanges();
                return AppResult.Ok(res);
            }
            catch (Exception ex)
            {

                return AppResult.Fail();
            }
        }

        public AppResult GetAll()
        {
            try
            {
                return AppResult.Ok(_context.Products.ToList());
            }
            catch (Exception)
            {
                return AppResult.Fail();
            }
        }

        public AppResult GetByID(int Id)
        {
            try
            {
                return AppResult.Ok(_context.Products.Find(Id));
            }
            catch (Exception)
            {
                return AppResult.Fail();
            }
        }
    }
}
