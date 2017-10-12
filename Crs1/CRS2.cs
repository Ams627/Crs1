using System.Linq;

namespace Crs1
{
    class CRS2
    {
        readonly int _crs = -1;
        public CRS2(string crs)
        {
            if (crs.Length == 3 && crs.All(x => char.IsLetter(x)))
            {
                _crs = ((crs[0] - 'A') << 10) + ((crs[1] - 'A') << 5) + (crs[2] - 'A') ;
            }
        }

        public string GetCRS()
        {
            string result = "Invalid CRS";
            if (_crs != -1)
            {
                result = "" + (char)('A' + (_crs >> 10)) + (char)('A' + ((_crs >> 5) & 0x1F)) + (char)('A' + (_crs & 0x1F));
            }
            return result;
        }
    }
}
