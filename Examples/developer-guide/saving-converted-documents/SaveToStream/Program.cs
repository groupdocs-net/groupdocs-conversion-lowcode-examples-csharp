using System;
using System.IO;
using GroupDocs.Conversion.LowCode;

// Load license keys
var publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY");
var privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY");

// Apply license
License.Set(publicKey, privateKey);

// Load DOCX file as stream
using var stream = File.OpenRead("business-plan.docx");

// Create a converter from stream
var converter = new DocxToPdfConverter(stream);

// Instantiate output file stream
using var convertedFile = File.Create("business-plan.pdf");

// Convert DOCX to PDF
converter.Convert(convertedFile);