using WebappProject.Models;

namespace WebappProject.Services
{
    public interface ICustomerService
    {
        List<CustEntity> GetAllCustomer();

        CustEntity? GetCustomersByID(int id);

        CustEntity AddCustomer(AddOrUpdateCustomer obj);

        CustEntity? UpdateCustomer(int id, AddOrUpdateCustomer obj);

        bool DeleteCustomerByID(int id);


    }
}
