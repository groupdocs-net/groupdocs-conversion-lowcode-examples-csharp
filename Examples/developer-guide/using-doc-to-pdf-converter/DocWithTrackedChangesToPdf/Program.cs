using System;
using GroupDocs.Conversion.LowCode;

// Load license keys
var publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY");
var privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY");

// Apply license
License.Set(publicKey, privateKey);

// Hide tracked changes through load options
var converter = new DocToPdfConverter("tracked-changes.doc", options =>
{
    options.HideWordTrackedChanges = true;
});

// Convert DOC to PDF
converter.Convert("clean.pdf");