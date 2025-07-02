using System;
using GroupDocs.Conversion.LowCode;

// Load license keys
var publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY");
var privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY");

// Apply the license
License.Set(publicKey, privateKey);

// Create a converter for the HTML file
var converter = new HtmlToPdfConverter("sample.html");

// Convert HTML to PDF
converter.Convert("sample.pdf");