using ISMT_Mart.Data;
using ISMT_Mart.Models.Domain;
using ISMT_Mart.Models.View_Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ISMT_Mart.Pages.Employees
{
    public class AddModel : PageModel
    {
        private readonly ISMT_MartDbContext dbContext;

        public AddModel(ISMT_MartDbContext dbContext)
        {
            this.dbContext = dbContext;

        }
        [BindProperty]
        public Addstaffviewmodel AddEmployeeRequest { get; set; }
        public void OnGet()
        {
        }
        public void OnPost()
        {
            //Convert viewmodel into DomainModel
            var Employee_MartDomainModel = new Employee_Mart
            {
                Name = AddEmployeeRequest.Name,
                Email = AddEmployeeRequest.Email,
                CreatedDate = AddEmployeeRequest.CreatedDate,
                Post = AddEmployeeRequest.Post,
            };
            
            dbContext.Employee.Add(Employee_MartDomainModel);
            dbContext.SaveChanges();
            ViewData["Message"] = "The new staff created successfully"
        ;
        }
    }
}
