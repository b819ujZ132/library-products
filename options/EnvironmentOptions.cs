using System.Collections.Generic;

namespace Products.Library.Options
{
  public class EnvironmentOptions
  {
    public string Environment { get; set; }
    public string Host { get; set; }
    public string Path { get; set; }

    public string GetEndpoint()
    {
      return $"{Host}{Path}";
    }
  }
}