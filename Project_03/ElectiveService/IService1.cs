using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.Services;

namespace ElectiveServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        [WebGet(UriTemplate = "TranslateURText?urText={urText}&language={language}")]
        string TranslateURText(string urText, string language);

        [OperationContract]
        [WebGet(UriTemplate = "Top10NewsAbout?topic={topic}")]
        string Top10NewsAbout(string topic);

        [OperationContract]
        [WebGet(UriTemplate = "RateMyProfessor?schoolName={schoolName}&professorName={professorName}")]
        string RateMyProfessor(string schoolName, string professorName);

        [OperationContract]
        [WebGet(UriTemplate = "ASUClassFinder?semester={semester}&classCode={classCode}&classNum={classNum}&status={status}")]
        string ASUClassFinder(string semester, string classCode, string classNum, string status);
    }
}
