﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroservices.Services.Order.Core.Application.Features.CQRS.Commands
{
    public class RemoveOrderDetailCommandRequest:IRequest
    {
        public RemoveOrderDetailCommandRequest(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
