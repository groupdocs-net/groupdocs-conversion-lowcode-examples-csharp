using System;
using System.Collections.Generic;
using GroupDocs.Conversion.LowCode;

// Load license keys
var publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY");
var privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY");

// Apply license
License.Set(publicKey, privateKey);

// Create the converter
var converter = new PptxToPdfConverter("presentation.pptx");

// Save first three slides to PDF
converter.Convert("slides-1-2-3.pdf", (convertOptions) => {
    convertOptions.Pages = new List<int> { 1, 2, 3 };
});