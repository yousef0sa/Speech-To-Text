using System.Threading;
using System.Windows.Forms;

namespace Speech_To_Text.Class
{
    internal class TheText
    {
        // This method copy the text to the clipboard.
        public void CopyText(string textToCopy)
        {
            Thread thread = new Thread(() =>
            {
                Clipboard.SetText(textToCopy);
            });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }


    }
}
