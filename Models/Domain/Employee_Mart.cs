namespace ISMT_Mart.Models.Domain
{
    public class Employee_Mart
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }

        public string? Email { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? Post { get; set; }

    }
}
