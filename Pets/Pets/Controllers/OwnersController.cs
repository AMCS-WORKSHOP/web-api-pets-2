using Microsoft.AspNetCore.Mvc;

namespace Pets.Controllers
{
    [ApiController]
    [Route("/api/owners/{ownerId}")]
    public class OwnersController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetOwner(int ownerId)
        {
            var owner = DataStore.Owners.SingleOrDefault(o => o.Id == ownerId);

            if (owner == null)
            {
                return NotFound($"Owner with id of {ownerId} does not exist.");
            }

            return Ok(owner);
        }

        [HttpGet("pets/{petId}")]
        public ActionResult GetPetByOwner(int ownerId, int petId)
        {
            var owner = DataStore.Owners.SingleOrDefault(o => o.Id == ownerId);

            if (owner == null)
            {
                return NotFound($"Owner with id of {ownerId} does not exist.");
            }

            var pet = owner.Pets.SingleOrDefault(p => p.Id == petId);

            if (pet == null)
            {
                return NotFound($"Owner with id of {ownerId} does not own a pet with id {petId}");
            }

            return Ok(pet);
        }
    }
}
