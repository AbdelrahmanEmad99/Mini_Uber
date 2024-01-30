using Mini_Uber.Connections;
using Mini_Uber.Users;

class CreditCardPay : Ipay
{
    private double _amount { get; set; }
    private User coustumer;
    public void paymentData(User _coustumer)
    {
        this.coustumer = _coustumer;
    }
    public bool pay(double Amount)
    {
        this._amount = Amount;

        bool checkSuccessOperation = PayChecing.PayAmount(coustumer.MoneyInCreditCard, this._amount);

        if (checkSuccessOperation)
        {
            this.coustumer.MoneyInCreditCard -= this._amount;
            DataBaseConnection.GetContext().Users.Update(this.coustumer);
            DataBaseConnection.GetContext().SaveChanges();
        }

        InvoicePayment.printInvoice(this.ToString(), this._amount, checkSuccessOperation, this.coustumer.MoneyInCreditCard);
        return checkSuccessOperation;
    }
}
