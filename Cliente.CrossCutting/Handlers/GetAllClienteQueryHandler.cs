using AutoMapper;
using Cliente.CrossCutting.Queries;
using Cliente.Domain.DTOs;
using Cliente.Domain.Entities;
using Cliente.Domain.Interfaces;
using MediatR;

namespace Cliente.CrossCutting.Handlers
{
    public class GetAllClienteQueryHandler : IRequestHandler<GetAllClienteQuery, List<ClienteDTO>>
    {

        private IBaseService<Client> _baseClienteService;
        private readonly IMapper _mapper;

        public GetAllClienteQueryHandler(IBaseService<Client> baseClienteService, IMapper mapper)
        {
            _baseClienteService = baseClienteService;
            _mapper = mapper;
        }

        public async Task<List<ClienteDTO>> Handle(GetAllClienteQuery request, CancellationToken cancellationToken)
        {
            var result = _baseClienteService.GetAll();
            return _mapper.Map<List<ClienteDTO>>(result);
        }
    }
}
