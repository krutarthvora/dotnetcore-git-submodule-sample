using Newtonsoft.Json;

namespace dotnetcore_git_submodule_sample
{
  public class JsonHelper
  {
    public static string Serialize(object value)
    {
      string retu = "";
      if (value != null)
      {
        JsonSerializerSettings settings = new()
        {
          TypeNameHandling = TypeNameHandling.Auto
        };
        retu = JsonConvert.SerializeObject(value, settings);
      }
      return retu;
    }
    public static string Serialize4Print(object value)
    {
      string retu = "";
      if (value != null)
      {
        retu = JsonConvert.SerializeObject(value, Formatting.Indented);
      }
      return retu;
    }
  }
}