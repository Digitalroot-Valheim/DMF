using System.Collections.Generic;

namespace Digitalroot.Modding.Framework.Names.Vanilla;

public static partial class ColorNames
{
  public static readonly IEnumerable<string> AllNames = Utils.Utils.ReflectionUtils.AllNames(typeof(ColorNames));
  public static readonly string Black = "black";
  public static readonly string Blue = "blue";
  public static readonly string Green = "green";
  public static readonly string Orange = "orange";
  public static readonly string Purple = "purple";
  public static readonly string Red = "red";
  public static readonly string White = "white";
  public static readonly string Yellow = "yellow";
}
