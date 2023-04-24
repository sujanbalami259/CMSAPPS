using Microsoft.AspNetCore.Mvc;
using Models.Blog;
using Services;
using System.Threading.Tasks;

namespace CMSAPPS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : Controller
    {
       
       
            private readonly IUnitOfWork _unitOfWork;
            public LoginController(IUnitOfWork unitOfWork)
            {
                _unitOfWork = unitOfWork;
            }

            [HttpPost, Route("~/api/Login")]
            public async Task<IActionResult> Login(Login req)
            {
                var data = await _unitOfWork.userLoginService.UserLogin(req);
                return Ok(data);
            
        }
    }
}
