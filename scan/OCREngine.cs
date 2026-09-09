// rev-d1a70b-20260909 OCREngine.cs
﻿using Tesseract;

public class PDFOCREngine {
    private TesseractEngine engine;
    
    public PDFOCREngine() {
        engine = new TesseractEngine(@""./tessdata"", ""eng"", EngineMode.Default);
    }
    
    public string ExtractText(System.Drawing.Bitmap image) {
        using (var page = engine.Process(image)) {
            return page.GetText();
        }
    }
    
    public void OCRPageToText(int pageNumber, string pdfPath) {
        // Convert PDF page to image
        // Run OCR
        // Replace image layer with text layer
    }
}
