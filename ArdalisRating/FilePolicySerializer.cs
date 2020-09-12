using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ArdalisRating
{
    public interface IPolicySerializer
    {
        Policy GetPolicyFromJsonString(string policyString);
    }
  public class FilePolicySerializer:IPolicySerializer{
      public Policy GetPolicyFromJsonString(string jsonFile){
         return JsonConvert.DeserializeObject<Policy>(jsonFile,
                new StringEnumConverter());
      }
  }
}
