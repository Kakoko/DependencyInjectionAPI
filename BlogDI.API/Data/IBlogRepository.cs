using BlogDI.API.Models;

namespace BlogDI.API.Data
{
    public interface IBlogRepository
    {
        List<Blog> getAllBlogs();
    }
}