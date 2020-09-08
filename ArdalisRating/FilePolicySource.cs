using System;
using System.IO;

namespace ArdalisRating
{

public class FilePolicySource{
    public string GetPolicyFormSource(){
        return File.ReadAllText("policy.json");
    }
}
}
