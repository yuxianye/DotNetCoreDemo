using System;
using System.Net;
using System.Net.Mail;
namespace MailDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            sendingMail();
            Console.ReadLine();
        }
        public static string sendingMail()
        {
            string smtpService = "smtp.qq.com";
            string sendEmail = "2301394562@qq.com";
            string sendpwd = "";//授权码


            //确定smtp服务器地址 实例化一个Smtp客户端
            SmtpClient smtpclient = new SmtpClient();
            smtpclient.Host = smtpService;
            smtpclient.Port = 465;//qq邮箱可以不用端口 "465");//587

            //确定发件地址与收件地址
            MailAddress sendAddress = new MailAddress(sendEmail);
            MailAddress receiveAddress = new MailAddress("147622013@qq.com");

            //构造一个Email的Message对象 内容信息
            MailMessage mailMessage = new MailMessage(sendAddress, receiveAddress);
            mailMessage.Subject = "测试邮件" + DateTime.Now;
            mailMessage.SubjectEncoding = System.Text.Encoding.UTF8;
            mailMessage.Body = "测试邮件发送成功！！！";
            mailMessage.BodyEncoding = System.Text.Encoding.UTF8;

            //邮件发送方式  通过网络发送到smtp服务器
            smtpclient.DeliveryMethod = SmtpDeliveryMethod.Network;

            //如果服务器支持安全连接，则将安全连接设为true
            smtpclient.EnableSsl = true;
            try
            {
                //是否使用默认凭据，若为false，则使用自定义的证书，就是下面的networkCredential实例对象
                smtpclient.UseDefaultCredentials = false;

                //指定邮箱账号和密码,需要注意的是，这个密码是你在QQ邮箱设置里开启服务的时候给你的那个授权码
                NetworkCredential networkCredential = new NetworkCredential(sendEmail, sendpwd);
                smtpclient.Credentials = networkCredential;

                //发送邮件
                smtpclient.Send(mailMessage);
                Console.WriteLine("发送邮件成功");

            }
            catch (System.Net.Mail.SmtpException ex) { Console.WriteLine(ex.Message, "发送邮件出错"); }
            return "DLL调用成功!";
        }
    }
}
