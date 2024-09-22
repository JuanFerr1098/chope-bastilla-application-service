namespace ChopeBastillaApplicationService.CommonDomian.Entity
{
    public abstract class BaseEntity<ID> /*where ID : BaseId<object>*/
    {
        public ID? Id { get; set; }

        protected BaseEntity(ID? id)
        {
            Id = id;
        }

        public override bool Equals(object? obj)
        {
            return obj is BaseEntity<ID> entity &&
                   EqualityComparer<ID?>.Default.Equals(Id, entity.Id);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}
