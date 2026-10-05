# Example 2: Save to Stream

This example demonstrates how to save the converted file to a `Stream`.

## Code Example

```csharp
using System;
using System.IO;
using GroupDocs.Conversion.LowCode;

// Load license keys
var publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY");
var privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY");

// Apply license
License.Set(publicKey, privateKey);

// Load DOCX file as stream
using var stream = File.OpenRead("business-plan.docx");

// Create a converter from stream
var converter = new DocxToPdfConverter(stream);

// Instantiate output file stream
using var convertedFile = File.Create("business-plan.pdf");

// Convert DOCX to PDF
converter.Convert(convertedFile);
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

- [Saving Converted Documents](https://docs.groupdocs.net/conversion/developer-guide/saving-converted-documents/) in the GroupDocs.Conversion.LowCode documentation
- [GroupDocs.Conversion.LowCode](https://www.nuget.org/packages/GroupDocs.Conversion.LowCode) on NuGet
- [Get a temporary license](https://purchase.groupdocs.net/temporary-license/)
