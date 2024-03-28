namespace Adapter.Payment;

interface IMercadoPagoPayment
{
    Token AuthToken();
    void CreatePayment();
    void GetPayment();
}
