# Example 3: Set Convert Options

You can use optional convert options to adjust the output according to your requirements. Each converter has its own corresponding convert options.

The following code example shows how to set convert options to convert the first three pages of a DOCX document to a PDF file.

## Code Example

```csharp
using System;
using System.Collections.Generic;
using GroupDocs.Conversion.LowCode;

// Load license keys
var publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY");
var privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY");

// Apply license
License.Set(publicKey, privateKey);

// Create a converter for the DOCX file
var converter = new DocxToPdfConverter("business-plan.docx");

// Save first three pages to PDF
converter.Convert("pages-1-2-3.pdf", (convertOptions) => {
    convertOptions.Pages = new List<int> { 1, 2, 3 };
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

- [Saving Converted Documents](https://docs.groupdocs.net/conversion/developer-guide/saving-converted-documents/) in the GroupDocs.Conversion.LowCode documentation
- [GroupDocs.Conversion.LowCode](https://www.nuget.org/packages/GroupDocs.Conversion.LowCode) on NuGet
- [Get a temporary license](https://purchase.groupdocs.net/temporary-license/)
