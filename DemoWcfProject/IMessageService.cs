using System.ServiceModel;

namespace DemoWcfProject
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IDemoWcfService" in both code and config file together.
    [ServiceContract]
    public interface IDemoWcfService
    {
        [OperationContract]
        void DoWork();
    }
}
