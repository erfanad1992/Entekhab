namespace Entekhab.Domain
{
    public class TestModel
    {
        public TestModel(string name, string email, long id)
        {
            Name = name;
            Email = email;
            Id = id;
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public long Id { get; set; }
    }
}
