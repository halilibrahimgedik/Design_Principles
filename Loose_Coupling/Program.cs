
// sıkı bağımlılık
// burada mailsender içindeki Send() metodu hangi MailServer'ı kullanıyorsa ona bağımlıyız. Değiştirmek için kaaynak koda gidip düzenlemeliyiz.
Loose_Coupling_Dependency.MailSender mailSender = new();
mailSender.Send();

// gevşek bağımlılık
Loose_Coupling_Independency.MailSender mailSender2 = new();
mailSender2.Send(new Loose_Coupling_Independency.Gmail());
// fikrim değişti biz artık hotmail kullanıyoruz
mailSender2.Send(new Loose_Coupling_Independency.Hotmail());

