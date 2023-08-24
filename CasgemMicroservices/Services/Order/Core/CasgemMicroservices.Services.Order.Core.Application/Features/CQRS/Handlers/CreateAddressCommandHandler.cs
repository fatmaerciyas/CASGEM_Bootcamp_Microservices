using AutoMapper;
using CasgemMicroservices.Services.Order.Core.Application.Dtos.AdsressDtos;
using CasgemMicroservices.Services.Order.Core.Application.Features.CQRS.Commands;
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
    public class CreateAddressCommandHandler : IRequestHandler<CreateAddressCommandRequest>
    {
        private readonly IRepository<Addresss> _repository;
        

        public CreateAddressCommandHandler(IRepository<Addresss> repository)
        {
            _repository = repository;
           
        }

        Task IRequestHandler<CreateAddressCommandRequest>.Handle(CreateAddressCommandRequest request, CancellationToken cancellationToken)
        {
            var values = new Addresss
            {
                City = request.City,
                Detail = request.Detail,
                District = request.District,
                UserID = request.UserID,
            };
            return _repository.CreateAsync(values);
        }
    }
}
