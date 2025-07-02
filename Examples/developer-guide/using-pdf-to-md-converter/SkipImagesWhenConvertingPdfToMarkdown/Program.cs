using System;
using GroupDocs.Conversion.LowCode;

// Load license keys
var publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY");
var privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY");

// Apply license
License.Set(publicKey, privateKey);

// Create the converter
var converter = new PdfToMdConverter("business-plan.pdf");

        // Convert to Markdown without embedding images as base64
        converter.Convert("without-images.md", convertOptions =>
        {
            convertOptions.MarkdownOptions.ExportImagesAsBase64 = false;
        });