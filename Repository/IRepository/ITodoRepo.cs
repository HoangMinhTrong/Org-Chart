using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using To_Do_App_MVC.Models;

namespace To_Do_App_MVC.Repository.IRepository
{
    public interface ITodoRepo
    {
        Task<IEnumerable<ToDo>> GetAllTodoAsync();
    }
}