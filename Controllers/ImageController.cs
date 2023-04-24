using Microsoft.AspNetCore.Mvc;
using Models.Blog;
using Services;
using Services.Service;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CMSAPPS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public ImageController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost, Route("~/api/upload-single-image")]
        public async Task<IActionResult> ImageUpload(ImageReq req)
        {
            var data = await _unitOfWork.imageService.UploadImage(req);
            return Ok(data);

        }

        [HttpPost, Route("~/api/upload-bulk-image")]
        public async Task<IActionResult> ImageLoad(List<ImageReq> req)
        {
            var data = await _unitOfWork.imageService.BulkUpload(req);
            return Ok(data);

        }
    }
}
