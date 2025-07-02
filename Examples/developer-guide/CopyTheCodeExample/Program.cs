using System;
using GroupDocs.Conversion.LowCode;

// Load license keys from environment variables
var publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY");
var privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY");

License.Set(publicKey, privateKey);

// Create a converter for an XLSX file
var converter = new XlsxToPdfConverter("cost-analysis.xlsx");

// Convert to PDF
converter.Convert("cost-analysis.pdf");