﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.IO;

namespace ArdalisRating
{
    /// <summary>
    /// The RatingEngine reads the policy application details from a file and produces a numeric 
    /// rating value based on the details.
    /// </summary>
    public class RatingEngine
    {
        public decimal Rating { get; set; }

        public ConsoleLogger Logger { get; set; }=new ConsoleLogger();
        public FilePolicySource PolicySource { get; set; }=new FilePolicySource();

        public FilePolicySerializer PolicySerializer { get; set; }=new FilePolicySerializer();

        public void Rate()
        {
            Logger.Log("Starting rate.");

            Logger.Log("Loading policy.");

            // load policy - open file policy.json
            string policyJson = PolicySource.GetPolicyFormSource();
            var policy = PolicySerializer.GetPolicyFromJsonString(policyJson);
               

            switch (policy.Type)
            {
                case PolicyType.Auto:
                        var rater=new AutoPolicyRater(this,Logger);
                        rater.Rate(policy);
                    break;

                case PolicyType.Land:
                   var rater2=new LandPolicyRater(this,Logger);
                        rater2.Rate(policy);
                    break;

                case PolicyType.Life:
                         var rater3=new LifePolicyRater(this,Logger);
                        rater3.Rate(policy);
                    break;

                default:
                    Logger.Log("Unknown policy type");
                    break;
            }

            Logger.Log("Rating completed.");
        }
    }
}
