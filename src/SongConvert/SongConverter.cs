using System.IO;
using System.Text;
using System.Windows.Forms;
using WindowsApplication1.Entities;

namespace WindowsApplication1
{
    internal class SongConverter
    {
        private readonly RichTextBox _converterBox = new RichTextBox();
        private readonly string _destinationPath;
        private readonly char[] _invalidFileNameChars;

        public SongConverter(string destinationPath)
        {
            _destinationPath = destinationPath;
            _invalidFileNameChars = Path.GetInvalidFileNameChars();
        }

        public void Convert(Song song)
        {
            string text;
            if (!string.IsNullOrWhiteSpace(song.Words) && (song.Words.Length != 1 || song.Words[0] != '\0'))
            {
                _converterBox.Rtf = song.Words;
                text = _converterBox.Text;
            }

            else
            {
                text = null;
            }

            var title = song.Title.Ungarble();

            string filename = $"{Escape(title)} ({song.SongNumber}) ({song.RecId}).txt";

            var fullPath = Path.Combine(_destinationPath, filename);

            File.WriteAllText(fullPath, text);
        }

        private string Escape(string text)
        {
            
            var stringBuilder = new StringBuilder(text);

            foreach (var c in _invalidFileNameChars)
            {
                stringBuilder.Replace(c, '_');
            }

            return stringBuilder.ToString();
        }
    }
}