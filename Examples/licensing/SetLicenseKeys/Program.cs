using GroupDocs.Conversion.LowCode;

internal class Program
{
    private static void Main(string[] args)
    {
        SetLicenseKeys();
    }

    private static void SetLicenseKeys()
    {
        // The public and private keys from your license.
        string publicKey = "...";
        string privateKey = "...";

        // Set license keys.
        License.Set(publicKey, privateKey);
    }
}
