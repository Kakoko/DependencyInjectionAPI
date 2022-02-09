using BlogDI.API.Data;
using BlogDI.API.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlogDI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogsController : ControllerBase
    {
        private readonly IBlogRepository _repository;

        public BlogsController(IBlogRepository repository)
        {
            _repository = repository;
        }
       // BlogRepository repository = new BlogRepository();
       

        // GET: api/<BlogsController>
        [HttpGet]
        public ActionResult<IEnumerable<Blog>> Get()
        {
            var blogs = _repository.getAllBlogs();
            return Ok(blogs);
        }
    }
}
