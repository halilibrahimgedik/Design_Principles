using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Loose_Coupling_Dependency;

class MailSender
{
    public void Send()
    {
        // !Gmailde bir değişiklik olursa kodumuz patlıyor, parametre alan constructor eklememiz gibi
        Gmail gmail = new();
        gmail.Send("asdw@gmail.com");
        // !ben gmail değilde hotmail kullanmak istersem yukarıdaki kodları silip hotmail nesnesi ile tekrar işlemlerimi yapmalıyım
        //Hotmail hotmail = new Hotmail(); 
        //hotmail.Send(); 
    }
}

class Gmail
{
    //public Gmail(int number)
    //{
    //    // !eğer bir parametre alan ctor eklersek kod MailSender sınıfında patlıyor, yani bizim oraya müdahale etmemizi gerektiriyor. Maliyetli ve Sıkı Bağımlı bir kod
    //}
    public void Send(string to)
    {
        //...
    }
}

class Hotmail
{
    public void Send(string to)
    {
        //...
    }
}



