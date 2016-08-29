using System;

namespace HidingQueryString
{
    public class EncodeDecode
    {
        public static string Encode(string encodeMe)
        {
            var encoded = System.Text.Encoding.UTF8.GetBytes(encodeMe);
            return Convert.ToBase64String(encoded);
        }

        public static string Decode(string decodeMe)
        {
            try
            {
                var encoded = Convert.FromBase64String(decodeMe);
                return System.Text.Encoding.UTF8.GetString(encoded);
            }
            catch (Exception e)
            {
                return string.Empty;
            }
        }
    }
}