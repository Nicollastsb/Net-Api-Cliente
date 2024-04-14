using Cliente.Domain.DTOs;
using MediatR;

namespace Cliente.CrossCutting.Queries
{
    public record GetAllClienteQuery() : IRequest<List<ClienteDTO>>;
}
