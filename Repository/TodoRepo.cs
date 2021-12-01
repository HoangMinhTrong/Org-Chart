using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using To_Do_App_MVC.Data;
using To_Do_App_MVC.Models;
using To_Do_App_MVC.Repository.IRepository;

namespace To_Do_App_MVC.Repository
{
    public class TodoRepo : ITodoRepo
    {
        private readonly ApplicationDbContext _context;

        public TodoRepo(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<ToDo>> GetAllTodoAsync()
        {
             var obj = _context.ToDos.ToList();
             return obj;
        }
    }
}