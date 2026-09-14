namespace Digitalroot.Modding.Framework.Logging
{
  public interface ITraceableLogging
  {
    string Source { get; }
    bool EnableTrace { get; }
  }
}
