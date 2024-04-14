using Cliente.Domain.DTOs;
using MediatR;

namespace Cliente.CrossCutting.Commands
{
    public class DeleteClienteCommand : IRequest<bool>
    {
        public Guid Id { get; set; }
    }
}
