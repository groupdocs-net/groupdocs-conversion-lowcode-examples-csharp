using System;
using GroupDocs.Conversion.LowCode;

// Load license keys
var publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY");
var privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY");

// Apply the license
License.Set(publicKey, privateKey);

// Create a converter for the PDF file
var converter = new PdfToPdfAConverter("business-plan.pdf");

// Convert PDF to PDF/A
converter.Convert("archived.pdf");