﻿using System;

namespace DMF.Common.Extensions;

public static class Int32Extensions
{
  public static float ToFloat(this int value) => Convert.ToSingle(value);
}
