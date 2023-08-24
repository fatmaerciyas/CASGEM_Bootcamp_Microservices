using AutoMapper;
using CasgemMicroservices.Services.Order.Core.Application.Dtos.OrderDetailsDtos;
using CasgemMicroservices.Services.Order.Core.Application.Dtos.OrderDtos;
using CasgemMicroservices.Services.Order.Core.Application.Features.CQRS.Queries;
using CasgemMicroservices.Services.Order.Core.Application.Interfaceses;
using CasgemMicroservices.Services.Order.Core.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroservices.Services.Order.Core.Application.Features.CQRS.Handlers
{
    public class GetByIdOrderingQueryHandler : IRequestHandler<GetByIdOrderingQueryRequest, ResultOrderingDto>
    {
        private readonly IRepository<Ordering> _repository;
        private readonly IMapper _mapper;

        public GetByIdOrderingQueryHandler(IRepository<Ordering> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }


        public async Task<ResultOrderingDto> Handle(GetByIdOrderingQueryRequest request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);

            return _mapper.Map<ResultOrderingDto>(value);
        }
    }
}
