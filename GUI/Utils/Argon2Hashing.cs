using Konscious.Security.Cryptography;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace GUI.Utils
{
    public class Argon2Hashing
    {
        public byte[] CreateSalt()
        {
            var buffer = new byte[16];
            var rng = new RNGCryptoServiceProvider();
            rng.GetBytes(buffer);
            return buffer;
        }

        public byte[] HashPassword(string password, byte[] salt)
        {
            var argon2 = new Argon2id(Encoding.UTF8.GetBytes(password));

            //DO NOT CHANGE THESE PARAMETERS. WILL MAKE ALL LOGIN INFORMATION OBSOLETE
            argon2.Salt = salt;
            argon2.DegreeOfParallelism = 2; // one core
            argon2.Iterations = 4;
            argon2.MemorySize = 128 * 128;

            return argon2.GetBytes(16);
        }

        public bool VerifyHash(string password, byte[] salt, byte[] hash)
        {
            var newHash = HashPassword(password, salt);
            return hash.SequenceEqual(newHash);
        }
    }
}