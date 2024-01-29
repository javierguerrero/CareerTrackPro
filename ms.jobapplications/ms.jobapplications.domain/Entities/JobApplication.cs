namespace ms.jobapplications.domain.Entities
{
    public class JobApplication
    {
        public int Id { get; set; }
        public string Position { get; set; }
        public string Organization { get; set; }
        public string City { get; set; }
        public string LinkToJobOffer { get; set; }
        public string Salary { get; set; }
        public string ContactDetails { get; set; }
        public string Notes { get; set; }
    }
}
