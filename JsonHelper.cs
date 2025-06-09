using Newtonsoft.Json;
namespace Utilidades;
public static class JsonHelper
{
    public static string Serializar(object objeto)
    {
        return JsonConvert.SerializeObject(objeto);
    }

    public static T Deserializar<T>(string json)
    {
        return JsonConvert.DeserializeObject<T>(json);
    }
}