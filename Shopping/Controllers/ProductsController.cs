using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shopping.Data.Models;
using Shopping.Data.Repositories.UnitOfWork;
using Shopping.Dtos.ProductDTOs;

namespace Shopping.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMapper mapper;

        IUnitOfWork UnitOfWork { get; set; }
        public ProductsController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            UnitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        //GetAll Products to choose from 
        [HttpGet]
        public ActionResult<List<Product>> GetAll()
        {
            return UnitOfWork.ProductRepo.GetAll();
        }
        [HttpPost]
        public ActionResult Add(ProductChildWriteDTO productDTO)
        {
            var product =mapper.Map<Product>(productDTO);
            product.Id = Guid.NewGuid();

            UnitOfWork.ProductRepo.Add(product);
            UnitOfWork.ProductRepo.SaveChanges();
            var retproductDTO = mapper.Map<ProductChildReadDTO>(product);

            return CreatedAtAction("GetById",new { productId = product.Id },retproductDTO);
        }
        [HttpDelete("{productId:Guid}")]
        public ActionResult Delete(Guid productId)
        {
            var order = UnitOfWork.ProductRepo.GetById(productId);
            if (order == null)
            {
                NotFound();
            }
            UnitOfWork.ProductRepo.Delete(productId);
            UnitOfWork.ProductRepo.SaveChanges();
            return Ok();
        }
        [HttpGet("{productId:Guid}")]
        public ActionResult<ProductChildReadDTO> GetById(Guid productId)
        {
            var product = UnitOfWork.ProductRepo.GetById(productId);
            if(product == null)
            {
                NotFound("not found");
            }
            var productDTO=mapper.Map<ProductChildReadDTO>(product);
            return productDTO;
        }
        [HttpPut("{productId:Guid}")]
        public ActionResult<ProductChildReadDTO> Edit(Guid productId,ProductChildWriteDTO productToEdit)
        {
            if (productId != productToEdit.Id)
            {
                return BadRequest();
            }
            var productFromDB = UnitOfWork.ProductRepo.GetById(productId);
            if (productFromDB == null)
            {
                NotFound("not found");
            }
            var productDTO = mapper.Map(productToEdit, productFromDB);
            UnitOfWork.ProductRepo.SaveChanges();

            return Ok();
        }
    }
}
