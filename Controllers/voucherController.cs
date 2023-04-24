using Microsoft.AspNetCore.Mvc;
using Models.Blog;
using Services;
using System.Threading.Tasks;

namespace CMSAPPS.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class voucherController : Controller
    {
       private readonly IUnitOfWork _unitOfWork;
            public  voucherController(IUnitOfWork unitOfWork)
            {
                _unitOfWork = unitOfWork;
            }

            [HttpPost, Route("~/api/Voucher")]
            public async Task<IActionResult> Voucher(Voucher voucher)
            {
                var data = await _unitOfWork.voucherService.Voucher(voucher);
                return Ok(data);
            }
        }
    }

