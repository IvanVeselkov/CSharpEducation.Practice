using System;
using System.Diagnostics;

namespace Practice5.Task2.Logger
{
  public class ConsoleLogger : ILogger
  {
    public void Debug(string data)
    {
      Log(data, LogLevel.Debug);
    }

    public void Error(string data)
    {
      Log(data, LogLevel.Error);
    }

    public void Fatal(string data)
    {
      Log(data, LogLevel.Fatal);
    }

    public void Info(string data)
    {
      Log(data, LogLevel.Info);
    }

    public void Log(string message, LogLevel logLevel)
    {
      var frame = new StackFrame(2);
      Console.WriteLine(string.Format("< {0} > | {1} | {2} | {3}",DateTime.Now, frame.GetMethod().DeclaringType.Name,logLevel,message));
    }

    public void Trace(string data)
    {
      Log(data, LogLevel.Trace);
    }

    public void Warning(string data)
    {
      Log(data, LogLevel.Warning);
    }
  }
}
