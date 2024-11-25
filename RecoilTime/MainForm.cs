using Newtonsoft.Json;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using YourNameSpace;

namespace RecoilControl
{
    public partial class MainForm : Form
    {
        Thread t;
        private const string ConfigDirectory = @"C:\Recoil Control Configs\";
        private const int HOTKEY_ID = 1; 

        public MainForm()
        {
            InitializeComponent();
            Directory.CreateDirectory(ConfigDirectory);
            LoadConfigList();
            Win32.RegisterGlobalHotkeys(this.Handle);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MainTimer.Start();
            t = new Thread(Recoil.Loop);
            t.Start();
            lblHorizontalRecoil.ForeColor = Color.FromArgb(51, 255, 160);
            lblHorizontalRecoil.Text = $"{numericUpDown3.Value}";
        }

        private void EnableWhore()
        {
            ChangeEnabled(false);
            Recoil.sleeptime = (int)numericUpDown2.Value;
            Recoil.verticalStrength = (int)numericUpDown1.Value;
            int horizontalRecoil = (int)numericUpDown3.Value;
            if (horizontalRecoil < 0)
            {
                Recoil.horizontalStrength = horizontalRecoil;
            }
            else
            {
                Recoil.horizontalStrength = horizontalRecoil;
            }
        }

        private void Disable()
        {
            ChangeEnabled(true);
        }

        private void ChangeEnabled(bool enabled)
        {
            numericUpDown1.Enabled = enabled;
            numericUpDown2.Enabled = enabled;
            numericUpDown3.Enabled = enabled;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (Recoil.Enabled)
            {
                lblEnabledorDisabled.Text = "Enabled";
                lblEnabledorDisabled.ForeColor = Color.FromArgb(51, 255, 160);
                EnableWhore();
            }
            else
            {
                lblEnabledorDisabled.Text = "Disabled";
                lblEnabledorDisabled.ForeColor = Color.Red;
                Disable();
            }
        }

        private void MainFormClose_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Abort();
        }

        private void LoadConfigList()
        {
            comboBoxConfigs.Items.Clear();

            if (Directory.Exists(ConfigDirectory))
            {
                var configFiles = Directory.GetFiles(ConfigDirectory, "*.json")
                                           .Select(Path.GetFileNameWithoutExtension)
                                           .ToArray();

                comboBoxConfigs.Items.AddRange(configFiles);
            }
        }

        private void btnSaveConfig_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtConfigName.Text))
            {
                CustomMessageBox.Show("Please enter a valid config name.", "Error");
                return;
            }

            string configName = txtConfigName.Text.Trim();
            string configPath = Path.Combine(@"C:\Recoil Control Configs\", configName + ".json");

            var config = new
            {
                SleepTime = (int)numericUpDown2.Value,
                Strength = (int)numericUpDown1.Value,
                HorizontalStrength = (int)numericUpDown3.Value
            };

            try
            {
                Directory.CreateDirectory(@"C:\Recoil Control Configs\");

                File.WriteAllText(configPath, JsonConvert.SerializeObject(config, Formatting.Indented));

                CustomMessageBox.Show($"Config '{configName}' saved successfully!", "Success");
                LoadConfigList();
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show($"Failed to save config. Error: {ex.Message}", "Error");
            }
        }

        private void btnLoadConfig_Click_1(object sender, EventArgs e)
        {
            if (comboBoxConfigs.SelectedItem == null)
            {
                CustomMessageBox.Show("Please select a config to load.", "Error");
                return;
            }

            string configName = comboBoxConfigs.SelectedItem.ToString();
            string configPath = Path.Combine(@"C:\Recoil Control Configs\", configName + ".json");

            if (!File.Exists(configPath))
            {
                CustomMessageBox.Show($"Config file '{configName}' not found!", "Error");
                return;
            }

            try
            {
                var config = JsonConvert.DeserializeObject<dynamic>(File.ReadAllText(configPath));
                numericUpDown2.Value = (int)config.SleepTime;
                numericUpDown1.Value = (int)config.Strength;
                numericUpDown3.Value = (int)config.HorizontalStrength;
                CustomMessageBox.Show($"Config '{configName}' loaded successfully!", "Success");
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show($"Failed to load config. Error: {ex.Message}", "Error");
            }

        }

        private void txtConfigName_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxConfigs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_Scroll(object sender, ScrollEventArgs e)
        {
            int horizontalRecoil = numericUpDown3.Value;
            Recoil.horizontalStrength = horizontalRecoil;
            lblHorizontalRecoil.ForeColor = Color.FromArgb(51, 255, 160);
            lblHorizontalRecoil.Text = $"{horizontalRecoil}";
        }

        private void lblHorizontalRecoil_Click(object sender, EventArgs e)
        {

        }
        protected override void WndProc(ref Message m)
        {
            const int WM_HOTKEY = 0x0312;

            if (m.Msg == WM_HOTKEY)
            {
                int hotkeyId = m.WParam.ToInt32();

                switch (hotkeyId)
                {
                    case Win32.HOTKEY_F2:
                        MinimizeApp();
                        break;

                    case Win32.HOTKEY_F3:
                        RestoreApp();
                        break;
                }
            }

            base.WndProc(ref m);
        }
        private void MinimizeApp()
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void RestoreApp()
        {
            this.WindowState = FormWindowState.Normal;
            this.Activate(); 
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Win32.UnregisterGlobalHotkeys(this.Handle);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
