using DMF.Common.Hooks;
using NUnit.Framework;

namespace UnitTests
{
  public class HooksTests
  {
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
      TraderHooks.Instance.BeforeStart += OnBeforeStart;
    }

    private void OnBeforeStart(TraderEventArgs eventargs)
    {
      throw new System.NotImplementedException();
    }
  }
}