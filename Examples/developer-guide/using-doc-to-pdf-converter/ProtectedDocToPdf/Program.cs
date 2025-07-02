using System;
using GroupDocs.Conversion.LowCode;

// Load license keys
var publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY");
var privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY");

// Apply license
License.Set(publicKey, privateKey);

// Provide password through load options
var converter = new DocToPdfConverter("protected.doc", options =>
{
    options.Password = "12345";
});

// Convert DOC to PDF
converter.Convert("not-protected.pdf");