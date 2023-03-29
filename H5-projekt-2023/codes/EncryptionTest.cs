using Microsoft.AspNetCore.DataProtection;
namespace H5_projekt_2023.codes
{
    public class EncryptionTest
    {
        private readonly IDataProtector _encryptor;

        public EncryptionTest(IDataProtectionProvider protector)
        {
            _encryptor = protector.CreateProtector("H5-projekt-2023.codes.EncryptionTest.JeppeMarcussen");
        }
        public string Protect(string valueToEncrypt) => _encryptor.Protect(valueToEncrypt);
        public string UnProtect(string valueToDecrypt) => _encryptor.Unprotect(valueToDecrypt);
    }
}
