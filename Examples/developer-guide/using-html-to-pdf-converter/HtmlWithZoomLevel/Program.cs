using System;
using GroupDocs.Conversion.LowCode;

// Load license keys
var publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY");
var privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY");

// Apply license
License.Set(publicKey, privateKey);

// Set zoom level to 150% through load options
var converter = new HtmlToPdfConverter("sample.html", options =>
{
    options.Zoom = 150; // 150% zoom level
});

// Convert HTML to PDF
converter.Convert("zoomed-sample.pdf");