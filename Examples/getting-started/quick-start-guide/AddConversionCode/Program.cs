using GroupDocs.Conversion.LowCode;

// Copy and paste your license keys
var publicKey = "<your public license key>";
var privateKey = "<your private license key>";

// Set the license
License.Set(publicKey, privateKey);

// Create a converter for a DOCX file
var converter = new DocxToPdfConverter("business-plan.docx");

// Convert to PDF
converter.Convert("business-plan.pdf");
