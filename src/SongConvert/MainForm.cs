using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using SongConvert.Properties;

namespace SongConvert
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            easyWorshipSongPath.Text = @"C:\Users\Public\Documents\Softouch\EasyWorship\Default\Databases\Data";
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            if (easyWorshipSongPath.Text == "")
            {
                MessageBox.Show(
                    Resources.MainForm_convertButton_Click_You_must_specify_the_path_to_the_EasyWorship_song_database_);
            }
            else if (destinationPath.Text == "")
            {
                MessageBox.Show(Resources.MainForm_convertButton_Click_You_must_specify_a_valid_destination);
            }
            else
            {
                // Reset progress bar
                progressBar.Minimum = 0;
                progressBar.Maximum = 100;
                progressBar.Value = 0;

                // Initiate asynchronous processing
                backgroundWorker.RunWorkerAsync();
            }
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var worker = (BackgroundWorker) sender;

            var easyWorshipReader = new EasyWorshipReader(easyWorshipSongPath.Text);
            var songs = easyWorshipReader.GetSongs();

            var max = songs.Count;

            var songConverter = new SongConverter(destinationPath.Text);

            for (var i = 0; i < songs.Count; i++)
            {
                var song = songs[i];
                songConverter.Convert(song);

                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }

                worker.ReportProgress((i + 1)*100/max);
            }

            e.Result = max;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(string.Format(
                    Resources
                        .MainForm_backgroundWorker1_RunWorkerCompleted_Background_processing_completed_with_errors___0_,
                    e.Error.Message),
                    Resources.MainForm_backgroundWorker1_RunWorkerCompleted_ERROR_);
            }
            else if (e.Cancelled)
            {
                MessageBox.Show(
                    Resources.MainForm_backgroundWorker1_RunWorkerCompleted_Background_processing_cancelled_,
                    Resources.MainForm_backgroundWorker1_RunWorkerCompleted_Cancelled);
            }
            else
            {
                float elapsedTime = (int) e.Result*30;
                MessageBox.Show(string.Format(
                    Resources
                        .MainForm_backgroundWorker1_RunWorkerCompleted_Background_processing_completed_in_approximately__0__milliseconds_,
                    elapsedTime),
                    Resources.MainForm_backgroundWorker1_RunWorkerCompleted_Complete);
            }
        }

        private void easyWorshipBrowseButton_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Title =
                    Resources.MainForm_easyWorshipBrowseButton_Click_Please_select_the_EasyWorship_song_database_folder,
                FileName = @"Songs.DB",
                CheckFileExists = false,
                CheckPathExists = true,
                InitialDirectory = easyWorshipSongPath.Text
            };

            var dialogResult = openFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                easyWorshipSongPath.Text = Path.GetDirectoryName(openFileDialog.FileName);
            }
        }

        private void destinationBrowseButton_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Title = Resources.MainForm_destinationBrowseButton_Click_Please_select_the_destination_folder,
                FileName = @"FOLDER",
                CheckFileExists = false,
                CheckPathExists = true
            };

            var dialogResult = openFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                destinationPath.Text = Path.GetDirectoryName(openFileDialog.FileName);
            }
        }
    }
}