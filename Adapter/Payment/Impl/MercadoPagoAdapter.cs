namespace Adapter.Payment.Impl;

class MercadoPagoAdapter : IPayPalPayment
{
    private MercadoPago mercadoPago;

    public MercadoPagoAdapter(MercadoPago mercadoPago)
    {
        this.mercadoPago = mercadoPago;
        Console.WriteLine("Realizando Adaptação de Mercado Pago para os métodos do PayPal");
    }

    public Token AuthToken()
    {
        return mercadoPago.AuthToken();
    }

    public void PayPalPayment()
    {
        mercadoPago.CreatePayment();
    }

    public void PayPalReceive()
    {
        mercadoPago.GetPayment();
    }
}
