
namespace EF019.Seed
{
    public static class SeedData
    {
        public static IList<Client> InitializeData() // Initialize
        {
            return new List<Client>()
            {
                new Client()
                {
                    Name = "Bilal Sayed",
                    Country = "Egypt"
                },
                new Client()
                {
                    Name = "Amira Sayed",
                    Country = "Egypt"
                },
                new Client()
                {
                    Name = "Eid Sayed",
                    Country = "Egypt"
                },
            };
        }
    }
}
