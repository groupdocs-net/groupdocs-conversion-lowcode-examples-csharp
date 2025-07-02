# Set License From File

This example demonstrates how to set a license from a license file for GroupDocs.Conversion.LowCode.

## Overview

This console application shows how to configure licensing for GroupDocs.Conversion.LowCode by loading license information from a license file.

## Purpose

Before using any GroupDocs.Conversion.LowCode functionality, you must set up licensing. This example shows the file-based approach using a license file.

## Files

### Input Files
- `GroupDocs.Conversion.LowCode.lic` - License file (you need to provide this)

### Output Files
- None (this example only sets up licensing)

## Code Overview

The main licensing logic is in `Program.cs`. The example demonstrates:
- License file setup using `License.Set(licensePath)`
- Proper license initialization before using conversion features

## Running the Example

1. Ensure you have .NET 6.0 or later installed
2. Place your license file in this directory with the name `GroupDocs.Conversion.LowCode.lic`
3. Navigate to this directory
4. Run the example:
   ```bash
   dotnet run
   ```

## Requirements

- .NET 6.0 or later
- GroupDocs.Conversion.LowCode package
- Valid GroupDocs license file

## Security Note

⚠️ **Important**: Never commit actual license files to source control. Use secure file storage and access controls in production applications.

## Related Documentation

For more information about licensing, see the [GroupDocs.Conversion.LowCode licensing documentation](https://docs.groupdocs.net/conversion/licensing/).
