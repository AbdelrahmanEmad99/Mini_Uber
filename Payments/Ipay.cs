using Mini_Uber.Users;

interface Ipay
{
    public void paymentData(User coustumer);
    public bool pay(double Amount);
}