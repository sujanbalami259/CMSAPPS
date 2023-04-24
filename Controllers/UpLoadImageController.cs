using Microsoft.AspNetCore.Mvc;
using Models.Blog;
using Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CMSAPPS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UpLoadImageController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public UpLoadImageController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost, Route("~/api/upload image")]
        public async Task<IActionResult>loadImage(UploadImage req)
        {
            var data = await _unitOfWork.upLoadImageService.UpoadImage(req);
            return Ok(data);

        }
    }
}