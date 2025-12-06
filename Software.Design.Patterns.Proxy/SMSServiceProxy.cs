namespace Software.Design.Patterns.Proxy;

public class SMSServiceProxy : SMSService
{
    // Association (Aggregation) to be able to use the concrete subject 
    private SMSService _smsService;
    // Database alternative for customer messages tracking
    private Dictionary<string, int> sentCount = new Dictionary<string, int>();
    public override string SendSMS(string customerId, string mobile, string sms)
    {
        // Lazy Initialization
        if (_smsService == null)
            _smsService = new ConcreteSMSService();
        // Added logic for SMS service through proxy
        // Logic is limiting number of messages sent to each customer
        // First Call
        if (!sentCount.ContainsKey(customerId))
        {
            sentCount.Add(customerId,1);
            return _smsService.SendSMS(customerId, mobile, sms);
        }
        var customer = sentCount.Where(x => x.Key == customerId).FirstOrDefault();
        if (customer.Value >= 2)
        {
            return "Not Sent";
        }

        sentCount[customerId] = customer.Value +1;
        return _smsService.SendSMS(customerId, mobile, sms);
    }
}