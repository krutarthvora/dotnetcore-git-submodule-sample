using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace dotnetcore_git_submodule_sample
{
	public class JSONHelper
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
		public static T Deserialize<T>(string jsonValue)
		{
			JsonSerializerSettings settings = new()
			{
				TypeNameHandling = TypeNameHandling.Auto
			};
			T retu = JsonConvert.DeserializeObject<T>(jsonValue);
			return retu;
		}
		public static string SerializeCamelCase(object value)
		{
			string retu = "";
			if (value != null)
			{
				JsonSerializerSettings settings = new()
				{
					ContractResolver = new CamelCasePropertyNamesContractResolver()
				};
				retu = JsonConvert.SerializeObject(value, settings);
			}
			return retu;
		}
	}
}