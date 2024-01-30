using Mini_Uber.Users;

class PayStrategy
{
    private Ipay PayMethod;
    private User _coustumer;
    public PayStrategy(User coustumer)
    {
        this._coustumer = coustumer;
    }
    public void Payby(Ipay _payMethod) 
    {
        this.PayMethod = _payMethod;
    }
    public void setPaying(double Amount) 
    {
        this.PayMethod.paymentData(this._coustumer);
        this.PayMethod.pay(Amount);
    }
}