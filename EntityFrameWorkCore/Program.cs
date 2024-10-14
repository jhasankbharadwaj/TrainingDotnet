using EntityFrameWorkCore;

internal class Program
{
    public  static void Main(string[] args)
    {
        using (EmpEventContext context = new EmpEventContext())
        {
            var emp=new Employee() { Id = 1 ,Name="jhasank",Experience=9};
            context.Employees.Add(emp);
            context.SaveChanges();
            Console.Write("just added a employee ");
        }

      
     }

}
