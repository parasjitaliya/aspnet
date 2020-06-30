using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SPAPI.Models;
using SPAPI.Processor;


namespace SPAPI.Controllers
{
    [ApiController]
    [Route("api/")]
    //[Authorize]
    public class MerchantTransactionController : ControllerBase
    {
        
        private readonly MerchantTransactionProcessor _merchantTransactionProcessor;

        public MerchantTransactionController(MerchantTransactionProcessor merchantTransactionProcessor)
        {
            _merchantTransactionProcessor = merchantTransactionProcessor;
        }


        [HttpPost]
        [Route("Hello")]
        public string Hello(string Text)
        {
            return Text;
        }

       

    }
}
