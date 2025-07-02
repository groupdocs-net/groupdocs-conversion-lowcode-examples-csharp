using System;
using GroupDocs.Conversion.LowCode;

// Copy and paste your license keys
var publicKey = "<your public license key>";
var privateKey = "<your private license key>";

// Check if license keys are properly set
if (publicKey == "<your public license key>" || privateKey == "<your private license key>")
{
    Console.WriteLine("WARNING: This code example requires license keys to be set.");
    Console.WriteLine("Please replace the placeholder values with your actual GroupDocs.Conversion license keys.");
    Console.WriteLine("You can obtain a license from: https://purchase.groupdocs.com/");
    return;
}

// Set the license
License.Set(publicKey, privateKey);

// Create a converter for a DOCX file
var converter = new DocxToPdfConverter("business-plan.docx");

// Convert to PDF
converter.Convert("business-plan.pdf");