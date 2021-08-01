using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace myapi.Controllers{

    [ApiController]
    [Route("v1/add")]

    public class CaixaEletronicoController : ControllerBase
{
   [HttpGet]
   [Route("")]
   public async Task<ActionResult<List<CaixaEletronico>>> Get([FromServices] DataContext context){
       var CaixaEletronico = await ControllerContext.CaixaEletronico.ToListAsync();
       return CaixaEletronicoController;
   }
}

