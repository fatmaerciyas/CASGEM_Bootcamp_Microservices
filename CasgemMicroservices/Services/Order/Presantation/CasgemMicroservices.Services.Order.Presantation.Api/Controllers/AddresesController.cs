using CasgemMicroservices.Services.Order.Core.Application.Features.CQRS.Commands;
using CasgemMicroservices.Services.Order.Core.Application.Features.CQRS.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CreateAddressCommandRequest = CasgemMicroservices.Services.Order.Core.Application.Features.CQRS.Commands.CreateAddressCommandRequest;

namespace CasgemMicroservices.Services.Order.Presantation.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddresesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AddresesController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> AddressList()
        {
            var values = await _mediator.Send(new GetAllAddressQueryRequest());
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> AddressGetById(int id)
        {
            var value = await _mediator.Send(new GetByIdAddressQueryRequest(id) );
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> AddressCreate(CreateAddressCommandRequest createAddressCommandRequest)
        {
            await _mediator.Send(createAddressCommandRequest);
            return Ok("Adres Eklendi");
        }

        [HttpPut]
        public async Task<IActionResult> AddressUpdate(UpdateAddressCommandRequest updateAddressCommandRequest)
        {
            await _mediator.Send(updateAddressCommandRequest);
            return Ok("Adres Güncellendi");
        }
        [HttpDelete]
        public async Task<IActionResult> AddressDelete(int id)
        {
            await _mediator.Send(new RemoveAddressCommandRequest(id));
            return Ok("Adres Silindi");
        }
    }
}
