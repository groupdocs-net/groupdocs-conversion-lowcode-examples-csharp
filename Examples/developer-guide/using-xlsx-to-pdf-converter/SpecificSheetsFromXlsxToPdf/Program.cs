using System;
using System.Collections.Generic;
using GroupDocs.Conversion.LowCode;

// Load license keys
var publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY");
var privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY");

// Apply license
License.Set(publicKey, privateKey);

// Convert only specific sheets (first and third sheets)
var converter = new XlsxToPdfConverter("invoice-tracker.xlsx", options =>
{
    options.SheetIndexes = new List<int> { 0, 2 }; // 0-based indexing
});

// Convert XLSX to PDF
converter.Convert("specific-sheets.pdf");