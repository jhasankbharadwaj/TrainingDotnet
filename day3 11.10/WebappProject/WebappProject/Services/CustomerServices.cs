using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Xml.Linq;
using WebappProject.Models;

namespace WebappProject.Services
{
    public class CustomerServices : ICustomerService
    {
        private readonly List<CustEntity> _CustomersList;
        public CustomerServices() {
            _CustomersList = new List<CustEntity>()
            { new CustEntity(){
                Id = 1,
                Name = "Jhasank",
                age = 9,
                city = "hyd",
            country="india",
            phone=909090,
            }

            };
        }

        public CustEntity AddCustomer(AddOrUpdateCustomer obj)
        {
            var Addcustomer = new CustEntity()
            {
                Id = _CustomersList.Count() + 1,
                Name = obj.Name,
                city = obj.city,
                country = obj.country,
                age = obj.Age,
                phone  = obj.phone,

            };
            _CustomersList.Add(Addcustomer);
            return Addcustomer;
        }   

        public bool DeleteCustomerByID(int id)
        {
            if (_CustomersList.Count > 0)
            {
                
                    _CustomersList.RemoveAt(id);
                    
                    return true;
                
            }

            return false;
        }

        public List<CustEntity> GetAllCustomer()
        {
            return _CustomersList.ToList();

        }

        public CustEntity? GetCustomersByID(int id)
        {
            foreach(var item in _CustomersList)
            {
                if(item.Id== id)
                {
                    return item; 
                }
            }
            return null;
        }

        public CustEntity? UpdateCustomer(int id, AddOrUpdateCustomer obj)
        {
            if(obj == null)
            {
                return null;
            }
            foreach (var item in _CustomersList)
            {
                if (item.Id == id)
                {
                    item.Id = item.Id;
                    item.Name = obj.Name;
                    item.city = obj.city;
                    item.country = obj.country;
                    item.age = obj.Age;
                    item.phone = obj.phone;                }
            }
            return null;
        }
    }
}
