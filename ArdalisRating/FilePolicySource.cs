using System;
using System.IO;

namespace ArdalisRating
{ public interface IPolicySource{
    string GetPolicyFormSource();
}

public class FilePolicySource:IPolicySource{
    public string GetPolicyFormSource(){
        return File.ReadAllText("policy.json");
    }
}
}
