using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vidal.UI.AppModelo.Data;
using Vidal.UI.AppModelo.Models;

namespace Vidal.UI.AppModelo.Controllers
{
    public class TestCrudController : Controller
    {
        private readonly MeuDbContext _dbContext;
        public TestCrudController(MeuDbContext contexto)
        {
            _dbContext = contexto;
        }
        public IActionResult Index()
        {
            var student = new Student()
            {
                Name = "Eduardo Pires",
                Grades = 8.3,
                Period =  3
            };

            _dbContext.Students.Add(student);
            _dbContext.SaveChanges();


            var student2 = _dbContext.Students.Find(student.Id);

            var student3 = _dbContext.Students.FirstOrDefaultAsync(x => x.Name == "Eduardo Pires");

            return View();
        }
    }
}
