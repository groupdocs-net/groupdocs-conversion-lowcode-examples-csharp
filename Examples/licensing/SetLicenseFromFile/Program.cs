using System;
using System.IO;
using GroupDocs.Conversion.LowCode;

internal class Program
{
    private static void Main(string[] args)
    {
        SetLicenseFromFile();
    }

    private static void SetLicenseFromFile()
    {
        // The path to the license file. The path can be relative or absolute.
        string licensePath = "./GroupDocs.Conversion.LowCode.lic";

        // Check if the license file exists
        if (!File.Exists(licensePath))
        {
            Console.WriteLine("Warning: License file not found at '{0}'.", licensePath);
            Console.WriteLine("This code example requires a license file to be placed in the current directory.");
            Console.WriteLine("Please ensure the license file 'GroupDocs.Conversion.LowCode.lic' is present.");
            return;
        }

        // Apply the license. 
        License.Set(licensePath);
        Console.WriteLine("License applied successfully from file: {0}", licensePath);
    }
}