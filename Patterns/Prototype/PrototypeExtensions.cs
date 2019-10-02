using Newtonsoft.Json;

namespace DesignPatterns.Prototype
{
    static class PrototypeExtensions
    {
        public static T DeepCopy<T>(this T obj)
        {
            var serialized = JsonConvert.SerializeObject(obj);
            return JsonConvert.DeserializeObject<T>(serialized);
        }
    }
}
