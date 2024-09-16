using Application.Features.Brands.Queries.GetList;
using Application.Features.Models.Queries.GetList;
using Application.Features.Models.Queries.GetListByDynamic;
using Core.Application.Requests;
using Core.Application.Responses;
using Core.Persistance.Dynamic;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ModelsController : BaseController
{
    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListModelQuery query = new() { PageRequest = pageRequest };
        GetListResponse<GetListModelListItemDto> response = await Mediator.Send(query);

        return Ok(response);
    }

    [HttpPost("getListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] DynamicQuery? dynamicQuery = null)
    {
        GetListByDynamicModelQuery query = new() { PageRequest = pageRequest , DynamicQuery = dynamicQuery };
        GetListResponse<GetListByDynamicModelListItemDto> response = await Mediator.Send(query);

        return Ok(response);
    }
}
