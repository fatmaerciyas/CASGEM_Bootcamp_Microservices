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
    public class UpdateAddressCommandHandler : IRequestHandler<UpdateAddressCommandRequest>
    {
        private readonly IRepository<Addresss> _repository;

        public UpdateAddressCommandHandler(IRepository<Addresss> repository)
        {
            _repository = repository;
        }

        public Task Handle(UpdateAddressCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
