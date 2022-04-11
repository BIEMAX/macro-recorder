namespace macro_recorder
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.recordStart = new System.Windows.Forms.Button();
            this.recordStopButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.curXYLabel = new System.Windows.Forms.Label();
            this.txtKeyStop = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKeyStart = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMacroLog = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnPlayMacro = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // recordStart
            // 
            this.recordStart.Image = global::macro_recorder.Properties.Resources.icons8_último_16;
            this.recordStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.recordStart.Location = new System.Drawing.Point(19, 56);
            this.recordStart.Name = "recordStart";
            this.recordStart.Size = new System.Drawing.Size(101, 23);
            this.recordStart.TabIndex = 0;
            this.recordStart.Text = "Start recorder";
            this.recordStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.recordStart.UseVisualStyleBackColor = true;
            this.recordStart.Click += new System.EventHandler(this.recordStartButton_Click);
            // 
            // recordStopButton
            // 
            this.recordStopButton.Image = global::macro_recorder.Properties.Resources.icons8_parar_16;
            this.recordStopButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.recordStopButton.Location = new System.Drawing.Point(19, 100);
            this.recordStopButton.Name = "recordStopButton";
            this.recordStopButton.Size = new System.Drawing.Size(101, 23);
            this.recordStopButton.TabIndex = 1;
            this.recordStopButton.Text = "Stop recorder";
            this.recordStopButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.recordStopButton.UseVisualStyleBackColor = true;
            this.recordStopButton.Click += new System.EventHandler(this.recordStopButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.curXYLabel);
            this.groupBox1.Controls.Add(this.txtKeyStop);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtKeyStart);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.recordStart);
            this.groupBox1.Controls.Add(this.recordStopButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 129);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Macro recorder";
            // 
            // curXYLabel
            // 
            this.curXYLabel.AutoSize = true;
            this.curXYLabel.Location = new System.Drawing.Point(19, 19);
            this.curXYLabel.Name = "curXYLabel";
            this.curXYLabel.Size = new System.Drawing.Size(120, 15);
            this.curXYLabel.TabIndex = 6;
            this.curXYLabel.Text = "Current Mouse Point:";
            // 
            // txtKeyStop
            // 
            this.txtKeyStop.Location = new System.Drawing.Point(139, 100);
            this.txtKeyStop.Name = "txtKeyStop";
            this.txtKeyStop.Size = new System.Drawing.Size(165, 23);
            this.txtKeyStop.TabIndex = 5;
            this.txtKeyStop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtKeyStop.TextChanged += new System.EventHandler(this.txtKeyStop_TextChanged);
            this.txtKeyStop.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKeyStop_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Shortcut to stop recording";
            // 
            // txtKeyStart
            // 
            this.txtKeyStart.Location = new System.Drawing.Point(139, 56);
            this.txtKeyStart.Name = "txtKeyStart";
            this.txtKeyStart.Size = new System.Drawing.Size(165, 23);
            this.txtKeyStart.TabIndex = 3;
            this.txtKeyStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtKeyStart.TextChanged += new System.EventHandler(this.txtKeyStart_TextChanged);
            this.txtKeyStart.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKeyStart_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Shortcut to start recording";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.btnMacroLog);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.numericUpDown2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.btnPlayMacro);
            this.groupBox2.Location = new System.Drawing.Point(12, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 202);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Playback Macro";
            // 
            // btnMacroLog
            // 
            this.btnMacroLog.Enabled = false;
            this.btnMacroLog.Location = new System.Drawing.Point(19, 102);
            this.btnMacroLog.Name = "btnMacroLog";
            this.btnMacroLog.Size = new System.Drawing.Size(101, 23);
            this.btnMacroLog.TabIndex = 5;
            this.btnMacroLog.Text = "View macro log";
            this.btnMacroLog.UseVisualStyleBackColor = true;
            this.btnMacroLog.Click += new System.EventHandler(this.btnMacroLog_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Times repeated";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Enabled = false;
            this.numericUpDown2.Location = new System.Drawing.Point(19, 52);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(90, 23);
            this.numericUpDown2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Times to repeat";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(139, 52);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(90, 23);
            this.numericUpDown1.TabIndex = 1;
            // 
            // btnPlayMacro
            // 
            this.btnPlayMacro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPlayMacro.Image = global::macro_recorder.Properties.Resources.icons8_próximo_16;
            this.btnPlayMacro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlayMacro.Location = new System.Drawing.Point(19, 173);
            this.btnPlayMacro.Name = "btnPlayMacro";
            this.btnPlayMacro.Size = new System.Drawing.Size(101, 23);
            this.btnPlayMacro.TabIndex = 0;
            this.btnPlayMacro.Text = "Play Back";
            this.btnPlayMacro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPlayMacro.UseVisualStyleBackColor = true;
            this.btnPlayMacro.Click += new System.EventHandler(this.btnPlayMacro_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Macro Recorder";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button recordStart;
        private Button recordStopButton;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private NumericUpDown numericUpDown1;
        private Button button1;
        private Label label2;
        private NumericUpDown numericUpDown2;
        private TextBox txtKeyStop;
        private Label label4;
        private TextBox txtKeyStart;
        private Label label3;
        private Button btnMacroLog;
        private Label curXYLabel;
        private Button btnPlayMacro;
    }
}