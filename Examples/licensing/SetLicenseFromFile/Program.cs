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

        // Apply the license. 
        License.Set(licensePath);
    }
}
