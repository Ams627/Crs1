using System.Linq;

namespace Crs1
{
    class CRS
    {
        readonly int _crs = -1;
        public CRS(string crs)
        {
            if (crs.Length == 3 && crs.All(x => char.IsLetter(x)))
            {
                _crs = 26 * 26 * (crs[0] - 'A') + 26 * (crs[1] - 'A') + crs[2] - 'A';
            }
        }

        public string GetCRS()
        {
            string result = "Invalid CRS";
            if (_crs != -1)
            {
                result = "" + (char)('A' + (_crs / 26 / 26)) + (char)('A' + (_crs / 26) % 26) + (char)('A' + _crs % 26);
            }
            return result;
        }
    }
}
