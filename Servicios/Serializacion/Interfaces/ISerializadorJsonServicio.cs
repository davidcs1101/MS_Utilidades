namespace Utilidades.Servicios.Serializacion.Interfaces
{
    public interface ISerializadorJsonServicio
    {
        string Serializar<T>(T objeto);
        T Deserializar<T>(string json);
    }
}
