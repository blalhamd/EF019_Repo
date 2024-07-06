
namespace EF019
{
    public interface ISoftDelete
    {
        bool IsDeleted { get; set; }
        DateTime? dateTime { get; set; }

        public void Delete()
        {
            dateTime = DateTime.Now;
            IsDeleted = true;
        }

        public void UndoDelete()
        {
            IsDeleted = false;
            dateTime = null;
        }
    }
}
