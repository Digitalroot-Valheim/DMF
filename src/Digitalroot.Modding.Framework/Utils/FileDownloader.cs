using JetBrains.Annotations;
using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Digitalroot.Modding.Framework.Utils;

/// <summary>
/// Source: https://dev.to/1001binary/download-file-using-httpclient-wrapper-asynchronously-1p6
/// </summary>
public static class FileDownloader
{
  private static readonly HttpClient _httpClient = new();

  [UsedImplicitly]
  public static async Task DownloadFileAsync(string uri, string outputPath)
  {
    File.WriteAllBytes(outputPath, await _httpClient.GetByteArrayAsync(uri));  
  }

  public static Task DownloadFileAsync(Uri uri, FileInfo outputPath) => DownloadFileAsync(uri.OriginalString, outputPath.FullName);

  public static Task DownloadFileAsync(Uri uri, string outputPath) => DownloadFileAsync(uri.OriginalString, outputPath);

  public static Task DownloadFileAsync(string uri, FileInfo outputPath) => DownloadFileAsync(uri, outputPath.FullName);

}
