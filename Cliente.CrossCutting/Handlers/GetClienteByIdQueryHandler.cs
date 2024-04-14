using AutoMapper;
using Cliente.CrossCutting.Queries;
using Cliente.Domain.DTOs;
using Cliente.Domain.Entities;
using Cliente.Domain.Interfaces;
using MediatR;

namespace Cliente.CrossCutting.Handlers
{
    public class GetClienteByIdQueryHandler : IRequestHandler<GetClienteByIdQuery, ClienteDTO>
    {

        private IBaseService<Client> _baseClienteService;
        private readonly IMapper _mapper;

        public GetClienteByIdQueryHandler(IBaseService<Client> baseClienteService, IMapper mapper)
        {
            _baseClienteService = baseClienteService;
            _mapper = mapper;
        }

        public async Task<ClienteDTO> Handle(GetClienteByIdQuery request, CancellationToken cancellationToken)
        {
            var cliente = _baseClienteService.GetById(request.Id);
            return _mapper.Map<ClienteDTO>(cliente);
        }
    }
}
