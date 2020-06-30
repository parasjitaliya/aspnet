using System;
using Microsoft.AspNetCore.Mvc;
using SPAPI.Models;

namespace SPAPI.Processor
{
    public class MerchantTransactionProcessor
    {
        public MerchantTransactionProcessor()
        {
        }

        public CommonResponse GeneratePaymentLink(GeneratePaymentLinkRequest generatePaymentLinkRequest)
        {

            return new CommonResponse() {
                ReturnCode = "0",
                ReturnMessage="Success",
                TokenId= "37fc3b8-0f06-4263-a6b8-729939bf353a",
                Status="Initiated"
             
            };
        }


        public AuthenticateTokenResponse AuthenticateToken(AuthenticateTokenRequest authenticateTokenRequest)
        {
            return new AuthenticateTokenResponse()
            {
                ReturnCode = "0",
                ReturnMessage = "Success",
                TokenId = "37fc3b8-0f06-4263-a6b8-729939bf353a",
                ProgramCode = "PRO0001"

            };
        }


        public PaymentStatusResponse PaymentStatus(CommonRequest paymentStatusRequest)
        {
            return new PaymentStatusResponse()
            {
                ReturnCode = "0",
                ReturnMessage = "Success",
                TokenId = "37fc3b8-0f06-4263-a6b8-729939bf353a",
                Status = "Initiated",
                ShortURL= "https://storepay.net/dashboard/sfsd4553sfsfss"

            };
        }


        public CommonResponse PaymentCancelation(CommonRequest paymentCancelationRequest)
        {
            return new CommonResponse()
            {
                ReturnCode = "0",
                ReturnMessage = "Success",
                TokenId = "37fc3b8-0f06-4263-a6b8-729939bf353a",
                Status = "Cancelled"

            };
        }


        public CommonResponse ResendPaymentLink(CommonRequest resendPaymentLinkRequest)
        {
            return new CommonResponse()
            {
                ReturnCode = "0",
                ReturnMessage = "Success",
                TokenId = "37fc3b8-0f06-4263-a6b8-729939bf353a",
                Status = "Initiated"

            };
        }



    }
}
