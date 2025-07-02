using System;
using GroupDocs.Conversion.LowCode;

// Load license keys
var publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY");
var privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY");

// Apply license
License.Set(publicKey, privateKey);

// Skip external resources through load options
var converter = new HtmlToPdfConverter("with-image.html", options =>
{
    options.SkipExternalResources = true;
});

// Convert HTML to PDF
converter.Convert("without-image.pdf");