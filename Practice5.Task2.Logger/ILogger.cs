using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5.Task2.Logger
{
  public enum LogLevel
  {
    Trace,
    Info,
    Debug,
    Warning,
    Error,
    Fatal
  }
  public interface ILogger
  {
    void Trace(string data);
    void Info(string data);
    void Debug(string data);
    void Warning(string data);
    void Error(string data);
    void Fatal(string data);
    void Log(string message, LogLevel logLevel);
  }
}
