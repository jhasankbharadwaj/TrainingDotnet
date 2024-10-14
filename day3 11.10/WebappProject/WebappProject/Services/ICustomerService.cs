using WebappProject.Models;

namespace WebappProject.Services
{
    public interface ICustomerService
    {
        Task<List<CustEntity>> GetAllCustomer();

        Task<CustEntity?> GetCustomersByID(int id);

        Task<CustEntity> AddCustomer(AddOrUpdateCustomer customer);

        Task<CustEntity?> UpdateCustomer(int id, AddOrUpdateCustomer customer);

        Task<bool> DeleteCustomerByID(int id);



    }
}
