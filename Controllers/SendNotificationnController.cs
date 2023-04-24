using Microsoft.AspNetCore.Mvc;
using Models.Blog;
using Services;
using System.Threading.Tasks;

namespace CMSAPPS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SendNotificationnController : Controller
    {


        private readonly IUnitOfWork _unitOfWork;
        public SendNotificationnController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost, Route("~/api/send-notification")]
        public async Task<IActionResult> Notify(PushNotificationss req)
        {
            var data = await _unitOfWork.pushNotificationssService.PushNotificationss(req);
            return Ok(data);
        }
    }
}