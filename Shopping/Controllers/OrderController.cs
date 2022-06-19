using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Shopping.Data.Models;
using Shopping.Data.Repositories.UnitOfWork;
using Shopping.Dtos.OrderDTOs;
using System.Security.Claims;
using System.Security.Principal;

namespace Shopping.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly UserManager<User> userManager;

        IUnitOfWork UnitOfWork { get; set; }
        public OrderController(IUnitOfWork unitOfWork, IMapper mapper, UserManager<User> userManager)
        {
            UnitOfWork = unitOfWork;
            this.mapper = mapper;
            this.userManager = userManager;
        }

        //GetAll OrdersRequest (Lazy Loading)
        [HttpGet]
        public ActionResult<List<Order>> GetAll()
        {
            return UnitOfWork.OrderRepo.GetAll();
        }

        //GetAll OrdersRequest for approval (Eager Loading)
        [HttpGet]
        [Route("IncludingItems")]
        public ActionResult<List<OrderReadDTO>> GetAllIncludingItems()
        {
            var orders = UnitOfWork.OrderRepo.GetAllIncludingItems();
            var ordersRead = mapper.Map<List<OrderReadDTO>>(orders);
            return ordersRead;
        }


        [HttpGet("{orderId:Guid}")]
        public ActionResult<OrderReadDTO> GetById(Guid orderId)
        {

            Order order = UnitOfWork.OrderRepo.GetByIdIncludingChilds(orderId);
            if (order == null) { NotFound("order Not Found"); }
            var orderRead = mapper.Map<OrderReadDTO>(order);
            return orderRead;
        }

        //Approve Order
        [HttpPost]
        [Route("Approve/{orderId:Guid}")]
        public ActionResult Approve(Guid orderId)
        {

            Order order = UnitOfWork.OrderRepo.GetById(orderId);
            if (order == null)
            {
                return BadRequest("Order Is not Found");
            }

            if (order.Approval)
            {
                return Ok("Order is Already Approved");
            }
            order.Approval = true;
            UnitOfWork.OrderRepo.SaveChanges();
            return Ok("Order Approved");
        }
        [HttpPost]
        [Route("Reject/{orderId:Guid}")]
        public ActionResult Reject(Guid orderId)
        {

            Order order = UnitOfWork.OrderRepo.GetById(orderId);
            if (order == null)
            {
                return BadRequest("Order Is not Found");
            }

            if (!order.Approval)
            {
                return Ok("Order is Already Rejected");
            }
            order.Approval = false;
            UnitOfWork.OrderRepo.SaveChanges();
            return Ok("Order Rejected");
        }
        //Submit Order
        [HttpPost]
        public async Task<ActionResult> Submit(OrderWriteDTO orderWriteDTO)
        {
            //if (!User.Identity.IsAuthenticated)
            //{
            //    return Unauthorized();
            //}
            //getting User
            ClaimsPrincipal currentUser = this.User;
            var currentUserName = currentUser.FindFirst(ClaimTypes.NameIdentifier).Value;
            User user = await userManager.FindByNameAsync(currentUserName);

            var order = mapper.Map<Order>(orderWriteDTO);
            order.Id = Guid.NewGuid();
            order.User = user;


            UnitOfWork.OrderRepo.Add(order);
            UnitOfWork.OrderRepo.SaveChanges();


            var orderRead = mapper.Map<OrderReadDTO>(order);
            return Ok();
            //return CreatedAtAction("GetById", new { orderId = order.Id }, orderRead);

        }

        

    }
}
