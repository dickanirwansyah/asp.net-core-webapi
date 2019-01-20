using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using TodoApi.Models;

namespace TodoApi.Controllers 
{   

    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly TodoContext _context;

        public TodoController(TodoContext todoContext)
        {
            _context = todoContext;
            if(_context.TodoItems.Count() == 0)
            {   
                /** using dummy data */
                _context.TodoItems.Add(new TodoItem {firstname = "Muhammad", 
                lastname = "Dicka Nirwansyah", isComplete = true}); 
                _context.SaveChanges();
            }

        }

        [HttpGet]
        public ActionResult<List<TodoItem>> getAll()
        {
            return _context.TodoItems.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<TodoItem> getId(long Id)
        {
            var item = _context.TodoItems.Find(Id);
            if (item == null){
                return NotFound();
               }
            return item;
        }
    }
}