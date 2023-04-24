using Microsoft.AspNetCore.Mvc;
using Models;
using Models.Blog;
using Services;
using System.Threading.Tasks;

namespace CMSAPPS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public NotificationController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost, Route("~/api/admin/notification")]
        public async Task<IActionResult> SendNotification(SendNotification sendNotification)
        {
            var data = await _unitOfWork.sendNotificationService.SendNotification(sendNotification);
            return Ok(data);

        }
    }
}

