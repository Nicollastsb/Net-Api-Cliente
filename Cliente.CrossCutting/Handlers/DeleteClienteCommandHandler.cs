using AutoMapper;
using Cliente.CrossCutting.Commands;
using Cliente.Domain.Entities;
using Cliente.Domain.Interfaces;
using MediatR;

namespace Cliente.CrossCutting.Handlers
{
    public class DeleteClienteCommandHandler : IRequestHandler<DeleteClienteCommand, bool>
    {

        private IBaseService<Client> _baseClienteService;
        private readonly IMapper _mapper;

        public DeleteClienteCommandHandler(IBaseService<Client> baseClienteService, IMapper mapper)
        {
            _baseClienteService = baseClienteService;
            _mapper = mapper;
        }

        public async Task<bool> Handle(DeleteClienteCommand request, CancellationToken cancellationToken)
        {
            _baseClienteService.Delete(request.Id);
            return true;
        }
    }
}
