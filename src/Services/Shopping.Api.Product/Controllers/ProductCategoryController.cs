using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shopping.Api.Product.Applications.Queries;
using Shopping.Framework.Domain.Base;

namespace Shopping.Api.Product.Controllers
{
    /// <summary>
    /// 总产品品类
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class ProductCategoryController : ControllerBase
    {
        private ISender _mediator;
        private readonly ILogger<ProductCategoryController> _logger;

        public ProductCategoryController(ILogger<ProductCategoryController> logger, ISender mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }
        [HttpGet("tenant")]
        public async Task<ResponsePageBase<ProductCategoryPageQueryItemResponse>> GetTenant([FromQuery] ProductCategoryPageQuery query)
        {
            return await _mediator.Send(query);
        }
        [HttpGet]
        [AllowAnonymous]
        public async Task<ResponsePageBase<ProductCategoryPageQueryItemResponse>> Get([FromQuery] ProductCategoryPageQuery query)
        {
            return await _mediator.Send(query);
        }
    }
}