# Example 2: Load from Stream

This example demonstrates how to load a document from a stream (e.g., memory or custom storage provider).

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

// Convert DOCX to PDF
converter.Convert("business-plan.pdf");
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

- [Loading Source Documents](https://docs.groupdocs.net/conversion/developer-guide/loading-source-documents/) in the GroupDocs.Conversion.LowCode documentation
- [GroupDocs.Conversion.LowCode](https://www.nuget.org/packages/GroupDocs.Conversion.LowCode) on NuGet
- [Get a temporary license](https://purchase.groupdocs.net/temporary-license/)
