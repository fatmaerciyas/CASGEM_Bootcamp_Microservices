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
    public class GetAllOrderDetailQueryHandler : IRequestHandler<GetAllOrderDetailQueryRequest, List<ResultOrderDetailDto>>
    {
        private readonly IRepository<OrderDetail> _repository;
        private readonly IMapper _mapper;

        public GetAllOrderDetailQueryHandler(IRepository<OrderDetail> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

   

        public async Task<List<ResultOrderDetailDto>> Handle(GetAllOrderDetailQueryRequest request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();

            return _mapper.Map<List<ResultOrderDetailDto>>(values);
        }
    }
}
