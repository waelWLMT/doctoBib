using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RendezVousController : ControllerBase
    {
        public RendezVousController()
        {
            
        }


        public List<RendezVousReadDto> GetAllRendezVous()
        {

        }

    }
}
