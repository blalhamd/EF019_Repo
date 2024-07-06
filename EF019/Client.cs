
namespace EF019
{
    public class Client : ISoftDelete
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Country { get; set; } = null!;
        public bool IsDeleted { get; set; }
        public DateTime? dateTime { get; set; }

       
    }
}
