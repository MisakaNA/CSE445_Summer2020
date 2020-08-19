using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;

namespace Project4_Service
{
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        [WebGet(UriTemplate = "Verification?xml={xml}&xsd={xsd}")]
        string Verification(string xml, string xsd);
    }
}
