# Convert Specific PPTX Slides to PDF

To convert only a portion of the presentation instead of all slides. You can specify which slides to include in the output PDF using the [Pages](https://reference.groupdocs.net/conversion/GroupDocs.Conversion.Options.Convert/IPagedConvertOptions/PageNumber/) property of `PdfConvertOptions` class.

As an alternative you can use `PageNumber` to specify the slide number to start conversion from and `PagesCount` to set number of slides to convert starting from `PageNumber`. 

The following example shows how to convert the first three slides of a PPTX presentation to PDF:

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

// Create the converter
var converter = new PptxToPdfConverter("presentation.pptx");

// Save first three slides to PDF
converter.Convert("slides-1-2-3.pdf", (convertOptions) => {
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

- `presentation.pptx`

## Learn More

- [Using PPTX to PDF Converter](https://docs.groupdocs.net/conversion/developer-guide/using-pptx-to-pdf-converter/) in the GroupDocs.Conversion.LowCode documentation
- [GroupDocs.Conversion.LowCode](https://www.nuget.org/packages/GroupDocs.Conversion.LowCode) on NuGet
- [Get a temporary license](https://purchase.groupdocs.net/temporary-license/)
