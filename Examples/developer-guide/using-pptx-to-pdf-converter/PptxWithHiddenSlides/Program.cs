using System;
using GroupDocs.Conversion.LowCode;

// Load license keys
var publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY");
var privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY");

// Apply license
License.Set(publicKey, privateKey);

// Show hidden slides through load options
var converter = new PptxToPdfConverter("with-hidden-slides.pptx", options =>
{
    options.ShowHiddenSlides = true;
});

// Convert PPTX to PDF
converter.Convert("with-hidden-slides.pdf");