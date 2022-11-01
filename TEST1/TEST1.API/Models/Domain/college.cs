namespace TEST1.API.Models.Domain
{
    public class college
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public Guid StudentID   { get; set; }

        //Navigation Properties

        public IEnumerable<student> students { get; set; }

    }
}
