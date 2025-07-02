using System;
using GroupDocs.Conversion.LowCode;

// Load license keys
var publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY");
var privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY");

// Apply license
License.Set(publicKey, privateKey);

// Hide annotations using HidePdfAnnotations
var converter = new PdfToPdfAConverter("with-annotations.pdf", options =>
{
    options.HidePdfAnnotations = true;
});

// Convert PDF to PDF/A
converter.Convert("no-annotations.pdf");