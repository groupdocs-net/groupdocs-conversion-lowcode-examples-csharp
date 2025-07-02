# Set License Keys

This example demonstrates how to set license keys programmatically for GroupDocs.Conversion.LowCode.

## Overview

This console application shows how to configure licensing for GroupDocs.Conversion.LowCode by setting public and private license keys directly in code.

## Purpose

Before using any GroupDocs.Conversion.LowCode functionality, you must set up licensing. This example shows the programmatic approach using license keys.

## Code Overview

The main licensing logic is in `Program.cs`. The example demonstrates:
- License key setup using `License.Set(privateKey, publicKey)`
- Proper license initialization before using conversion features

## Running the Example

1. Ensure you have .NET 6.0 or later installed
2. Replace the placeholder license keys in `Program.cs`:
   ```csharp
   string privateKey = "your-private-key-here";
   string publicKey = "your-public-key-here";
   ```
3. Navigate to this directory
4. Run the example:
   ```bash
   dotnet run
   ```

## Requirements

- .NET 6.0 or later
- GroupDocs.Conversion.LowCode package
- Valid GroupDocs license keys

## Security Note

⚠️ **Important**: Never commit actual license keys to source control. Use environment variables or secure configuration management in production applications.

## Related Documentation

For more information about licensing, see the [GroupDocs.Conversion.LowCode licensing documentation](https://docs.groupdocs.net/conversion/licensing/).
