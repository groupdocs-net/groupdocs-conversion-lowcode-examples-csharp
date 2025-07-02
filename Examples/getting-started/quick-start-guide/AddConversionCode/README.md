# Quick Start Guide - Add Conversion Code

This example demonstrates the complete basic workflow for getting started with GroupDocs.Conversion.LowCode.

## Overview

This console application shows a practical implementation of the complete conversion workflow, including license setup and basic DOCX to PDF conversion.

## Purpose

This is a **Quick Start Guide** example that demonstrates:
- How to set up licensing
- How to create a converter
- How to perform a basic document conversion
- The complete minimal code needed to get started

## Files

### Input Files
- `business-plan.docx` - Source document for conversion

### Output Files
- `business-plan.pdf` - Converted output document

## Running the Example

1. Ensure you have .NET 6.0 or later installed
2. Replace the placeholder license keys in `Program.cs`:
   ```csharp
   var publicKey = "your-public-license-key";
   var privateKey = "your-private-license-key";
   ```
3. Navigate to this directory
4. Run the example:
   ```bash
   dotnet run
   ```

## Code Overview

The main workflow is in `Program.cs`. The example demonstrates the complete basic process:
- License setup with keys
- Converter creation for DOCX files
- Basic conversion to PDF
- Simple file output

## Requirements

- .NET 6.0 or later
- GroupDocs.Conversion.LowCode package
- Valid GroupDocs license keys

## Security Note

⚠️ **Important**: Replace the placeholder license keys with your actual keys. Never commit actual license keys to source control in production applications.

## Related Documentation

For more information about getting started, see the [GroupDocs.Conversion.LowCode Quick Start Guide](https://docs.groupdocs.net/conversion/getting-started/quick-start-guide/).
