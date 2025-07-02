using System;
using GroupDocs.Conversion.LowCode;

// Load license keys
var publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY");
var privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY");

// Apply the license
License.Set(publicKey, privateKey);

// Create a converter for the XLSX file
var converter = new XlsxToPdfConverter("cost-analysis.xlsx");

// Convert XLSX to PDF
converter.Convert("cost-analysis.pdf");