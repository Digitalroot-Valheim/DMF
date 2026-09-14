using System.Diagnostics;

namespace Digitalroot.Modding.Framework.Logging
{
  [DebuggerDisplay("Source = {Source}, EnableTrace = {EnableTrace}", Name = "{Source}")]
  public class StaticSourceLogger : ITraceableLogging
  {
    public StaticSourceLogger(bool enableTrace = false)
      : this(nameof(Digitalroot), enableTrace)
    {
    }

    public StaticSourceLogger(string source, bool enableTrace = false)
    {
      Source = source;
      EnableTrace = enableTrace;
    }

    public static StaticSourceLogger PreMadeTraceableInstance = new(true);
    public static StaticSourceLogger PreMadeNonTraceableInstance = new();

    #region Implementation of ITraceableLogging

    /// <inheritdoc />
    public string Source { get; }

    /// <inheritdoc />
    public bool EnableTrace { get; }

    #endregion
  }
}
