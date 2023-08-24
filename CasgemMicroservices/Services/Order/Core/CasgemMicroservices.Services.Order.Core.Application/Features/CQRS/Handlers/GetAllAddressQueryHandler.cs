using AutoMapper;
using CasgemMicroservices.Services.Order.Core.Application.Dtos.AdsressDtos;
using CasgemMicroservices.Services.Order.Core.Application.Dtos.OrderDetailsDtos;
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
    public class GetAllAddressQueryHandler : IRequestHandler<GetAllAddressQueryRequest, List<ResultAddressDto>>
    {

        private readonly IRepository<Addresss> _repository;
        private readonly IMapper _mapper;

        public GetAllAddressQueryHandler(IRepository<Addresss> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<ResultAddressDto>> Handle(GetAllAddressQueryRequest request, CancellationToken cancellationToken)
        {

            var values = await _repository.GetAllAsync();

            return _mapper.Map<List<ResultAddressDto>>(values);
        }
    }
}
