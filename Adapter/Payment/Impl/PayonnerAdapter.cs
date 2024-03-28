namespace Adapter.Payment.Impl;

class PayonnerAdapter : IPayPalPayment
{
    private Payonner payonner;

    public PayonnerAdapter(Payonner payonner)
    {
        this.payonner = payonner;
        Console.WriteLine("Realizando Adaptação de Payoneer para os métodos do PayPal");
    }

    public Token AuthToken()
    {
        return payonner.AuthToken();
    }

    public void PayPalPayment()
    {
        payonner.SendPayment();
    }

    public void PayPalReceive()
    {
        payonner.ReceivePayment();
    }
}
