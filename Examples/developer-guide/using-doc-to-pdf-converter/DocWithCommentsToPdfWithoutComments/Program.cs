using System;
using GroupDocs.Conversion.LowCode;
using GroupDocs.Conversion.Options.Load;

// Load license keys
var publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY");
var privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY");

// Apply license
License.Set(publicKey, privateKey);

// Hide comments using CommentDisplayMode
var converter = new DocToPdfConverter("with-comments.doc", options =>
{
    options.CommentDisplayMode = WordProcessingCommentDisplay.Hidden;
});

// Convert DOC to PDF
converter.Convert("no-comments.pdf");