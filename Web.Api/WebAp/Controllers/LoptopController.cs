using Microsoft.AspNetCore.Mvc;
using System.Collections;


namespace WebAp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoptopController:ControllerBase
    {
        private static List<Loptops> loptops = new List<Loptops>
        {
          //  new Loptops(),
            new Loptops{ Id = 1, Name=" HP " , Manufacturer=" Hp " , Description="bla_bla", Hard_Drive="ssd" ,Ram=16 ,CPU="ddo", Price=12345 }, 
            new Loptops{ Id = 2, Name=" HP " , Manufacturer=" Hp " , Description="bla_bla", Hard_Drive="ssd" ,Ram=16 ,CPU="ddo", Price=12345 },
            new Loptops{ Id = 3, Name=" HP " , Manufacturer=" Hp " , Description="bla_bla", Hard_Drive="ssd" ,Ram=16 ,CPU="ddo", Price=12345 }
        };
        [HttpGet]
        public ActionResult<List<Loptops>> Get()
        {
            return Ok(loptops);
        }
    }
}
