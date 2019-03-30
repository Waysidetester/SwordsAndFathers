using Microsoft.AspNetCore.Mvc;
using SwordandFather.Data;
using SwordandFather.Models;
using SwordandFather.Validators;

namespace SwordandFather.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssassinController : ControllerBase
    {
        readonly CreateAssassinRequestValidator _validator;
        readonly AssassinRepository _assassinRepository;

        public AssassinController()
        {
            _validator = new CreateAssassinRequestValidator();
            _assassinRepository = new AssassinRepository();
        }

        [HttpPost("register")]
        public ActionResult AddAssassin(CreateAssassinRequest assassin)
        {
            if (!_validator.Validate(assassin))
            {
                BadRequest(error: "Assassin needs a catch phrase, code name, and preferred weapon");
            }

            var newAssassin = new Assassin(assassin.CodeName, assassin.CatchPhrase, assassin.PreferredWeapon);
            _assassinRepository.AddAssassin(newAssassin);

            return Created($"api/assassin/register/{newAssassin.Id}", newAssassin);
        }
    }
}