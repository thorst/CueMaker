namespace CueMakerDotNet
{
    partial class Form1
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
            this.btBrowse = new System.Windows.Forms.Button();
            this.btGo = new System.Windows.Forms.Button();
            this.txPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.ckRecursive = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtOutput = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btBrowse
            // 
            this.btBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btBrowse.Location = new System.Drawing.Point(177, 56);
            this.btBrowse.Name = "btBrowse";
            this.btBrowse.Size = new System.Drawing.Size(102, 23);
            this.btBrowse.TabIndex = 3;
            this.btBrowse.Text = "Choose Directory";
            this.btBrowse.UseVisualStyleBackColor = true;
            this.btBrowse.Click += new System.EventHandler(this.btBrowse_Click);
            // 
            // btGo
            // 
            this.btGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btGo.Location = new System.Drawing.Point(312, 97);
            this.btGo.Name = "btGo";
            this.btGo.Size = new System.Drawing.Size(75, 23);
            this.btGo.TabIndex = 5;
            this.btGo.Text = "Go";
            this.btGo.UseVisualStyleBackColor = true;
            this.btGo.Click += new System.EventHandler(this.btGo_Click);
            // 
            // txPath
            // 
            this.txPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txPath.Location = new System.Drawing.Point(12, 30);
            this.txPath.Name = "txPath";
            this.txPath.Size = new System.Drawing.Size(375, 20);
            this.txPath.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Scan Directory OR File:";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(285, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Choose File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ckRecursive
            // 
            this.ckRecursive.AutoSize = true;
            this.ckRecursive.Checked = true;
            this.ckRecursive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckRecursive.Location = new System.Drawing.Point(15, 60);
            this.ckRecursive.Name = "ckRecursive";
            this.ckRecursive.Size = new System.Drawing.Size(74, 17);
            this.ckRecursive.TabIndex = 2;
            this.ckRecursive.Text = "Recursive";
            this.ckRecursive.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rtOutput);
            this.groupBox1.Location = new System.Drawing.Point(12, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 218);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Output";
            // 
            // rtOutput
            // 
            this.rtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtOutput.Location = new System.Drawing.Point(6, 19);
            this.rtOutput.Name = "rtOutput";
            this.rtOutput.Size = new System.Drawing.Size(363, 193);
            this.rtOutput.TabIndex = 0;
            this.rtOutput.TabStop = false;
            this.rtOutput.Text = "";
            this.rtOutput.WordWrap = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 368);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ckRecursive);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txPath);
            this.Controls.Add(this.btGo);
            this.Controls.Add(this.btBrowse);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CueMaker";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBrowse;
        private System.Windows.Forms.Button btGo;
        private System.Windows.Forms.TextBox txPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox ckRecursive;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtOutput;
    }
}

