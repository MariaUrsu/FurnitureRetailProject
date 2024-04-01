using System.Security.Cryptography;
using System.Text;

namespace FurnitureRetail.Core.Utils.Extensions;

public static class Hash
{
    public static string ComputeSha256Hash(this string rawData)
    {
        byte[] bytes = SHA256.HashData(Encoding.UTF8.GetBytes(rawData));

        StringBuilder builder = new();
        for (int i = 0; i < bytes.Length; i++)
        {
            builder.Append(bytes[i].ToString("x2"));
        }
        return builder.ToString();
    }
}
