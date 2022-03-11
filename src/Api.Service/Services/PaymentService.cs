using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Services.Payment;

namespace Api.Service.Services
{
    public class PaymentService : IPaymentService
    {
        public async Task<bool> Payment(object item)
        {

            return true;
        }
    }
}
