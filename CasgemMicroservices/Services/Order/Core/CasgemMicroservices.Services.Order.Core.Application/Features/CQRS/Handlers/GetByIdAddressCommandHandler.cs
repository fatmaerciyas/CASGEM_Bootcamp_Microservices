using AutoMapper;
using CasgemMicroservices.Services.Order.Core.Application.Dtos.AdsressDtos;
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
    public class GetByIdAddressCommandHandler : IRequestHandler<GetByIdAddressQueryRequest, ResultAddressDto>
    {
        private readonly IRepository<Addresss> _repository;
        private readonly IMapper _mapper;

        public GetByIdAddressCommandHandler(IRepository<Addresss> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ResultAddressDto> Handle(GetByIdAddressQueryRequest request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return _mapper.Map<ResultAddressDto>(value);
        }
    }
}
