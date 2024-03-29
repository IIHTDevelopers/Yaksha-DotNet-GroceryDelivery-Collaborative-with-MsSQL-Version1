﻿using AutoMapper;
using GroceryDelivery.BusinessLayer.Persistence;
using GroceryDelivery.BusinessLayer.Persistence.Services;
using GroceryDelivery.Entites;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GroceryDelivery.BusinessLayer.Features.Order.Commands.Create
{
    public class CreateOrderCommandHandler :IRequestHandler<CreateOrderCommand, ApplicationUser>
    {
        private readonly IGroceryServices _groceryServices;
        private readonly IMapper _mapper;
        public CreateOrderCommandHandler(IGroceryServices groceryServices, IMapper mapper)
        {
            _groceryServices = groceryServices;
            _mapper = mapper;
        }

        public async Task<ApplicationUser> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }        
    }
}