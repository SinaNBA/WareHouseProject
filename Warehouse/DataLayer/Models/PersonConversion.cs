using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public static class PersonConversion
    {
        public static Customers ToCustomer(this PersonModel personModel)
        {
            Customers customer = new Customers();
            customer.Name = personModel.Name;
            customer.Email = personModel.Email;
            customer.Phone = personModel.Phone;
            customer.Address = personModel.Address;
            customer.Image = personModel.Image;
            return customer;
        }

        public static Staffs ToStaff(this PersonModel personModel)
        {
            Staffs staff = new Staffs();
            staff.Name = personModel.Name;
            staff.Email = personModel.Email;
            staff.Phone = personModel.Phone;
            staff.Address = personModel.Address;
            staff.Image = personModel.Image;
            return staff;
        }

        public static Suppliers ToSupplier(this PersonModel personModel)
        {
            Suppliers supplier = new Suppliers();
            supplier.Name = personModel.Name;
            supplier.Email = personModel.Email;
            supplier.Phone = personModel.Phone;
            supplier.Address = personModel.Address;
            supplier.Image = personModel.Image;
            return supplier;
        }

        public static PersonModel ToPersonModel(this Customers customer)
        {
            PersonModel personModel = new PersonModel();
            personModel.Name = customer.Name;
            personModel.Email = customer.Email;
            personModel.Phone = customer.Phone;
            personModel.Address = customer.Address;
            personModel.Image = customer.Image;
            return personModel;
        }

        public static PersonModel ToPersonModel(this Staffs staff)
        {
            PersonModel personModel = new PersonModel();
            personModel.Name = staff.Name;
            personModel.Email = staff.Email;
            personModel.Phone = staff.Phone;
            personModel.Address = staff.Address;
            personModel.Image = staff.Image;
            return personModel;
        }

        public static PersonModel ToPersonModel(this Suppliers supplier)
        {
            PersonModel personModel = new PersonModel();
            personModel.Name = supplier.Name;
            personModel.Email = supplier.Email;
            personModel.Phone = supplier.Phone;
            personModel.Address = supplier.Address;
            personModel.Image = supplier.Image;
            return personModel;
        }

    }
}
