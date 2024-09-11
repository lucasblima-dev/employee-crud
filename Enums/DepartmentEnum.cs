using System.Text.Json.Serialization;

namespace CrudApi.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DepartmentEnum
    {
        HR,
        Finance,
        Purchases,
        Service
    }
}