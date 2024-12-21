using System.Text.Json.Serialization;

namespace BaseLibrary.Entities
{
    public class Relationship
    {
        //Relationship : One To Many
        [JsonIgnore]

        public List<Employee>? Employees { get; set; }
    }
}
