

using Flunt.Notifications;

namespace IWantApp.Domain.Products;

public abstract class Entity : Notifiable<Notification>
{
    public Entity()
    {
        id = Guid.NewGuid();
    }

    public Guid id { get; set; }
    public string Name { get; set; }
    public string CreatedBy { get; set; }
    public DateTime CreatedOn { get; set; }
    public string EditedBy { get; set; }
    public DateTime EditedOn { get; set; }
}
