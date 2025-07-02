using System;
using GroupDocs.Conversion.LowCode;

internal class Program
{
    private static void Main(string[] args)
    {
        SetLicenseKeys();
    }

    private static void SetLicenseKeys()
    {
        // The path to the license file. The path can be relative or absolute.
        string privateKey = "...";
        string publicKey = "...";
 
        // Check if license keys are properly set
        if (string.IsNullOrEmpty(privateKey) || privateKey == "..." || 
            string.IsNullOrEmpty(publicKey) || publicKey == "...")
        {
            Console.WriteLine("WARNING: This code example requires license keys to be set.");
            Console.WriteLine("Please replace the placeholder values with your actual license keys:");
            Console.WriteLine("- privateKey: Your private license key");
            Console.WriteLine("- publicKey: Your public license key");
            return;
        }

        // Set license keys.
        License.Set(privateKey, publicKey);
        Console.WriteLine("License keys have been set successfully.");
    }
}