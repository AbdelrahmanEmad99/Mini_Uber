class PayChecing
{
    public static bool PayAmount(double Balance, double Amount)
    {
        if (Amount <= Balance)
        {
            Balance -= Amount;
            return true;
        }
        else
        {
            return false;
        }
    }
}
