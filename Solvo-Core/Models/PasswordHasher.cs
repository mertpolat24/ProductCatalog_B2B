using System.Security.Cryptography;
using System.Text;

public static class PasswordHasher
{
    public static string Hash(string password)
    {
        using (SHA256 sha256 = SHA256.Create())
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(password);
            byte[] hashBytes = sha256.ComputeHash(inputBytes);
            return Convert.ToBase64String(hashBytes);
        }
    }

    public static bool Verify(string password, string storedHash)
    {
        string hashOfInput = Hash(password);
        return hashOfInput == storedHash;
    }
}
