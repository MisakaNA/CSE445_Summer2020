using System.ServiceModel;
using System.ServiceModel.Web;

namespace RequiredServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        [WebGet(UriTemplate="Covid19Cases?country={country}")]
        string Covid19Cases(string country);

        [OperationContract]
        [WebGet(UriTemplate = "Weather5Days?city={city}&state={state}&unit={unit}")]
        string Weather5Days(string city, string state, string unit);
    }
}
