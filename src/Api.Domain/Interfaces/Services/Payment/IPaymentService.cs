using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces.Services.Payment
{
    public interface IPaymentService
    {
        Task<bool> Payment(object item);
    }
}
