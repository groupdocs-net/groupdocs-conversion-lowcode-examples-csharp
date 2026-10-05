# Add Conversion Code

Replace the contents of `Program.cs` with the following code to convert a DOCX file to PDF:

## Code Example

```csharp
using GroupDocs.Conversion.LowCode;

// Copy and paste your license keys
var publicKey = "<your public license key>";
var privateKey = "<your private license key>";

// Set the license
License.Set(publicKey, privateKey);

// Create a converter for a DOCX file
var converter = new DocxToPdfConverter("business-plan.docx");

// Convert to PDF
converter.Convert("business-plan.pdf");
```

## How to Run

1. Install the .NET SDK for `net10.0`.
2. Edit `Program.cs` so that it uses your license: the path to your license file, or your public and private keys.
3. Open this directory and run the example:
   ```bash
   dotnet run
   ```

## Input Files

- `business-plan.docx`

## Learn More

- [Quick Start Guide](https://docs.groupdocs.net/conversion/getting-started/quick-start-guide/) in the GroupDocs.Conversion.LowCode documentation
- [GroupDocs.Conversion.LowCode](https://www.nuget.org/packages/GroupDocs.Conversion.LowCode) on NuGet
- [Get a temporary license](https://purchase.groupdocs.net/temporary-license/)
