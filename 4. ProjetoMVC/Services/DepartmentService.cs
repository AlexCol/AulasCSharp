using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _4._ProjetoMVC.Models;

namespace _4._ProjetoMVC.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvcContext _context;

        public DepartmentService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(d => d.Name).ToList();
        }
    }
}