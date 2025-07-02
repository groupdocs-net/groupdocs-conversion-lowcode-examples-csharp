using System;
using System.Collections.Generic;
using GroupDocs.Conversion.LowCode;

// Load license keys
var publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY");
var privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY");

// Apply license
License.Set(publicKey, privateKey);

// Convert only specific sheets through load options
var converter = new XlsToPdfConverter("invoice-tracker.xls", options =>
{
    options.SheetIndexes = new List<int> { 0, 2 }; // Convert first and third sheets
});

// Convert XLS to PDF
converter.Convert("specific-sheets.pdf");