using System;
using GroupDocs.Conversion.LowCode;

// Load license keys
var publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY");
var privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY");

// Apply license
License.Set(publicKey, privateKey);

// Apply custom CSS styling through load options
var converter = new HtmlToPdfConverter("sample.html", options =>
{
    options.CustomCssStyle = "body { color: coral !important; }";
});

// Convert HTML to PDF
converter.Convert("styled-sample.pdf");