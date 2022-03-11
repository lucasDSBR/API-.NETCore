using System.Runtime.InteropServices;
using System;
using System.Net;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Services.Payment;
using Microsoft.AspNetCore.Mvc;
using Api.Domain.Dtos;
using Microsoft.AspNetCore.Authorization;

namespace Api.Application.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class PaymentController
    {
        private IPaymentService _paymentService;
        public PaymentController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }
        [AllowAnonymous]
        [HttpPost]
        public async Task<object> Payment([FromBody] object item)
        {

            return null;
        }
    }
}
