namespace Summer.DAL.Entities.Base;

public abstract class BaseAuditableEntity
{
    public int Id { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime? DateModified { get; set; }
    public DateTime? DateDeleted { get; set; }
}