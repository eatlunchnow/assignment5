using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
[ServiceContract]
public interface IService
{
    [OperationContract]
    // void DoWork();

    int Login(string user, string password);

    [OperationContract]
    bool RegisterClient(GrantReview r);

    [OperationContract]
    List<GrantInfo> GetGrantType();

    [OperationContract]
    List<GrantType> GetGrantRequest();
}

[DataContract]
public class GrantInfo
{
    [DataMember]
    public string GrantTypeName { get; set; }

    [DataMember]
    public string GrantTypeDescription { get; set; }

}

[DataContract]

public class GrantRequest
{
    [DataMember]
    public string PersonKey { get; set; }

    [DataMember]
    public string GrantReview { get; set; }

}