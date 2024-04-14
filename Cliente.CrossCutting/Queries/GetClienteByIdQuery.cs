using Cliente.Domain.DTOs;
using MediatR;

namespace Cliente.CrossCutting.Queries
{
    public class GetClienteByIdQuery : IRequest<ClienteDTO>
    {
        public Guid Id { get; set; }
    }
}
