using System.Diagnostics;

namespace flac2m4a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInputFolder_Click(object sender, EventArgs e)
        {
            if (fbdInputPath.ShowDialog() == DialogResult.OK)
            {
                txtInputPath.Text = fbdInputPath.SelectedPath;
            }
        }

        private void btnOutputFolder_Click(object sender, EventArgs e)
        {
            if (fbdOutputPath.ShowDialog() == DialogResult.OK)
            {
                txtOutputPath.Text = fbdOutputPath.SelectedPath;
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string inputPath = txtInputPath.Text;
            string outputPath = txtOutputPath.Text;

            Directory.CreateDirectory(outputPath);

            if (!Directory.Exists(inputPath))
            {
                MessageBox.Show("Hey! That's not a valid path.", "Invalid Path", default, MessageBoxIcon.Error);
                return;
            }

            string[] files = Directory.GetFiles(inputPath);
            List<string> paths = new List<string>();
            paths.AddRange(files);

            for (int i = paths.Count - 1; i >= 0; i--)
            {
                if (!paths[i].EndsWith(".flac"))
                {
                    paths.RemoveAt(i);
                }
            }

            if (paths.Count == 0)
            {
                MessageBox.Show("Hey! There are no .flac files here.", "No .flac Files", default, MessageBoxIcon.Error);
                return;
            }

            prgConversion.Maximum = paths.Count;
            prgConversion.Value = 1;

            foreach (string path in paths)
            {
                string outputFileName = Path.GetFileName(path);
                outputFileName = outputFileName.Substring(0, outputFileName.Length - 5);

                string command = @$"ffmpeg -y -i ""{path}"" -c:a aac -b:a 320k -vn ""{outputPath}\{outputFileName}.m4a""";

                RunCommand(command);

                if (prgConversion.Value < prgConversion.Maximum)
                {
                    prgConversion.Value++;
                }
            }

            MessageBox.Show("The conversion was successful!", "Conversion Success", default, MessageBoxIcon.Asterisk);

        }

        static void RunCommand(string command)
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = $"/k {command}",
                RedirectStandardInput = true,
                CreateNoWindow = true,
            };

            Process process = new Process { StartInfo = processStartInfo };
            process.Start();

            process.StandardInput.WriteLine(command);
            process.StandardInput.Flush();
            process.StandardInput.Close();

            process.WaitForExit();
        }

        private void chkGenDirectory_CheckedChanged(object sender, EventArgs e)
        {
            string previousDirectory = txtOutputPath.Text;

            if (chkGenDirectory.Checked)
            {
                if (txtInputPath.Text != "")
                {
                    txtOutputPath.Text = $@"{txtInputPath.Text} - M4A";
                    txtOutputPath.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Hey! There is no input path selected.", "Invalid Input Path", default, MessageBoxIcon.Error);
                    chkGenDirectory.Checked = false;
                }
            }
            else
            {
                txtOutputPath.Text = previousDirectory;
            }
        }
    }
}