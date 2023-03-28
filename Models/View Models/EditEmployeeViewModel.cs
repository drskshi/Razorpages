namespace ISMT_Mart.Models.View_Models
{
    public class EditEmployeeViewModel
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }

        public string? Email { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? Post { get; set; }
    }
}
