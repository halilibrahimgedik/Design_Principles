namespace OCP_NotIdealCode;

class MoneySender
{
    public void Send(int amount)
    {
        //Garanti garanti = new();
        //garanti.AccountNo = "...";
        //garanti.SendMoney(amount);
        Halkbank halkbank = new();
        halkbank.AccountNoToBeSend("123");
        halkbank.Send(amount);
    }
}

class Garanti
{
    public string AccountNo { get; set; }
    public void SendMoney(int amount)
    {
        //...
    }
}
class Halkbank
{
    string _accountNo;
    public void AccountNoToBeSend(string accountNo)
    {
        //...
    }
    public void Send(int amount)
    {
        //...
    }
}