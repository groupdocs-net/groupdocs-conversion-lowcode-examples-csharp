using System;
using GroupDocs.Conversion.LowCode;

// Load license keys
var publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY");
var privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY");

// Apply license
License.Set(publicKey, privateKey);

// Show hidden slides through load options
var converter = new PptToPdfConverter("with-hidden-slides.ppt", options =>
{
    options.ShowHiddenSlides = true;
});

// Convert PPT to PDF
converter.Convert("with-hidden-slides.pdf");