
using Software.Design.Patterns.Proxy;

SMSServiceProxy proxy = new SMSServiceProxy();
// Will be sent
Console.WriteLine(
    proxy.SendSMS("1", "01003912122", "Hello"));
// Will be sent
Console.WriteLine(
    proxy.SendSMS("1", "01003912122", "Hello"));
// Will NOT be sent
Console.WriteLine(
    proxy.SendSMS("1", "01003912122", "Hello"));
