using System;
using System.Windows.Forms;

namespace DemoWcfFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetMessage_Click(object sender, EventArgs e)
        {
            GetMessageWebService.MessageServiceClient client = new GetMessageWebService.MessageServiceClient("NetTcpBinding_IMessageService");

            lblGetMessage.Text = client.GetMessage(txtGetMessage.Text);
        }
    }
}
