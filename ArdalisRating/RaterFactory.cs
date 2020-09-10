using System;

namespace ArdalisRating
{
    public class RaterFactory
    {
        public Rater Create(Policy policy, IRatingContext context)
        {
    //    switch (policy.Type)
    //         {
    //             case PolicyType.Auto:
    //                    return new AutoPolicyRater(engine,engine.Logger);

    //             case PolicyType.Land:
    //             return new LandPolicyRater(engine,engine.Logger);

    //                 case PolicyType.Life:
    //                  return new LifePolicyRater(engine,engine.Logger);

    //             case PolicyType.Flood:
               
    //                  return new FloodPolicyRater(engine,engine.Logger);
    //                  default:
    //                  return new UnknownPolicyRater(engine,engine.Logger); }

                                 try
            {
                return (Rater)Activator.CreateInstance(
                    Type.GetType($"ArdalisRating.{policy.Type}PolicyRater"),
                        new object[] { new RatingUpdater(context.Engine) });
            }
            catch
            {
                return null;
            }



         }
    }
}