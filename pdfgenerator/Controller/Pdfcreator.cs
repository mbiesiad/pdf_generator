namespace pdfgenerator
{
    class Pdfcreator
    {
        public void CreatePdfExample(string urlname, string pdfnamed)
        {
                var Renderer = new IronPdf.HtmlToPdf();
                var PDF = Renderer.RenderUrlAsPdf("" + urlname + "");
                PDF.SaveAs(pdfnamed + ".pdf"); 
                System.Diagnostics.Process.Start(pdfnamed + ".pdf");
        }
    }
}
