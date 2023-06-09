﻿namespace DMF.Common.Interfaces
{
  public interface IInitializeable
  {
    bool IsInitialized { get; }

    void Initialize();

    bool PostInitialize();
  }
}
