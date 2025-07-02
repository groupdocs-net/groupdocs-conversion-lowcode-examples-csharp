using System;
using GroupDocs.Conversion.LowCode;

// Load license keys
var publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY");
var privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY");

// Apply license
License.Set(publicKey, privateKey);

// Create the converter
var converter = new DocxToPdfConverter("business-plan.docx");

// Convert to password-protected PDF
converter.Convert("protected.pdf", convertOptions =>
{
    convertOptions.Password = "12345";
});