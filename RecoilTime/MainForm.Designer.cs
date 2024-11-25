namespace RecoilControl
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            this.numericUpDown1 = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.numericUpDown2 = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblEnabledorDisabled = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.MainFormboarderless = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveConfig = new Guna.UI2.WinForms.Guna2Button();
            this.btnLoadConfig = new Guna.UI2.WinForms.Guna2Button();
            this.txtConfigName = new Guna.UI2.WinForms.Guna2TextBox();
            this.comboBoxConfigs = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.numericUpDown3 = new Guna.UI2.WinForms.Guna2TrackBar();
            this.lblHorizontalRecoil = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTimer
            // 
            this.MainTimer.Interval = 30;
            this.MainTimer.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.Transparent;
            this.numericUpDown1.BorderThickness = 0;
            this.numericUpDown1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numericUpDown1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.numericUpDown1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.numericUpDown1.Location = new System.Drawing.Point(89, 10);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(71, 25);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.BackColor = System.Drawing.Color.Transparent;
            this.numericUpDown2.BorderThickness = 0;
            this.numericUpDown2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numericUpDown2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.numericUpDown2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.numericUpDown2.Location = new System.Drawing.Point(89, 51);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(71, 25);
            this.numericUpDown2.TabIndex = 6;
            this.numericUpDown2.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(8, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Strength:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(8, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Sleep:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(8, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "F1 / Insert";
            // 
            // lblEnabledorDisabled
            // 
            this.lblEnabledorDisabled.AutoSize = true;
            this.lblEnabledorDisabled.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnabledorDisabled.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblEnabledorDisabled.Location = new System.Drawing.Point(8, 45);
            this.lblEnabledorDisabled.Name = "lblEnabledorDisabled";
            this.lblEnabledorDisabled.Size = new System.Drawing.Size(57, 16);
            this.lblEnabledorDisabled.TabIndex = 13;
            this.lblEnabledorDisabled.Text = "Status";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.guna2Panel1.BorderRadius = 6;
            this.guna2Panel1.BorderThickness = 3;
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.numericUpDown1);
            this.guna2Panel1.Controls.Add(this.numericUpDown2);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.guna2Panel1.Location = new System.Drawing.Point(16, 60);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(173, 89);
            this.guna2Panel1.TabIndex = 14;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.guna2Panel2.BorderRadius = 6;
            this.guna2Panel2.BorderThickness = 3;
            this.guna2Panel2.Controls.Add(this.label5);
            this.guna2Panel2.Controls.Add(this.lblEnabledorDisabled);
            this.guna2Panel2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.guna2Panel2.Location = new System.Drawing.Point(195, 60);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(104, 89);
            this.guna2Panel2.TabIndex = 15;
            // 
            // MainFormboarderless
            // 
            this.MainFormboarderless.AnimateWindow = true;
            this.MainFormboarderless.AnimationInterval = 750;
            this.MainFormboarderless.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_CENTER;
            this.MainFormboarderless.BorderRadius = 60;
            this.MainFormboarderless.ContainerControl = this;
            this.MainFormboarderless.DockForm = false;
            this.MainFormboarderless.DockIndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.MainFormboarderless.DockIndicatorTransparencyValue = 0.8D;
            this.MainFormboarderless.DragEndTransparencyValue = 0.8D;
            this.MainFormboarderless.DragStartTransparencyValue = 0.8D;
            this.MainFormboarderless.ResizeForm = false;
            this.MainFormboarderless.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.MainFormboarderless.TransparentWhileDrag = true;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.guna2ControlBox1.BorderRadius = 6;
            this.guna2ControlBox1.BorderThickness = 2;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(275, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(28, 28);
            this.guna2ControlBox1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 40);
            this.label1.TabIndex = 14;
            this.label1.Text = "Recoil Control";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSaveConfig
            // 
            this.btnSaveConfig.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.btnSaveConfig.BorderRadius = 6;
            this.btnSaveConfig.BorderThickness = 3;
            this.btnSaveConfig.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.btnSaveConfig.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveConfig.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveConfig.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaveConfig.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSaveConfig.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnSaveConfig.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSaveConfig.ForeColor = System.Drawing.Color.White;
            this.btnSaveConfig.Location = new System.Drawing.Point(8, 9);
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.Size = new System.Drawing.Size(100, 36);
            this.btnSaveConfig.TabIndex = 17;
            this.btnSaveConfig.Text = "Save";
            this.btnSaveConfig.Click += new System.EventHandler(this.btnSaveConfig_Click_1);
            // 
            // btnLoadConfig
            // 
            this.btnLoadConfig.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.btnLoadConfig.BorderRadius = 6;
            this.btnLoadConfig.BorderThickness = 3;
            this.btnLoadConfig.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.btnLoadConfig.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLoadConfig.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLoadConfig.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLoadConfig.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLoadConfig.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnLoadConfig.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLoadConfig.ForeColor = System.Drawing.Color.White;
            this.btnLoadConfig.Location = new System.Drawing.Point(8, 53);
            this.btnLoadConfig.Name = "btnLoadConfig";
            this.btnLoadConfig.Size = new System.Drawing.Size(100, 36);
            this.btnLoadConfig.TabIndex = 18;
            this.btnLoadConfig.Text = "Load";
            this.btnLoadConfig.Click += new System.EventHandler(this.btnLoadConfig_Click_1);
            // 
            // txtConfigName
            // 
            this.txtConfigName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.txtConfigName.BorderThickness = 0;
            this.txtConfigName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfigName.DefaultText = "";
            this.txtConfigName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtConfigName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtConfigName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConfigName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConfigName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.txtConfigName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConfigName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtConfigName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.txtConfigName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConfigName.Location = new System.Drawing.Point(116, 9);
            this.txtConfigName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtConfigName.Name = "txtConfigName";
            this.txtConfigName.PasswordChar = '\0';
            this.txtConfigName.PlaceholderText = "";
            this.txtConfigName.SelectedText = "";
            this.txtConfigName.Size = new System.Drawing.Size(150, 36);
            this.txtConfigName.TabIndex = 19;
            this.txtConfigName.TextChanged += new System.EventHandler(this.txtConfigName_TextChanged);
            // 
            // comboBoxConfigs
            // 
            this.comboBoxConfigs.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxConfigs.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.comboBoxConfigs.BorderThickness = 0;
            this.comboBoxConfigs.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxConfigs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxConfigs.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.comboBoxConfigs.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxConfigs.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxConfigs.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.comboBoxConfigs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.comboBoxConfigs.ItemHeight = 30;
            this.comboBoxConfigs.Location = new System.Drawing.Point(116, 53);
            this.comboBoxConfigs.Name = "comboBoxConfigs";
            this.comboBoxConfigs.Size = new System.Drawing.Size(150, 36);
            this.comboBoxConfigs.TabIndex = 20;
            this.comboBoxConfigs.SelectedIndexChanged += new System.EventHandler(this.comboBoxConfigs_SelectedIndexChanged);
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.guna2Panel3.BorderRadius = 6;
            this.guna2Panel3.BorderThickness = 3;
            this.guna2Panel3.Controls.Add(this.txtConfigName);
            this.guna2Panel3.Controls.Add(this.comboBoxConfigs);
            this.guna2Panel3.Controls.Add(this.btnLoadConfig);
            this.guna2Panel3.Controls.Add(this.btnSaveConfig);
            this.guna2Panel3.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.guna2Panel3.Location = new System.Drawing.Point(16, 184);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(285, 102);
            this.guna2Panel3.TabIndex = 21;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.numericUpDown3.Location = new System.Drawing.Point(16, 155);
            this.numericUpDown3.Maximum = 10;
            this.numericUpDown3.Minimum = -10;
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(246, 23);
            this.numericUpDown3.TabIndex = 22;
            this.numericUpDown3.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.numericUpDown3.Value = 0;
            this.numericUpDown3.Scroll += new System.Windows.Forms.ScrollEventHandler(this.numericUpDown3_Scroll);
            // 
            // lblHorizontalRecoil
            // 
            this.lblHorizontalRecoil.AutoSize = true;
            this.lblHorizontalRecoil.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorizontalRecoil.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblHorizontalRecoil.Location = new System.Drawing.Point(270, 159);
            this.lblHorizontalRecoil.Name = "lblHorizontalRecoil";
            this.lblHorizontalRecoil.Size = new System.Drawing.Size(25, 16);
            this.lblHorizontalRecoil.TabIndex = 14;
            this.lblHorizontalRecoil.Text = "10";
            this.lblHorizontalRecoil.Click += new System.EventHandler(this.lblHorizontalRecoil_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(315, 306);
            this.Controls.Add(this.lblHorizontalRecoil);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RecoilControl";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormClose_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer MainTimer;
        private Guna.UI2.WinForms.Guna2NumericUpDown numericUpDown1;
        private Guna.UI2.WinForms.Guna2NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblEnabledorDisabled;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2BorderlessForm MainFormboarderless;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxConfigs;
        private Guna.UI2.WinForms.Guna2TextBox txtConfigName;
        private Guna.UI2.WinForms.Guna2Button btnLoadConfig;
        private Guna.UI2.WinForms.Guna2Button btnSaveConfig;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2TrackBar numericUpDown3;
        private System.Windows.Forms.Label lblHorizontalRecoil;
    }
}

