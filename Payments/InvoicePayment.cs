class InvoicePayment 
{
    public static void printInvoice(string paymentMethod, double Amount,bool checkSuccessOperation, double remainning) 
    {
        if (checkSuccessOperation == true)
        {
            Console.WriteLine ($"payed {Amount} succesfully using {paymentMethod} the remainning money is {remainning}");
        }
        else
        {
            Console.WriteLine($"Your balance is not enough to pay {Amount}");
        }
    }
}