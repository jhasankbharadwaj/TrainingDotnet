using Mango.Services.CouponAPI.Data;
using Mango.Services.CouponAPI.Models;
using System.Collections;
using Microsoft.AspNetCore.Mvc;
using Mango.Services.CouponAPI.Models.Dto;
using AutoMapper;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Mango.Services.CouponAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CouponAPIController : ControllerBase
    {
        private  readonly AppDbContext _appDbContext;
        private readonly ResponseDto _response;
        private IMapper _mapper;
                
        public CouponAPIController(AppDbContext appDbContext,IMapper mapper) {
            _appDbContext = appDbContext;
            _mapper = mapper;
            _response= new ResponseDto();
            

        }
        // GET: api/<CouponAPIController>
        [HttpGet]
        public ResponseDto Get()
        {
            try
            {
                IEnumerable<Coupon> objList = _appDbContext.Coupons.ToList();
                _response.Result = _mapper.Map<IEnumerable<CouponDto>>(objList);
               
            }
            catch (Exception ex) {
                _response.IsSuccess = false;
                _response.Messege = ex.Message;
            }
            return _response;
        }

   
       // public ResponseDto Get()

        // GET api/<CouponAPIController>/5
        [HttpGet]
        [Route("GEtByCode/{code}")]
        public ResponseDto GetByCode(string code)
        {
            try
            {
                
                    Coupon objlist = _appDbContext.Coupons.FirstOrDefault(u => u.CouponCode.ToLower().Equals(code.ToLower()));
                    _response.Result = _mapper.Map<CouponDto>(objlist);
                
               
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Messege = ex.Message;
            }   
            return _response;
        }

        // POST api/<CouponAPIController>
       
    }
}
