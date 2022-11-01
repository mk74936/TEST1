namespace TEST1.API.Models.Domain
{
    public class student
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Branch { get; set; }

        public Double Percentage { get; set; }
        public Guid CollegeID { get; set; }

        public Guid EventID { get; set; }

        //Navigation Properties

        public college college { get; set; }
        public Event Event { get;set; }

    }
}
