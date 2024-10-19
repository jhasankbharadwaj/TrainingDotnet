using Azure;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Xml.Linq;
using WebappProject.Data;
using WebappProject.Models;
using static Azure.Core.HttpHeader;

namespace WebappProject.Services
{
    public class CustomerServices : ICustomerService
    {
        private readonly WebappProjectContext _Contextdb;
        public CustomerServices(WebappProjectContext context)
        {
            _Contextdb = context;
        }

        public WebappProjectContext Get_Contextdb()
        {
            return _Contextdb;
        }

        public async Task<CustEntity> AddCustomer(AddOrUpdateCustomer customer)
        {
            var cust = new CustEntity()
            {
                age= customer.Age,
                phone=customer.phone,
                city=customer.city,
                country=customer.country,
                Name   =customer.Name,
                
            };
            _Contextdb.CustEntitys.Add(cust);
            await _Contextdb.SaveChangesAsync();
            return cust;
        }

        public async Task<bool> DeleteCustomerByID(int id)
        {
            var cust=await _Contextdb.CustEntitys.FirstOrDefaultAsync(x => x.Id == id);
            if (cust != null) { return false;
            } else {
                _Contextdb.CustEntitys.Remove(cust);
                _Contextdb.SaveChangesAsync();
                return true;
            }

        }

        public async Task<List<CustEntity>> GetAllCustomer()
        {
            return await _Contextdb.CustEntitys.ToListAsync();
        }

        public async Task<CustEntity?> GetCustomersByID(int id)
        {
            return await _Contextdb.CustEntitys.FirstOrDefaultAsync(cust => cust.Id == id);
        }

        public async Task<CustEntity?> UpdateCustomer(int id, AddOrUpdateCustomer customer)
        {
            var cust = await _Contextdb.CustEntitys.FirstOrDefaultAsync(index => index.Id == id);
            if (cust != null)
            {
               cust. age = customer.Age;
               cust. phone = customer.phone;
               cust. city = customer.city;
               cust. country = customer.country;
               cust. Name = customer.Name;
                
                var result = await _Contextdb.SaveChangesAsync();
                return result >= 0 ? cust : null;
            }
            return null;
        }
    }

       
    
}
