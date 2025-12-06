namespace Software.Design.Patterns.Proxy;

public abstract class SMSService
{
    public abstract string SendSMS(string customerId,
        string mobile,
        string sms
    );
}