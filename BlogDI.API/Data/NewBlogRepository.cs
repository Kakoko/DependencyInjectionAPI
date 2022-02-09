using BlogDI.API.Models;

namespace BlogDI.API.Data
{
    public class NewBlogRepository : IBlogRepository

    { 
        
        public static List<Blog> blogs = new List<Blog>()
        {
            new Blog(){ Id = 1000 , Title = "DI Deep Dive",
            Content = "This is a five part series"},
            new Blog(){ Id = 2000 , Title = "Minimal API",
            Content = "Learn in 30 mins"},
            new Blog(){ Id = 3000 , Title = "Prescription API",
            Content = "Still under construction"}
        };

        public List<Blog> getAllBlogs()
        {
            return blogs;
        }
    }
}
