namespace Leave_Management.Data
{
    // abstract means that it cannnot be instantiated by itself
    // BaseEntity is used to not duplicate that fields that are in every class
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }
    }
}
