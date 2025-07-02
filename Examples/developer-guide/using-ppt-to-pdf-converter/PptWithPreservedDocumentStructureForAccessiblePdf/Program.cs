using System;
using GroupDocs.Conversion.LowCode;

// Load license keys
var publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY");
var privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY");

// Apply license
License.Set(publicKey, privateKey);

// Preserve document structure for accessible PDF
var converter = new PptToPdfConverter("presentation.ppt", options =>
{
    options.PreserveDocumentStructure = true;
});

// Convert PPT to accessible PDF
converter.Convert("accessible.pdf");