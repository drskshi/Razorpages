using ISMT_Mart.Data;
using ISMT_Mart.Models.View_Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ISMT_Mart.Pages.Employees
{
    public class EditModel : PageModel
    {
        private readonly ISMT_MartDbContext dbContext;

        [BindProperty]
        public EditEmployeeViewModel EditEmployeeViewModel { get; set; }

        public EditModel(ISMT_MartDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void OnGet(Guid id)
        {

            var employee = dbContext.Employee.Find(id);

            if (employee != null)
            {
                //Convert domain model to view model
                EditEmployeeViewModel = new EditEmployeeViewModel()
                {
                    Id = employee.Id,
                    Name = employee.Name,
                    Email = employee.Email,
                    CreatedDate = employee.CreatedDate,
                    Post = employee.Post,
                };

            }
        }
        public void OnPostUpdate()
        {
            if (EditEmployeeViewModel != null)
            {
                var existingEmployee = dbContext.Employee.Find(EditEmployeeViewModel.Id);
                if (existingEmployee != null)
                {
                    //Convert ViewModel to DomainModel

                    existingEmployee.Id = EditEmployeeViewModel.Id;
                    existingEmployee.Name = EditEmployeeViewModel.Name;
                    existingEmployee.Email = EditEmployeeViewModel.Email;
                    existingEmployee.CreatedDate = EditEmployeeViewModel.CreatedDate;
                    existingEmployee.Post = EditEmployeeViewModel.Post;

                    dbContext.SaveChanges();

                    ViewData["Message"] = "Updated Successfully";
                   
                }
            }

        }


        public IActionResult OnPostDelete()
        {
            var existingEmployee = dbContext.Employee.Find(EditEmployeeViewModel.Id);

            if (existingEmployee != null)
            {
                dbContext.Employee.Remove(existingEmployee);
                dbContext.SaveChanges();

                return RedirectToPage("/Employees/List");
            }
            return Page();
        }
    }
}
