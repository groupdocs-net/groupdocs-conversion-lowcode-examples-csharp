# Convert DOCX to Password-Protected PDF

You can protect the output PDF with a password by setting the [Password](https://reference.groupdocs.net/conversion/GroupDocs.Conversion.Options.Convert/PdfConvertOptions/Password/) property in `PdfConvertOptions` class.

## Code Example

```csharp
using System;
using GroupDocs.Conversion.LowCode;

// Load license keys
var publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY");
var privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY");

// Apply license
License.Set(publicKey, privateKey);

// Create the converter
var converter = new DocxToPdfConverter("business-plan.docx");

// Convert to password-protected PDF
converter.Convert("protected.pdf", convertOptions =>
{
    convertOptions.Password = "12345";
});
```

## How to Run

1. Install the .NET SDK for `net10.0`.
2. Set the `GD_PUBLIC_KEY` and `GD_PRIVATE_KEY` environment variables to your license keys.
3. Open this directory and run the example:
   ```bash
   dotnet run
   ```

## Input Files

- `business-plan.docx`

## Learn More

- [Using DOCX to PDF Converter](https://docs.groupdocs.net/conversion/developer-guide/using-docx-to-pdf-converter/) in the GroupDocs.Conversion.LowCode documentation
- [GroupDocs.Conversion.LowCode](https://www.nuget.org/packages/GroupDocs.Conversion.LowCode) on NuGet
- [Get a temporary license](https://purchase.groupdocs.net/temporary-license/)
