using System.Linq;

namespace HidingQueryString.Models
{
    public sealed class StringListModel
    {
        private string[] StringList { get; }
        public string[] HiddenStringList { get; set; }

        public StringListModel()
        {
            StringList = new[] { "hello", "testing", "this", "out" };
            HiddenStringList = new string[StringList.Count()];
            for (var i = 0; i < HiddenStringList.Length; i++)
            {
                HiddenStringList[i] = EncodeDecode.Encode(StringList[i]);
            }
        }
    }
}