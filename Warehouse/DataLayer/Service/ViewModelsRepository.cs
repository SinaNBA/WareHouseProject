using DataLayer.Models;
using DataLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;

namespace DataLayer
{
    public class ViewModelsRepository : IViewModelsRepository
    {
        private readonly WarehouseEntities db;

        public ViewModelsRepository(WarehouseEntities warehouseEntities)
        {
            db = warehouseEntities;
        }

        public IEnumerable<BrandViewModel> GetAllBrandNameId()
        {
            return db.Brands.Select(b => new BrandViewModel()
            {
                Id = b.Id,
                Title = b.Title,
            }).ToList();
        }

        public IEnumerable<QuantityTypeViewModel> GetAllQuantityTypes()
        {
            return db.QuantityType.Select(q => new QuantityTypeViewModel()
            {
                Id = q.Id,
                Type = q.Type,
            }).ToList();
        }

        public IEnumerable<ProductViewModel> GetAllProducts()
        {
            return db.Products.Select(p => new ProductViewModel()
            {
                Id = p.Id,
                Name = p.Name,
                Stock = p.Stock,
                QuantityType = db.QuantityType.Where(q => q.Id == p.QuantityTypeId).Select(q => q.Type).FirstOrDefault(),
                Brand = db.Brands.Where(b => b.Id == p.BrandId).Select(b => b.Title).FirstOrDefault(),
            }).ToList();
        }
    }
}
