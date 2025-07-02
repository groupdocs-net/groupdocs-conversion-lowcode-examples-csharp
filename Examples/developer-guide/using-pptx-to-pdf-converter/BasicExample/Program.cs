using System;
using GroupDocs.Conversion.LowCode;

// Load license keys
var publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY");
var privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY");

// Apply the license
License.Set(publicKey, privateKey);

// Create a converter for the PPTX file
var converter = new PptxToPdfConverter("presentation.pptx");

// Convert PPTX to PDF
converter.Convert("converted.pdf");