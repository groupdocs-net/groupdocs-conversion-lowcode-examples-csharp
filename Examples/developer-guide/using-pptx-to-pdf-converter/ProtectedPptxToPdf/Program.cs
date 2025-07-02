using System;
using GroupDocs.Conversion.LowCode;

// Load license keys
var publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY");
var privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY");

// Apply license
License.Set(publicKey, privateKey);

// Provide password through load options
var converter = new PptxToPdfConverter("protected.pptx", options =>
{
    options.Password = "12345";
});

// Convert PPTX to PDF
converter.Convert("unprotected.pdf");