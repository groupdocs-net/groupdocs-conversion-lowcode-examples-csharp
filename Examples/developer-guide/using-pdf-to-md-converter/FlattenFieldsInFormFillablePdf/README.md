# Flatten Fields in Form-Fillable PDF

The following example shows how to convert a form‑fillable PDF into static content by flattening form fields.

## Code Example

```csharp
using System;
using GroupDocs.Conversion.LowCode;

// Load license keys
var publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY");
var privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY");

// Apply license
License.Set(publicKey, privateKey);

// Flatten form fields through load options
var converter = new PdfToMdConverter("form-fields.pdf", options =>
{
    options.FlattenAllFields = true;
});

// Convert PDF to Markdown
converter.Convert("flattened.md");
```

## How to Run

1. Install the .NET SDK for `net10.0`.
2. Set the `GD_PUBLIC_KEY` and `GD_PRIVATE_KEY` environment variables to your license keys.
3. Open this directory and run the example:
   ```bash
   dotnet run
   ```

## Input Files

- `form-fields.pdf`

## Learn More

- [Using PDF to MD Converter](https://docs.groupdocs.net/conversion/developer-guide/using-pdf-to-md-converter/) in the GroupDocs.Conversion.LowCode documentation
- [GroupDocs.Conversion.LowCode](https://www.nuget.org/packages/GroupDocs.Conversion.LowCode) on NuGet
- [Get a temporary license](https://purchase.groupdocs.net/temporary-license/)
