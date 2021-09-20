using System;
namespace ATMProject
{
    public class Transactions
    {
        public int transactionId { get; set; }
        public char movementType { get; set; }
        public DateTime transactionDate { get; set; }
        public double amount { get; set; }
        public double oldBalance { get; set; }
        public double newBalance { get; set; }

        public Transactions(int transId, char moveType, DateTime transDate, double amountTrans, double oldBal, double newBal)
        {
            this.transactionId = transId;
            this.movementType = moveType;
            this.transactionDate = transDate;
            this.amount = amountTrans;
            this.oldBalance = oldBal;
            this.newBalance = newBal;
        }
    }
}
