using Cart_Service.Services;
using Microsoft.AspNetCore.Mvc;
using Users_Service;

namespace Cart_Service.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CartController : ControllerBase
    {

        // GET api/<CartController>/5
        [HttpGet("{id}")]
        public UserResponse GetUserById(int id)
        {
            var cartService = new CartService();
            var user = cartService.GetUserById(id);
            return user;
        }
    }
}
