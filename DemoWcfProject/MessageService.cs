namespace DemoWcfProject
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MessageService" in both code and config file together.
    public class MessageService : IMessageService
    {
        public string GetMessage(string message)
        {
            return "Your Message: " + message;
        }
    }
}
