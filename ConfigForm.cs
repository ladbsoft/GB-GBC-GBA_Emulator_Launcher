using Gb_Gbc_Gba_Emulator_Launcher.Properties;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace Gb_Gbc_Gba_Emulator_Launcher
{
    public partial class ConfigForm : Form
    {
        Configuration config;
        public ConfigForm()
        {
            InitializeComponent();
        }

        private void ConfigForm_Load(object sender, EventArgs e)
        {
            if (Settings.Default.defaultEmulatorPath != null)
            {
                txtDefaultEmulatorPath.Text = Settings.Default.defaultEmulatorPath;
            }
        }

        private void btnDefaultEmulatorPathChoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Programas|*.exe";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                Settings.Default.defaultEmulatorPath = fileDialog.FileName;
                Settings.Default.Save();
                txtDefaultEmulatorPath.Text = fileDialog.FileName;
            }
            fileDialog.Dispose();
        }
    }
}
