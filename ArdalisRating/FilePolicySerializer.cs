using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ArdalisRating
{

  public class FilePolicySerializer{
      public Policy GetPolicyFromJsonString(string jsonFile){
         return JsonConvert.DeserializeObject<Policy>(jsonFile,
                new StringEnumConverter());
      }
  }
}
