using System.Security.Cryptography;

class Program
{
    static void Main()
    {
        using (var rng = new RNGCryptoServiceProvider())
        {
            byte[] keyBytes = new byte[32]; // 256 bit = 32 byte
            rng.GetBytes(keyBytes);

            string keyHex = BitConverter.ToString(keyBytes).Replace("-", "").ToLower();

            Console.WriteLine("256 bitlik rastgele anahtar (hex formatında):");
            Console.WriteLine(keyHex);
        }
    }
}
