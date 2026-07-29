using Newtonsoft.Json;
using Utilidades.Servicios.Serializacion.Interfaces;
namespace Utilidades.Servicios.Serializacion.Implementaciones
{
    public class SerializadorJsonServicio : ISerializadorJsonServicio
    {
        public string Serializar<T>(T objeto)
        {
            return JsonConvert.SerializeObject(objeto);
        }

        public T Deserializar<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
