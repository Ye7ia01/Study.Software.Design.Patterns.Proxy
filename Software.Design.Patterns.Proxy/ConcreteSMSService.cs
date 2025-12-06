namespace Software.Design.Patterns.Proxy;

public class ConcreteSMSService : SMSService
{
    public override string SendSMS(string customerId, string mobile, string sms)
    {
        return $"Sent message to {customerId} with mobile {mobile}";
    }
}