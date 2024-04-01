using System.Security.Claims;
using System.Text.Json.Serialization;

namespace FurnitureRetail.Core;
public class Request
{
    [JsonIgnore]
    public ClaimsIdentity? Customer { get; set; }
}