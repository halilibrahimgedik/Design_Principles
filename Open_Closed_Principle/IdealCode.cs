namespace OCP_IdealCode;

class MoneySender
{
    public void Send(IBank bank, int amount, string accountNo)
    {
       bank.MoneyTransfer(amount, accountNo);
    }
}

interface IBank
{
    public bool MoneyTransfer(int amount, string accountNo);
}


class Garanti : IBank
{
    public string AccountNo { get; set; }
    public void SendMoney(int amount)
    {
        //...
    }

    public bool MoneyTransfer(int amount, string accountNo)
    {
        try
        {
            AccountNo = accountNo;
            SendMoney(amount);
            return true;
        }
        catch
        {
            return false;
        }
    }
}


class Halkbank : IBank
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

    public bool MoneyTransfer(int amount, string accountNo)
    {
        try
        {
            _accountNo = accountNo;
            AccountNoToBeSend(_accountNo);
            Send(amount);
            return true;
        }
        catch
        {
            return false;
        }
    }
}

// başka bir banka ekleyip onu kullanabiliriz 
class HalilBank : IBank
{
    //...
    //...
    public bool MoneyTransfer(int amount, string accountNo)
    {
        //........
        throw new NotImplementedException();
    }
}
