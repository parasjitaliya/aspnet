using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SPAPI.Models
{

    public class GetBearerActionTokenRequest
    {
        //[Required(ErrorMessage = "Bearer Token Required.")]
        //[JsonProperty(PropertyName = "bearerToken")]
        //public Guid BearerToken { get; set; }
    }

    public class GetBearerActionTokenResponse
    {
        [JsonProperty(PropertyName = "bearerToken")]
        public Guid BearerToken { get; set; }
    }

    

    public class GeneratePaymentLinkRequest 
    {
        //[Required(ErrorMessage = "Program Code Required.")]
        [JsonProperty(PropertyName = "programCode")]
        public string ProgramCode { get; set; }

        [JsonProperty(PropertyName = "storeCode")]
        public string StoreCode { get; set; }

        [JsonProperty(PropertyName = "billDateTime")]
        public DateTime BillDateTime { get; set; }

        [JsonProperty(PropertyName = "terminalId")]
        public string TerminalId { get; set; }


        [JsonProperty(PropertyName = "merchantTxnID")]
        public string MerchantTxnID { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }


        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        [JsonProperty(PropertyName = "mobile")]
        public string Mobile { get; set; }

        [JsonProperty(PropertyName = "amount")]
        public decimal Amount { get; set; }
    }

    public class AuthenticateTokenRequest 
    {
        [JsonProperty(PropertyName = "urlToken")]
        public string URLToken { get; set; }
    }

    public class CommonRequest 
    {
        [JsonProperty(PropertyName = "tokenId")]
        public string TokenId { get; set; }

        //[Required(ErrorMessage = "Program Code Required.")]
        [JsonProperty(PropertyName = "programCode")]
        public string ProgramCode { get; set; }

        [JsonProperty(PropertyName = "storeCode")]
        public string StoreCode { get; set; }

        [JsonProperty(PropertyName = "billDateTime")]
        public DateTime BillDateTime { get; set; }

        [JsonProperty(PropertyName = "terminalId")]
        public string TerminalId { get; set; }


        [JsonProperty(PropertyName = "merchantTxnID")]
        public string MerchantTxnID { get; set; }


        [JsonProperty(PropertyName = "mobile")]
        public string Mobile { get; set; }
    }


    

    public class CommonResponse
    {
        [JsonProperty(PropertyName = "returnCode")]
        public string ReturnCode { get; set; }

        [JsonProperty(PropertyName = "returnMessage")]
        public string ReturnMessage { get; set; }

        [JsonProperty(PropertyName = "tokenId")]
        public string TokenId { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }
    }

    public class AuthenticateTokenResponse 
    {
        [JsonProperty(PropertyName = "returnCode")]
        public string ReturnCode { get; set; }

        [JsonProperty(PropertyName = "returnMessage")]
        public string ReturnMessage { get; set; }

        [JsonProperty(PropertyName = "programCode")]
        public string ProgramCode { get; set; }

        [JsonProperty(PropertyName = "tokenId")]
        public string TokenId { get; set; }
    }

    public class PaymentStatusResponse 
    {
        [JsonProperty(PropertyName = "returnCode")]
        public string ReturnCode { get; set; }

        [JsonProperty(PropertyName = "returnMessage")]
        public string ReturnMessage { get; set; }

        [JsonProperty(PropertyName = "tokenId")]
        public string TokenId { get; set; }

        [JsonProperty(PropertyName = "shortURL")]
        public string ShortURL { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

      

    }

   


}





 


