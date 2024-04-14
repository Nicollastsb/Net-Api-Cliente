using AutoMapper;
using Cliente.CrossCutting.Commands;
using Cliente.Domain.DTOs;
using Cliente.Domain.Entities;
using Cliente.Domain.Interfaces;
using Cliente.Service.Validators;
using MediatR;

namespace Cliente.CrossCutting.Handlers
{
    public class UpdateClienteCommandHandler : IRequestHandler<UpdateClienteCommand, ClienteDTO>
    {

        private IBaseService<Client> _baseClienteService;
        private readonly IMapper _mapper;

        public UpdateClienteCommandHandler(IBaseService<Client> baseClienteService, IMapper mapper)
        {
            _baseClienteService = baseClienteService;
            _mapper = mapper;
        }

        public async Task<ClienteDTO> Handle(UpdateClienteCommand request, CancellationToken cancellationToken)
        {
            var novoCliente = _baseClienteService.Update<ClienteValidator>(_mapper.Map<Client>(request));
            return _mapper.Map<ClienteDTO>(novoCliente);
        }
    }
}
