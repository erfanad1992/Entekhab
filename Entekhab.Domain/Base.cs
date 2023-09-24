namespace Entekhab.Domain
{
    public class Base
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string? Value { get; set; }
        public Int16 Status { get; set; }
        public string? FieldName { get; set; }
        public int? BaseId_Reference { get; set; }
    }
}
