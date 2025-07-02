using System;
using GroupDocs.Conversion.LowCode;

// Load license keys
var publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY");
var privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY");

// Apply license
License.Set(publicKey, privateKey);

// Show hidden sheets through load options
var converter = new XlsToPdfConverter("hidden-sheets.xls", options =>
{
    options.ShowHiddenSheets = true;
});

// Convert XLS to PDF
converter.Convert("with-hidden-sheets.pdf");