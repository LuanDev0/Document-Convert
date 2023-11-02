namespace Document_Covert
{
    partial class Frm_DocumentConvert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_DocumentConvert));
            this.Bt_Convert = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Tb_FilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Lb_Path = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Cb_From = new System.Windows.Forms.ComboBox();
            this.Cb_To = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Bt_Convert
            // 
            this.Bt_Convert.Location = new System.Drawing.Point(384, 154);
            this.Bt_Convert.Name = "Bt_Convert";
            this.Bt_Convert.Size = new System.Drawing.Size(75, 23);
            this.Bt_Convert.TabIndex = 2;
            this.Bt_Convert.Text = "Convert";
            this.Bt_Convert.UseVisualStyleBackColor = true;
            this.Bt_Convert.Click += new System.EventHandler(this.Bt_Convert_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 211);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(447, 227);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Tile;
            // 
            // Tb_FilePath
            // 
            this.Tb_FilePath.Location = new System.Drawing.Point(14, 154);
            this.Tb_FilePath.Name = "Tb_FilePath";
            this.Tb_FilePath.Size = new System.Drawing.Size(336, 22);
            this.Tb_FilePath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "From encrypt : ";
            // 
            // Lb_Path
            // 
            this.Lb_Path.AutoSize = true;
            this.Lb_Path.Location = new System.Drawing.Point(17, 132);
            this.Lb_Path.Name = "Lb_Path";
            this.Lb_Path.Size = new System.Drawing.Size(121, 16);
            this.Lb_Path.TabIndex = 5;
            this.Lb_Path.Text = "Select the file path :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "All documents Encrypts :";
            // 
            // Cb_From
            // 
            this.Cb_From.FormattingEnabled = true;
            this.Cb_From.Items.AddRange(new object[] {
            "ANSI",
            "UTF-16 LE",
            "UTF-16 BE",
            "UTF-8",
            "UTF-8 WITH BOM"});
            this.Cb_From.Location = new System.Drawing.Point(20, 82);
            this.Cb_From.Name = "Cb_From";
            this.Cb_From.Size = new System.Drawing.Size(155, 24);
            this.Cb_From.TabIndex = 7;
            // 
            // Cb_To
            // 
            this.Cb_To.FormattingEnabled = true;
            this.Cb_To.Items.AddRange(new object[] {
            "ANSI",
            "UTF-16 LE",
            "UTF-16 BE",
            "UTF-8",
            "UTF-8 WITH BOM"});
            this.Cb_To.Location = new System.Drawing.Point(304, 82);
            this.Cb_To.Name = "Cb_To";
            this.Cb_To.Size = new System.Drawing.Size(155, 24);
            this.Cb_To.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "To Encrypt :";
            // 
            // Frm_DocumentConvert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(473, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cb_To);
            this.Controls.Add(this.Cb_From);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Lb_Path);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tb_FilePath);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Bt_Convert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_DocumentConvert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Document Convert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bt_Convert;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox Tb_FilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lb_Path;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Cb_From;
        private System.Windows.Forms.ComboBox Cb_To;
        private System.Windows.Forms.Label label2;
    }
}

