# Basic Example

The following example shows the most common use case for converting PowerPoint presentation to PDF. The source PPTX file is loaded from a current folder. The converted file is saved to the same folder.

## Code Example

```csharp
using System;
using GroupDocs.Conversion.LowCode;

// Load license keys
var publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY");
var privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY");

// Apply the license
License.Set(publicKey, privateKey);

// Create a converter for the PPTX file
var converter = new PptxToPdfConverter("presentation.pptx");

// Convert PPTX to PDF
converter.Convert("converted.pdf");
```

## How to Run

1. Install the .NET SDK for `net10.0`.
2. Set the `GD_PUBLIC_KEY` and `GD_PRIVATE_KEY` environment variables to your license keys.
3. Open this directory and run the example:
   ```bash
   dotnet run
   ```

## Input Files

- `presentation.pptx`

## Learn More

- [Using PPTX to PDF Converter](https://docs.groupdocs.net/conversion/developer-guide/using-pptx-to-pdf-converter/) in the GroupDocs.Conversion.LowCode documentation
- [GroupDocs.Conversion.LowCode](https://www.nuget.org/packages/GroupDocs.Conversion.LowCode) on NuGet
- [Get a temporary license](https://purchase.groupdocs.net/temporary-license/)
