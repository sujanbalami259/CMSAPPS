using Microsoft.AspNetCore.Mvc;
using Models.Blog;
using Services;
using System.Threading.Tasks;

namespace CMSAPPS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogTagController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public BlogTagController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet, Route("~/api/admin/BlogTag")]
        public async Task<IActionResult>Tag(BlogTag blogTag)
        {
            var data = await _unitOfWork.blogTagService.BlogTag(blogTag);
            return Ok(data);
        }
    }
}
