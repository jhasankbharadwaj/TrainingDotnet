namespace ProductApi.Model
{
    public class Category
    {
        internal object _dbContext;

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
