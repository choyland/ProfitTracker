using ProfitTracker.BusinessLayer.Managers.Interfaces;
using System.Web.Http;

namespace ProfitTracker.Api.Controllers
{
    public class BetsController : ApiController
    {
        private readonly IBetManager _betManager;
        public BetsController(IBetManager betManager)
        {
            _betManager = betManager;
        }

        [HttpGet]
        public IHttpActionResult Get()
        {
            var allBets = _betManager.GetAllBets();

            return Ok(allBets);
        }
    }
}
