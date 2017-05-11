using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
    // public void DoWork()
    Community_AssistEntities db = new Community_AssistEntities();
    List<GrantInfo> GetGrantType()
    {
        var grants = from b in db.GrantType
                     select b;

        List<GrantInfo> grants = new List<GrantInfo>();
        foreach (GrantInfo gr in grants)
        {
            GrantInfo grant1 = new GrantInfo();
            grant1.GrantTypeDescription = gr.GrantTypeDescription;
            grant1.GrantTypeName = gr.GrantTypeName;

            grant1.GrantPerson = new List<Person>();
            
            foreach (Person a in bk.Persons)
            {
                Person au = new Person();
                au.PersonFirstName = a.PersonFirstName;
                au.PersonLastName = a.PersonLastName;
                au.PersonEmail = a.PersonEmail;
            }
        }

        return grants;
    }

    public List<GetInfo> GetGrantRequest()
    {
        var grants = from b in db.GrantType
                     from a in db.GrantRequests
                     where a.GrantReview.Equals(PersonKey)
                     select b;
    }

        return PersonKey;

public int Login(string user, string password)
{
    int key = 0;
    int result = db.usp_userClientLogin(user, password);
    if (result != -1)
    {
        var userKey = (from k in db.Client
                       where k.ClientUserName.Equals(user)
                       select k.ClientKey).FirstOrDefault();
        key = (int)userKey;
    }

    return key;
}

public bool RegisterClient(GrantReview r)
{
    bool result = true;
    int rev = usp_newClient(r.ClientUserName,
        r.ClientFirstName, r.ClientLastName,
        r.ClientEmail, r.ClientPlainPassword);

    return result;
}

}    