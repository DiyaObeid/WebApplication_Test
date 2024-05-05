using Microsoft.AspNetCore.Mvc;
using WebApplication_Test.IService;
using WebApplication_Test.Models;

namespace WebApplication_Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoveController : ControllerBase
    {
        private readonly IMovesService _movesService;

        public MoveController(IMovesService movesService)
        {
            _movesService = movesService;
        }

        [HttpPost]
        [Route("AddMove")]
        public async Task<IActionResult> AddMove(Moves move)
        {
            var result = await _movesService.AddMove(move);
            if (result)
                return Ok(result);

            else
            {
                return BadRequest("Move hasnt Added ");
            }
        }


        [HttpDelete]
        [Route("Delete")]
        public async Task<IActionResult> DeleteMove(Guid Id)
        {
            var result = await _movesService.DeleteMove(Id);
            if (result)
                return Ok(result);

            else
            {
                return BadRequest("Move hasnt Deleted ");
            }
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _movesService.GetAll();
            if (result != null)
                return Ok(result);

            else
            {
                return BadRequest("No Data ");
            }
        }

        [HttpPut]
        [Route("UpdateMove")]
        public async Task<IActionResult> UpdateMove(Moves move)
        {
            var result = await _movesService.UpdateMove(move);
            if (result)
                return Ok(result);

            else
            {
                return BadRequest("No Data ");
            }
        }
    }
}
