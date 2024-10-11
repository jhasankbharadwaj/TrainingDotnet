using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private static List<People> _PeopleData = new List<People>()
            {
                    new People{Name="jb",Age=20,Place="hyd",job="dev"},
                    new People{Name="jb1",Age=21,Place="hyd",job="un"},
                    new People { Name = "jb13", Age = 21, Place = "dehradoon", job = "in" },
                    new People { Name = "jb11", Age = 291, Place = "dehradoon", job = "iin" },

        };

        [HttpGet]
        public ActionResult<IEnumerable<People>> GetAll()
        {
            return _PeopleData;
        }

        [HttpGet("{Name}")]
        public ActionResult<People> GetAge(int Name)
        {
            var getperson = _PeopleData.FirstOrDefault(P => P.Name.Equals(Name));
            if (getperson == null)
            {
                return NotFound();

            }
            return getperson;

        }

        [HttpPost]
        public IActionResult PostPeople(int Name, People person)
        {

            _PeopleData.Add(person);
            return CreatedAtAction(nameof(PostPeople), new { name = person.Name }, person);

        }


        [HttpPut("{Name}")]

        public IActionResult  Putperson(string Name ,People obj){
            if (string.IsNullOrEmpty(Name)|| Name != obj.Name) 
            {
                return BadRequest();
            }
            foreach (var person in _PeopleData)
            {
                if (person.Name.Equals(Name))
                {
                    person.Age = obj.Age;   
                    person.Name = Name;
                    person.job = obj.job;
                    person.Place= obj.Place;
                    return NoContent();
                }
            }
            return NotFound();
        }

        [HttpDelete("{id}")]
        public ActionResult DeletePeople( string  Name)
        {
            var deleteperson = _PeopleData.FirstOrDefault(p => p.Name.Equals(Name));
            if(deleteperson == null)
            {
                return NotFound();

            }
            _PeopleData.Remove(deleteperson);
            return NoContent();
        }

    }
}
