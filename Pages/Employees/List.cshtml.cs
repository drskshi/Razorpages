using ISMT_Mart.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ISMT_Mart.Pages.Employees
{
    public class ListModel : PageModel
    {
        private readonly ISMT_MartDbContext dbContext;
        public List<Models.Domain.Employee_Mart> Employees { get; set; }

        public ListModel(ISMT_MartDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void OnGet()
        {
            Employees = dbContext.Employee.ToList();
        }
    }
}
