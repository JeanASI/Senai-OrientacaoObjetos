using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacaoPoo.Estrutural.Windows.Funcionalidades
{
    public partial class frmSendMail : Form
    {
        public frmSendMail()
        {
            InitializeComponent();
        }

        private void btnEnviarMensagem_Click(object sender, EventArgs e)
        {
            var mensagem = new MimeMessage();
            mensagem.From.Add(new MailboxAddress(txtNomeCompleto.Text, null));
            mensagem.To.Add(new MailboxAddress("Jeanderson", "jeandersonreggae@gmail.com"));
            mensagem.Subject = "How you doin'?";
            mensagem.Body = new TextPart("plain")
            {
                Text    =   txtMensagem.Text
            };
            using (var client = new SmtpClient())
            {
                client.Connect("smtp.gmail.com", 587, false);

                client.Authenticate("jeandersonreggae@gmail.com", "senha");

                client.Send(mensagem);
                client.Disconnect(true);
            }
        }
    }
}
