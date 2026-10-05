# Convert HTML with Custom CSS Styling

The following example shows how to apply custom CSS styling when converting HTML to PDF using the `CustomCssStyle` property.

## Code Example

```csharp
using System;
using GroupDocs.Conversion.LowCode;

// Load license keys
var publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY");
var privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY");

// Apply license
License.Set(publicKey, privateKey);

// Apply custom CSS styling through load options
var converter = new HtmlToPdfConverter("sample.html", options =>
{
    options.CustomCssStyle = "body { color: coral !important; }";
});

// Convert HTML to PDF
converter.Convert("styled-sample.pdf");
```

## How to Run

1. Install the .NET SDK for `net10.0`.
2. Set the `GD_PUBLIC_KEY` and `GD_PRIVATE_KEY` environment variables to your license keys.
3. Open this directory and run the example:
   ```bash
   dotnet run
   ```

## Input Files

- `sample.html`

## Learn More

- [Using HTML to PDF Converter](https://docs.groupdocs.net/conversion/developer-guide/using-html-to-pdf-converter/) in the GroupDocs.Conversion.LowCode documentation
- [GroupDocs.Conversion.LowCode](https://www.nuget.org/packages/GroupDocs.Conversion.LowCode) on NuGet
- [Get a temporary license](https://purchase.groupdocs.net/temporary-license/)
