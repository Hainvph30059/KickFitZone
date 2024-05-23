﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DATA.Entity
{
	public class Bill
	{
		public Guid ID { get; set; }
		public string BillCode { get; set; }
		public DateTime DateCreated { get; set; }
		public DateTime? SuccessDate { get; set; }
		public DateTime? DeliveryDate { get; set; }
		public DateTime? CancelDate { get; set; }
		public decimal TotalPrice { get; set; }
		public decimal ShippingCosts { get; set; }
		public string Note { get; set; }
		public string Status { get; set; }
		public DateTime? ConfirmationDate { get; set; }
		public DateTime? UpdateDate { get; set; }
		public decimal TotalPriceAfterDiscount { get; set; }
		public DateTime? PaymentDay { get; set; }
		public string TransactionType { get; set; }
		public bool IsPaid { get; set; }
		public Guid VoucherID { get; set; }
		public Guid EmployeeID { get; set; }
		public Guid PurchaseMethodID { get; set; }
		public Guid CustomerID { get; set; }	

		public Voucher Voucher { get; set; }
		public Employee Employee { get; set; }
		public PurchaseMethod PurchaseMethod { get; set; }
		public Customer Customer { get; set; }
		public ICollection<BillDetails> BillDetails { get; set; }
		public ICollection<BillStatusHistory> BillStatusHistories { get; set; }
	}
}
