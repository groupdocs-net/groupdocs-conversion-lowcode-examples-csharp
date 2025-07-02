using System;
using GroupDocs.Conversion.LowCode;

// Load license keys
var publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY");
var privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY");

// Apply license
License.Set(publicKey, privateKey);

// Include hidden sheets in conversion
var converter = new XlsxToPdfConverter("hidden-worksheets.xlsx", options =>
{
    options.ShowHiddenSheets = true;
});

// Convert XLSX to PDF
converter.Convert("with-hidden-sheets.pdf");