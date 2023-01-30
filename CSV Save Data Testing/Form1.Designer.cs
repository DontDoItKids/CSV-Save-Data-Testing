namespace CSV_Save_Data_Testing
{
    partial class Form1
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
            this.rdB1 = new System.Windows.Forms.RadioButton();
            this.rdB2 = new System.Windows.Forms.RadioButton();
            this.rdB3 = new System.Windows.Forms.RadioButton();
            this.rdB4 = new System.Windows.Forms.RadioButton();
            this.rdB5 = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // rdB1
            // 
            this.rdB1.AutoSize = true;
            this.rdB1.Location = new System.Drawing.Point(12, 12);
            this.rdB1.Name = "rdB1";
            this.rdB1.Size = new System.Drawing.Size(94, 19);
            this.rdB1.TabIndex = 0;
            this.rdB1.TabStop = true;
            this.rdB1.Text = "radioButton1";
            this.rdB1.UseVisualStyleBackColor = true;
            // 
            // rdB2
            // 
            this.rdB2.AutoSize = true;
            this.rdB2.Location = new System.Drawing.Point(12, 37);
            this.rdB2.Name = "rdB2";
            this.rdB2.Size = new System.Drawing.Size(94, 19);
            this.rdB2.TabIndex = 1;
            this.rdB2.TabStop = true;
            this.rdB2.Text = "radioButton2";
            this.rdB2.UseVisualStyleBackColor = true;
            // 
            // rdB3
            // 
            this.rdB3.AutoSize = true;
            this.rdB3.Location = new System.Drawing.Point(12, 62);
            this.rdB3.Name = "rdB3";
            this.rdB3.Size = new System.Drawing.Size(94, 19);
            this.rdB3.TabIndex = 2;
            this.rdB3.TabStop = true;
            this.rdB3.Text = "radioButton3";
            this.rdB3.UseVisualStyleBackColor = true;
            // 
            // rdB4
            // 
            this.rdB4.AutoSize = true;
            this.rdB4.Location = new System.Drawing.Point(12, 87);
            this.rdB4.Name = "rdB4";
            this.rdB4.Size = new System.Drawing.Size(94, 19);
            this.rdB4.TabIndex = 3;
            this.rdB4.TabStop = true;
            this.rdB4.Text = "radioButton4";
            this.rdB4.UseVisualStyleBackColor = true;
            // 
            // rdB5
            // 
            this.rdB5.AutoSize = true;
            this.rdB5.Location = new System.Drawing.Point(12, 112);
            this.rdB5.Name = "rdB5";
            this.rdB5.Size = new System.Drawing.Size(94, 19);
            this.rdB5.TabIndex = 4;
            this.rdB5.TabStop = true;
            this.rdB5.Text = "radioButton5";
            this.rdB5.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(668, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(668, 41);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(120, 23);
            this.btnLoad.TabIndex = 6;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(2, 406);
            this.trackBar1.Maximum = 500;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(797, 45);
            this.trackBar1.TabIndex = 7;
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.ItemHeight = 15;
            this.lstOutput.Location = new System.Drawing.Point(668, 70);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(120, 124);
            this.lstOutput.TabIndex = 8;
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(668, 200);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(120, 23);
            this.txtAdd.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(668, 229);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rdB5);
            this.Controls.Add(this.rdB4);
            this.Controls.Add(this.rdB3);
            this.Controls.Add(this.rdB2);
            this.Controls.Add(this.rdB1);
            this.Name = "Form1";
            this.Text = "Save Data Testing";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton rdB1;
        private RadioButton rdB2;
        private RadioButton rdB3;
        private RadioButton rdB4;
        private RadioButton rdB5;
        private Button btnSave;
        private Button btnLoad;
        private TrackBar trackBar1;
        private ListBox lstOutput;
        private TextBox txtAdd;
        private Button btnAdd;
    }
}