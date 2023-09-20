using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loose_Coupling_Independency;

class MailSender
{
    public void Send(IMailServer mailServer)
    {
        mailServer.Send("asdw@gmail.com");
    }
}

// tanımladığımız arayüz sayesınde Bağımlılığımızı sıkı bağımlılıktan çıkarıp Esnek bir bağımlılık haline getirdik.
interface IMailServer
{
    public void Send(string to);
}
class Gmail : IMailServer
{
    public void Send(string to)
    {
        //...
    }
}

class Hotmail : IMailServer
{
    public void Send(string to)
    {
        //...
    }
}
