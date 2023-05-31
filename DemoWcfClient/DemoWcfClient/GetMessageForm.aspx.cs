using System;

namespace DemoWcfClient
{
    public partial class GetMessageForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGetMessage_Click(object sender, EventArgs e)
        {
            GetMessageService.MessageServiceClient client = new GetMessageService.MessageServiceClient("BasicHttpBinding_IMessageService");

            lblGetMessage.Text = client.GetMessage(tbxGetMessage.Text);


        }
    }
}