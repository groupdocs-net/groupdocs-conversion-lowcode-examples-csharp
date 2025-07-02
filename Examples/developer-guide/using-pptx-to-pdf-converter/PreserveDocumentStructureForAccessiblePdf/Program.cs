using System;
using GroupDocs.Conversion.LowCode;

// Load license keys
var publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY");
var privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY");

// Apply license
License.Set(publicKey, privateKey);

// Preserve document structure through load options
var converter = new PptxToPdfConverter("presentation.pptx", options =>
{
    options.PreserveDocumentStructure = true;
});

// Convert PPTX to PDF
converter.Convert("accessible.pdf");