using System;
using System.Diagnostics;
using System.IO;

namespace Practice5.Task2.Logger
{
  public class FileLogger : ILogger
  {
    string directoryPath = Directory.GetCurrentDirectory();
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
      string line = string.Format("< {0} > | {1} | {2} | {3}", DateTime.Now, frame.GetMethod().DeclaringType.Name, logLevel, message);

      string fileName = string.Format("LogFile-{0}.txt", DateTime.Now.ToShortDateString());
      if (!Directory.Exists(directoryPath + "/LOG"))
      {
        Directory.CreateDirectory(directoryPath + "/LOG");
      }
      using (StreamWriter sw = File.CreateText(directoryPath + "/LOG/" + fileName))
      {
        sw.WriteLine(line);
      }
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
