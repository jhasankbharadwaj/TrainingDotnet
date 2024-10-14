using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using modelBinding.model;

namespace modelBinding.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly List<AccountDetails> _Accounts = new List<AccountDetails>()
        {
            new AccountDetails{AccountNumber=1223,Name="asdfg11",Age=44,City="ht",Region="fasd" },
             new AccountDetails{AccountNumber=3345,Name="asdfg22",Age=43,City="hsj",Region="fad" },
            new AccountDetails{AccountNumber=3455665,Name="asdfg33",Age=33,City="fa",Region="gret" },
            new AccountDetails{AccountNumber=2334,Name="asdfg44",Age=88,City="dafa",Region="qwre" },



        };
        public AccountController() {

        }
        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] string city)
        {

            if (ModelState.IsValid)
            {
                var filterdproducts = _Accounts.Where(p => p.City.StartsWith(city)).ToList();
                if (filterdproducts.Any())
                {
                    return Ok(filterdproducts);
                }

            }
            return NotFound(city);


        }
        [HttpPost]
        public async Task<IActionResult> InsertNewAccount([FromBody] AccountDetails account)
        {
            var exist = _Accounts.Select(i => i.AccountNumber == account.AccountNumber).ToList();
            if(exist.Count()==0)
            {
                if (ModelState.IsValid)
                {
                    if (account != null)
                    {
                        _Accounts.Add(account);
                        return Ok();
                    }

                }
            }
            
            return BadRequest(account);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateAccountDetails([FromRoute]int Id, [FromBody] AccountDetails account)
        {
           var  ac=_Accounts.FirstOrDefault(i=>i.Equals(Id));
            if (ac != null)
            {
                ac = account;
                return Ok(ac);
            }

            return NotFound(new { Message = "id notfound." });
        }
        [HttpDelete("{id:int}")]
        public IActionResult DeleteProduct([FromRoute] int Acc)
        {
            var product = _Accounts.FirstOrDefault(p => p.AccountNumber == Acc);
            if (product == null)
            {
                return NotFound(new { Message = " Account not  found." });
            }
            _Accounts.Remove(product);
            return NoContent();
        }

    }
}
