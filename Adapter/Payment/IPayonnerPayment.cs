namespace Adapter.Payment;

interface IPayonnerPayment
{
    Token AuthToken();

    void SendPayment();

    void ReceivePayment();
}
