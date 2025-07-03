# GroupDocs.Conversion.LowCode - C# Code Examples

This directory contains **70+ complete, runnable examples** demonstrating various features of GroupDocs.Conversion.LowCode. These examples provide practical implementations for document conversion scenarios.

## 📋 Overview

- **Package**: [GroupDocs.Conversion.LowCode](https://nuget.org/packages/GroupDocs.Conversion.LowCode)
- **Language**: C# (.NET 6.0+)
- **Docs**: https://docs.groupdocs.net/conversion/

## 📁 Directory Structure

The examples are organized to mirror the official documentation structure:

```
/
├── 📂 licensing/
│   ├── 📂 SetLicenseFromFile/
│   └── 📂 SetLicenseKeys/
├── 📂 getting-started/
│   └── 📂 quick-start-guide/
│       └── 📂 AddConversionCode/
├── 📂 developer-guide/
│   ├── 📂 loading-source-documents/
│   │   ├── 📂 LoadFromFilePath/
│   │   ├── 📂 LoadFromStream/
│   │   └── 📂 SetLoadOptions/
│   ├── 📂 saving-converted-documents/
│   │   ├── 📂 SaveToFilePath/
│   │   ├── 📂 SaveToStream/
│   │   └── 📂 SetConvertOptions/
│   ├── 📂 using-doc-to-pdf-converter/
│   │   ├── 📂 BasicExample/
│   │   ├── 📂 DocToPasswordProtectedPdf/
│   │   ├── 📂 DocToPdfaFormat/
│   │   ├── 📂 DocWithCommentsToPdfWithoutComments/
│   │   ├── 📂 DocWithTrackedChangesToPdf/
│   │   ├── 📂 ProtectedDocToPdf/
│   │   └── 📂 SpecificDocPagesToPdf/
│   ├── 📂 using-docx-to-pdf-converter/
│   │   ├── 📂 BasicExample/
│   │   ├── 📂 DocxToPasswordProtectedPdf/
│   │   ├── 📂 DocxWithCommentsToPdfWithoutComments/
│   │   ├── 📂 DocxWithTrackedChangesToPdf/
│   │   ├── 📂 ProtectedDocxToPdf/
│   │   └── 📂 SpecificDocxPagesToPdf/
│   ├── 📂 using-html-to-pdf-converter/
│   │   ├── 📂 BasicExample/
│   │   ├── 📂 HtmlToPasswordProtectedPdf/
│   │   ├── 📂 HtmlToPdfWithSpecificPdfFormat/
│   │   ├── 📂 HtmlWithCustomCssStyling/
│   │   ├── 📂 HtmlWithZoomLevel/
│   │   └── 📂 SkipExternalResourcesReferencedInHtml/
│   ├── 📂 using-pdf-to-docx-converter/
│   │   ├── 📂 BasicExample/
│   │   ├── 📂 FlattenFieldsInFormFillablePdf/
│   │   ├── 📂 PdfToDocxWithA4PageSize/
│   │   ├── 📂 PdfToPasswordProtectedDocx/
│   │   ├── 📂 PdfWithAnnotationsToDocxWithoutAnnotations/
│   │   └── 📂 ProtectedPdfToDocx/
│   ├── 📂 using-pdf-to-md-converter/
│   │   ├── 📂 BasicExample/
│   │   ├── 📂 FlattenFieldsInFormFillablePdf/
│   │   ├── 📂 PdfWithAnnotationsToMarkdownWithoutAnnotations/
│   │   ├── 📂 ProtectedPdfToMarkdown/
│   │   └── 📂 SkipImagesWhenConvertingPdfToMarkdown/
│   ├── 📂 using-pdf-to-pdfa-converter/
│   │   ├── 📂 BasicExample/
│   │   ├── 📂 FlattenFieldsInFormFillablePdf/
│   │   ├── 📂 PdfToPasswordProtectedPdfa/
│   │   ├── 📂 PdfWithAnnotationsToPdfaWithoutAnnotations/
│   │   ├── 📂 ProtectedPdfToPdfa/
│   │   └── 📂 SpecificPdfPagesToPdfa/
│   ├── 📂 using-ppt-to-pdf-converter/
│   │   ├── 📂 BasicExample/
│   │   ├── 📂 PptToPasswordProtectedPdf/
│   │   ├── 📂 PptWithHiddenSlides/
│   │   ├── 📂 PptWithPreservedDocumentStructureForAccessiblePdf/
│   │   ├── 📂 ProtectedPptToPdf/
│   │   └── 📂 SpecificPptSlidesToPdf/
│   ├── 📂 using-pptx-to-pdf-converter/
│   │   ├── 📂 BasicExample/
│   │   ├── 📂 PptxToPasswordProtectedPdf/
│   │   ├── 📂 PptxWithHiddenSlides/
│   │   ├── 📂 PreserveDocumentStructureForAccessiblePdf/
│   │   ├── 📂 ProtectedPptxToPdf/
│   │   └── 📂 SpecificPptxSlidesToPdf/
│   ├── 📂 using-xls-to-pdf-converter/
│   │   ├── 📂 BasicExample/
│   │   ├── 📂 ProtectedXlsToPdf/
│   │   ├── 📂 SpecificSheetsFromXlsToPdf/
│   │   ├── 📂 XlsToPasswordProtectedPdf/
│   │   ├── 📂 XlsToPdfWithSpecificPdfFormat/
│   │   └── 📂 XlsWithHiddenSheets/
│   ├── 📂 using-xlsx-to-pdf-converter/
│   │   ├── 📂 BasicExample/
│   │   ├── 📂 ProtectedXlsxToPdf/
│   │   ├── 📂 SpecificSheetsFromXlsxToPdf/
│   │   ├── 📂 XlsxToPasswordProtectedPdf/
│   │   ├── 📂 XlsxToPdfWithSpecificPdfFormat/
│   │   └── 📂 XlsxWithHiddenSheetsToPdf/
│   └── 📂 CopyTheCodeExample/
├── 📄 GroupDocs.Conversion.LowCode.Examples.sln
├── 📄 LICENSE
├── 📄 README.md
├── 🚀 run_all_examples.bat
├── 🚀 run_all_examples.ps1
└── 🚀 run_all_examples.sh
```

## 🎯 Example Categories

### **Getting Started**
- **Quick Start Guide**: Complete workflow example with licensing and basic conversion

### **Licensing**
- **Set License Keys**: Programmatic license setup using keys
- **Set License From File**: License setup using license file

### **Developer Guide**

#### **Document Loading**
- **Load From FilePath**: Load documents using file paths
- **Load From Stream**: Load documents using file streams
- **Set Load Options**: Configure document loading options

#### **Document Saving**
- **Save To FilePath**: Save converted documents to file paths
- **Save To Stream**: Save converted documents to streams
- **Set Convert Options**: Configure conversion options

#### **Document Converters**
- **DOC to PDF**: Convert legacy Word documents to PDF
- **DOCX to PDF**: Convert modern Word documents to PDF
- **HTML to PDF**: Convert HTML files to PDF
- **PDF to DOCX**: Convert PDF to Word documents
- **PDF to Markdown**: Convert PDF to Markdown format
- **PDF to PDF/A**: Convert PDF to archival format
- **PPT to PDF**: Convert PowerPoint presentations to PDF
- **PPTX to PDF**: Convert modern PowerPoint presentations to PDF
- **XLS to PDF**: Convert legacy Excel spreadsheets to PDF
- **XLSX to PDF**: Convert modern Excel spreadsheets to PDF

## 🚀 How to Run Code Examples

### **Prerequisites**
- **.NET 6.0 or later** installed on your system
- **Valid GroupDocs license** (trial or commercial)
- **Sample files** (automatically included with examples)

### **Setup License**

#### **Option 1: Environment Variables (Recommended)**

```bash
# Windows
set GD_PUBLIC_KEY=your-public-key
set GD_PRIVATE_KEY=your-private-key

# Linux/macOS
export GD_PUBLIC_KEY=your-public-key
export GD_PRIVATE_KEY=your-private-key
```

#### **Option 2: Direct in Code**

Edit the `Program.cs` file and replace placeholder values:
```csharp
var publicKey = "your-public-key";
var privateKey = "your-private-key";
```

### **Running Individual Examples**

1. **Navigate to any example directory:**
   ```bash
   cd generated_examples/developer-guide/using-docx-to-pdf-converter/BasicExample
   ```

2. **Run the example:**
   ```bash
   dotnet run
   ```

3. **Check the output:**
   - Look for generated files in the example directory
   - Check console output for any errors or success messages

### **Running All Examples**

Use the provided scripts to run all examples sequentially:

#### **Windows (Command Prompt)**
```bash
run_all_examples.bat
```

#### **Windows (PowerShell)**
```powershell
.\run_all_examples.ps1
```

#### **Linux/macOS**
```bash
./run_all_examples.sh
```

## 📖 Example Documentation

**Each example contains its own `README.md` file** with:
- ✅ **Example description** and purpose
- ✅ **Input and output files** specification
- ✅ **Step-by-step usage instructions**
- ✅ **Requirements** and dependencies
- ✅ **Code overview** and key features
- ✅ **Related documentation** links

**To learn more about a specific example:**
1. Navigate to the example folder
2. Open the `README.md` file
3. Follow the instructions

## 🔧 Example Features

### **What Each Example Demonstrates:**
- **License setup** and configuration
- **Document loading** from various sources
- **Conversion options** and customization
- **Output generation** to different formats
- **Error handling** and best practices
- **Real-world scenarios** and use cases

### **Supported File Formats:**
- **Input**: DOC, DOCX, HTML, PDF, PPT, PPTX, XLS, XLSX
- **Output**: PDF, DOCX, Markdown, PDF/A
- **Features**: Password protection, page selection, format options

## 🛠️ Troubleshooting

### **Common Issues:**

#### **License Error**
```
Error: Invalid license
```
**Solution**: Ensure your license keys are correctly set in environment variables or code.

#### **File Not Found**
```
Error: Could not find file 'sample.docx'
```
**Solution**: Check that sample files are present in the example directory.

#### **.NET Version**
```
Error: .NET 6.0 or later required
```
**Solution**: Install .NET 6.0 or later from [Microsoft's website](https://dotnet.microsoft.com/download).

### **Getting Help:**
- Check the example's individual `README.md` file
- Review the [official documentation](https://docs.groupdocs.net/conversion/)
- Visit the [GroupDocs support forum](https://forum.groupdocs.net/)

## 📚 Related Resources

- **[Official Documentation](https://docs.groupdocs.net/conversion/)**: Complete API reference and guides
- **[API Reference](https://reference.groupdocs.net/conversion/)**: Detailed class and method documentation
- **[Support Forum](https://forum.groupdocs.net/)**: Community support and discussions

## 📄 License

MIT - see [LICENSE](./LICENSE) for more details.

