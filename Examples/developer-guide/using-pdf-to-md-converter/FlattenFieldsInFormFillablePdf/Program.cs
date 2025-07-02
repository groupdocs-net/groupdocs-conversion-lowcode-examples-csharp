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