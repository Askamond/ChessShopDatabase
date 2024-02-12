using System.Security.Cryptography;
using System.Text;

namespace ChessShopDatabase.Helpers
{

    public static class MD5Hash
    {

        public static byte[] Compute(string stringToHash)
        {
            using (var md5 = MD5.Create())
            {
                return md5.ComputeHash(Encoding.ASCII.GetBytes(stringToHash));
            }
        }

    }

}
