using Labb3Api.Models;
using Labb3Api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Labb3Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Labb3Controller : ControllerBase
    {
        private IUser _user;
        public Labb3Controller(IUser users)
        {
            _user = users;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                return Ok(await _user.GetAll());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error to get data from database......");
            }
        }

        [HttpGet("Interests/{id:int}")]
        public async Task<ActionResult> GetAllUserInterests(int id)
        {
            try
            {
                var result = await _user.GetUserInterests(id);
                if (result == null)
                {
                    return NotFound();
                }
                return Ok(result);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error to get data from database......");
            }
        }

        [HttpGet("Links/{id:int}")]
        public async Task<ActionResult> GetAllUserLinks(int id)
        {
            try
            {
                var result = await _user.GetUserLinks(id);
                if (result == null)
                {
                    return NotFound();
                }
                return Ok(result);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error to get data from database......");
            }
        }
        [HttpPost("Uinterests")]

        public async Task<IActionResult> UpdateInterests(UserConnectionDTO dto)
        {
            try
            {
                var result = new UserConnection();
                result.UserID = dto.UserID;
                result.InterestsID = dto.InterestsID;

                return Ok(await _user.UserNewInterest(result));
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error to update data to database......");
            }
        }

        [HttpPost("AddLinks")]
        public async Task<IActionResult> AddLinks(string newLink, int Id, int InterestID, int LinkID)
        {
            try
            {
                var result = await _user.AddLink(newLink, Id, InterestID, LinkID);
                return Ok(result);
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error to add data to database......");
            }
        }

    }
}
