using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;

namespace DataLayer.Repository
{
    internal interface IViewModelsRepository
    {
        IEnumerable<BrandViewModel> GetAllBrandNameId();
        IEnumerable<QuantityTypeViewModel> GetAllQuantityTypes();
        IEnumerable<ProductViewModel> GetAllProducts();
    }
}
