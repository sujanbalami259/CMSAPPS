 using Microsoft.AspNetCore.Mvc;
using Models.Blog;
using Services;
using System.Threading.Tasks;

namespace CMSAPPS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogPostController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public BlogPostController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost, Route("~/api/admin/BlogPost")]
        public async Task<IActionResult>Post(BlogPost blogPost)
        {
            var data = await _unitOfWork.blogPostService.BlogPost(blogPost);
            return Ok(blogPost);

        }
    }
}