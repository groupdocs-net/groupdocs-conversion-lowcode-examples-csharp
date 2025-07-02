using System;
using GroupDocs.Conversion.LowCode;
using GroupDocs.Conversion.Options.Convert;

// Load license keys
var publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY");
var privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY");

// Apply license
License.Set(publicKey, privateKey);

// Create the converter
var converter = new XlsToPdfConverter("cost-analysis.xls");

// Convert to PDF/A-1b format for archiving
converter.Convert("converted.pdf", convertOptions =>
{
    convertOptions.PdfOptions.PdfFormat = PdfFormats.PdfA_1B;
});