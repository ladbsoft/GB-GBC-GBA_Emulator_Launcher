using Gb_Gbc_Gba_Emulator_Launcher.Properties;
using System;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Gb_Gbc_Gba_Emulator_Launcher
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (args.Length == 0)
            {
                Application.Run(new ConfigForm());
            }
            else
            {
                string path = Path.GetDirectoryName(args[0]);
                string[] files = Directory.GetFiles(path, "*.exe");
                string defaultEmulatorPath = Settings.Default.defaultEmulatorPath;

                // VisualBoyAdvance
                if (files.Contains(path + Path.DirectorySeparatorChar + "VisualBoyAdvance.exe"))
                {
                    Process.Start(path + Path.DirectorySeparatorChar + "VisualBoyAdvance.exe", "\"" + args[0] + "\"");
                    return;
                }

                // VisualBoyAdvance-M
                if (files.Contains(path + Path.DirectorySeparatorChar + "wxvba-m.exe"))
                {
                    Process.Start(path + Path.DirectorySeparatorChar + "wxvba-m.exe", "\"" + args[0] + "\"");
                    return;
                }

                // BGB emulator
                if (files.Contains(path + Path.DirectorySeparatorChar + "bgb.exe"))
                {
                    Process.Start(path + Path.DirectorySeparatorChar + "bgb.exe", "\"" + args[0] + "\"");
                    return;
                }

                // Default Emulator
                if (defaultEmulatorPath != "")
                {
                    if (defaultEmulatorPath.EndsWith(".exe"))
                    {
                        if (File.Exists(defaultEmulatorPath))
                        {
                            Process.Start(defaultEmulatorPath, "\"" + args[0] + "\"");
                        }
                        else
                        {
                            MessageBox.Show("El emulador por defecto indicado no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("El emulador por defecto indicado no parece ser un ejecutable.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró emulador en la ruta del rom ni emulador por defecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
