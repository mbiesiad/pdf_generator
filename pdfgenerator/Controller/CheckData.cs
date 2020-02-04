using System.Windows;

namespace pdfgenerator
{
    class CheckData
    {
        public bool Check(string text)
        {
            if (text != null)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Incorrect text!");
                return false;
            }
        }
    }
}
