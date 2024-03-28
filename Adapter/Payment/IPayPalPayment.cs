namespace Adapter.Payment;

interface IPayPalPayment
{
    Token AuthToken();

    void PayPalPayment();

    void PayPalReceive();
}
