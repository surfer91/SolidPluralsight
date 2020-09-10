using System;

namespace ArdalisRating
{
public interface ILogger{
  void Log(string messsage);
}
  public class ConsoleLogger:ILogger{
      public void Log(string message){
          System.Console.WriteLine(message);
      }
  }
}
