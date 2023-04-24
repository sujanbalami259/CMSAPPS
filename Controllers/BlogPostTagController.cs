using Microsoft.AspNetCore.Mvc;
using Models.Blog;
using Services;
using System.Threading.Tasks;

namespace CMSAPPS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogPostTagController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public BlogPostTagController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet, Route("~/api/admin/BlogPostTag")]
        public async Task<IActionResult> PostTag(BlogPostTag blogPostTag)
        {
            var data = await _unitOfWork.blogPostTagServices.BlogPostTag(blogPostTag);
            return Ok(data);
        }
    }
}
