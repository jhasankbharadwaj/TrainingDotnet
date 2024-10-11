namespace dayone0910.Models
{
    public class DataLoader
    {
        public empModel GetEmpDetails()
        {
            empModel emp = new empModel()
            {
                Id = 90,
                Name = "jhasank",
                salary = 90000,
                gender = "male"
            };
            return empModel;
        }
    }
}
