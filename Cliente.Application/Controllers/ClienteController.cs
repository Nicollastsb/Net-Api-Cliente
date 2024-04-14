using Cliente.CrossCutting.Commands;
using Cliente.CrossCutting.Handlers;
using Cliente.CrossCutting.Queries;
using Cliente.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Cliente.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ClienteController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateClienteCommand cliente)
        {
            if (cliente == null)
                return NotFound();

            return await Execute(async () => await _mediator.Send(cliente));
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateClienteCommand cliente)
        {
            if (cliente == null)
                return NotFound();
        
            return await Execute(async () => await _mediator.Send(cliente));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            if (id == Guid.Empty)
                return NotFound();

            return await Execute(async () => await _mediator.Send(new DeleteClienteCommand
            {
                Id = id
            }));
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return await Execute(async () =>
            {
                return await _mediator.Send(new GetAllClienteQuery());
            });
        }
        

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            if (id == Guid.Empty)
                return NotFound();

            return await Execute(async () => {
                var result = await _mediator.Send(new GetClienteByIdQuery
                {
                    Id = id
                });

                if (result == null)
                    return NotFound();

                return result;
            });
        }

        private async Task<IActionResult> Execute(Func<Task<object>> func)
        {
            try
            {
                var result = await func();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
