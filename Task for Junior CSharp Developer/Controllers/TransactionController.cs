﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Task_for_Junior_CSharp_Developer.Models;

namespace Task_for_Junior_CSharp_Developer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private List<PurchaseTransaction> purchases = new List<PurchaseTransaction>();
        [HttpGet("Buy")]
        public async Task<ActionResult> Purchase_Transaction
            ([FromBody] PurchaseTransactionDto purchaseTransactionDto)
        {
            PurchaseTransaction purchaseTransaction = new PurchaseTransaction();
            purchaseTransaction.TransactionID = Guid.NewGuid();
            purchaseTransaction.PhoneNumber = purchaseTransactionDto.phoneNumber;
            purchaseTransaction.ProductСategory = purchaseTransactionDto.productСategory;
            purchaseTransaction.ProductCost = purchaseTransactionDto.productCost;
            purchaseTransaction.InstallmentRange = purchaseTransactionDto.installmentRange;
            purchaseTransaction.Handle();
            purchases.Add(purchaseTransaction);
            return Ok("Ok");
        }
    }
}
