using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace Digitalroot.Modding.Framework.Common.Attributes
{
  /// <summary>
  /// Information provided via this Attribute is informational only.
  /// </summary>
  [Conditional("DEBUG"), AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
  public class AiInfoAttribute : Attribute
  {
    [DebuggerHidden]
    public static void ImplementedFor(AiInfoMetaData data)
    {
    }

    /// <summary>
    /// Ai Metadata
    /// </summary>
    /// <param name="metadata">Metadata</param>
    /// <param name="note">Note</param>
    public AiInfoAttribute(string note, params AiInfoMetaData[] metadata)
    {
      AiInfoMetaData.AddRange(metadata);
      Note = note;
    }

    /// <summary>
    /// Ai Metadata
    /// </summary>
    /// <param name="metadata">Metadata</param>
    public AiInfoAttribute(params AiInfoMetaData[] metadata) : this(string.Empty, metadata)
    {
    }

    /// <summary>
    /// Metadata
    /// </summary>
    public List<AiInfoMetaData> AiInfoMetaData { get; } = new();

    /// <summary>
    /// Note
    /// </summary>
    public string Note { get; }
  }

  [SuppressMessage("ReSharper", "InconsistentNaming")]
 
  public enum AiInfoMetaData
  {
    /// <summary>
    /// No Ai used.
    /// </summary>
    None = 0, 
    
    /// <summary>
    /// Ai assisted/advised in the creation.
    /// </summary>
    Ai_Assisted,

    /// <summary>
    /// Ai generated code.
    /// </summary>
    Ai_Generated
  }
}
