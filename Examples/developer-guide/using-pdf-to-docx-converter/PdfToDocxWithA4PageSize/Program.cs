using System;
using GroupDocs.Conversion.LowCode;
using GroupDocs.Conversion.Options.Convert;

// Load license keys
var publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY");
var privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY");

// Apply license
License.Set(publicKey, privateKey);

// Create the converter
var converter = new PdfToDocxConverter("business-plan.pdf");

// Convert to DOCX with A4 page size
converter.Convert("a4-size.docx", convertOptions =>
{
    convertOptions.PageSize = PageSize.A4;
});