using System.Windows;
using pdfgenerator.Controller;
using pdfgenerator.Model;

namespace pdfgenerator
{
    public partial class MainWindow : Window
    {
        PdfName pdfname = new PdfName();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void bNamePdf_Click(object sender, RoutedEventArgs e)
        {
            var checkData = new CheckData();
            var setterLower = new SetterLower();
            var namepdf = string.Empty;

            namepdf = tbNamePdf.Text;
            if (checkData.Check(namepdf))
            {
                pdfname.SetNamePdf(setterLower.SetLower(namepdf));
                MessageBox.Show("PDF name created!");
            }
        }

        private void bUrl_Click(object sender, RoutedEventArgs e)
        {
            var cd = new CheckData();
            var urlname = string.Empty;
            urlname = tbUrl.Text;

            if (cd.Check(urlname))
            {
                var url = new UrlName();
                var sl = new SetterLower();
                var pdfcreator = new Pdfcreator();

                url.SetUrlPdf(sl.SetLower(urlname));

                pdfcreator.CreatePdfExample(url.GetUrlPdf(), pdfname.GetNamePdf());
                MessageBox.Show("PDF created!");
            }
        }

        private void bExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
