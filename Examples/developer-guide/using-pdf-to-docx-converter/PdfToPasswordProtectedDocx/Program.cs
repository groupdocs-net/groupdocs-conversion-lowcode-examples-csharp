using System;
using GroupDocs.Conversion.LowCode;

// Load license keys
var publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY");
var privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY");

// Apply license
License.Set(publicKey, privateKey);

// Create the converter
var converter = new PdfToDocxConverter("business-plan.pdf");

// Convert to password-protected DOCX
converter.Convert("protected.docx", convertOptions =>
{
    convertOptions.Password = "12345";
});