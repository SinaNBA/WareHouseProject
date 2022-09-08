using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class WarehouseContext : IDisposable
    {
        WarehouseEntities db = new WarehouseEntities();
        private Repository<Brands> _brandRepository;
        public Repository<Brands> BrandRepository
        {
            get
            {
                if (_brandRepository == null)
                {
                    _brandRepository = new Repository<Brands>(db);
                }
                return _brandRepository;
            }
        }

        private Repository<Customers> _customerRepository;
        public Repository<Customers> CustomerRepository
        {
            get
            {
                if (_customerRepository == null)
                {
                    _customerRepository = new Repository<Customers>(db);
                }
                return _customerRepository;
            }
        }
        private Repository<Products> _productRepository;
        public Repository<Products> ProductRepository
        {
            get
            {
                if (_productRepository == null)
                {
                    _productRepository = new Repository<Products>(db);
                }
                return _productRepository;
            }
        }
        private Repository<Receives> _receiveRepository;
        public Repository<Receives> ReceiveRepository
        {
            get
            {
                if (_receiveRepository == null)
                {
                    _receiveRepository = new Repository<Receives>(db);
                }
                return _receiveRepository;
            }
        }

        private Repository<Ships> _shipRepository;
        public Repository<Ships> ShipRepository
        {
            get
            {
                if (_shipRepository == null)
                {
                    _shipRepository = new Repository<Ships>(db);
                }
                return _shipRepository;
            }
        }

        private Repository<Staffs> _staffRepository;
        public Repository<Staffs> StaffRepository
        {
            get
            {
                if (_staffRepository == null)
                {
                    _staffRepository = new Repository<Staffs>(db);
                }
                return _staffRepository;
            }
        }

        private Repository<Suppliers> _supplierRepository;
        public Repository<Suppliers> SupplierRepository
        {
            get
            {
                if (_supplierRepository == null)
                {
                    _supplierRepository = new Repository<Suppliers>(db);
                }
                return _supplierRepository;
            }
        }

        // 
        private ViewModelsRepository _viewModels;
        public ViewModelsRepository ViewModels
        {
            get
            {
                if (_viewModels == null)
                {
                    _viewModels = new ViewModelsRepository(db);
                }
                return _viewModels;
            }
        }
        public void Save()
        {
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
