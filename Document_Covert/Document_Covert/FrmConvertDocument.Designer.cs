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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_DocumentConvert));
            this.Bt_Convert = new System.Windows.Forms.Button();
            this.Lv_Modificated = new System.Windows.Forms.ListView();
            this.Tb_FilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Lb_Path = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Cb_From = new System.Windows.Forms.ComboBox();
            this.Cb_To = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Ep_From = new System.Windows.Forms.ErrorProvider(this.components);
            this.Ep_To = new System.Windows.Forms.ErrorProvider(this.components);
            this.Ep_Path = new System.Windows.Forms.ErrorProvider(this.components);
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.Ep_From)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ep_To)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ep_Path)).BeginInit();
            this.SuspendLayout();
            // 
            // Bt_Convert
            // 
            this.Bt_Convert.Location = new System.Drawing.Point(280, 125);
            this.Bt_Convert.Margin = new System.Windows.Forms.Padding(2);
            this.Bt_Convert.Name = "Bt_Convert";
            this.Bt_Convert.Size = new System.Drawing.Size(65, 20);
            this.Bt_Convert.TabIndex = 4;
            this.Bt_Convert.Text = "Convert";
            this.Bt_Convert.UseVisualStyleBackColor = true;
            this.Bt_Convert.Click += new System.EventHandler(this.Bt_Convert_Click);
            // 
            // Lv_Modificated
            // 
            this.Lv_Modificated.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.Lv_Modificated.HideSelection = false;
            this.Lv_Modificated.Location = new System.Drawing.Point(16, 165);
            this.Lv_Modificated.Margin = new System.Windows.Forms.Padding(2);
            this.Lv_Modificated.Name = "Lv_Modificated";
            this.Lv_Modificated.Size = new System.Drawing.Size(336, 185);
            this.Lv_Modificated.TabIndex = 5;
            this.Lv_Modificated.UseCompatibleStateImageBehavior = false;
            this.Lv_Modificated.View = System.Windows.Forms.View.Details;
            // 
            // Tb_FilePath
            // 
            this.Tb_FilePath.Location = new System.Drawing.Point(10, 125);
            this.Tb_FilePath.Margin = new System.Windows.Forms.Padding(2);
            this.Tb_FilePath.Name = "Tb_FilePath";
            this.Tb_FilePath.Size = new System.Drawing.Size(253, 20);
            this.Tb_FilePath.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "From encrypt : ";
            // 
            // Lb_Path
            // 
            this.Lb_Path.AutoSize = true;
            this.Lb_Path.Location = new System.Drawing.Point(13, 107);
            this.Lb_Path.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lb_Path.Name = "Lb_Path";
            this.Lb_Path.Size = new System.Drawing.Size(101, 13);
            this.Lb_Path.TabIndex = 5;
            this.Lb_Path.Text = "Select the file path :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "All documents Encrypts :";
            // 
            // Cb_From
            // 
            this.Cb_From.FormattingEnabled = true;
            this.Cb_From.Items.AddRange(new object[] {
            "ANSI",
            "UTF-8",
            "UTF-8 WITH BOM"});
            this.Cb_From.Location = new System.Drawing.Point(15, 67);
            this.Cb_From.Margin = new System.Windows.Forms.Padding(2);
            this.Cb_From.Name = "Cb_From";
            this.Cb_From.Size = new System.Drawing.Size(117, 21);
            this.Cb_From.TabIndex = 1;
            // 
            // Cb_To
            // 
            this.Cb_To.FormattingEnabled = true;
            this.Cb_To.Items.AddRange(new object[] {
            "ANSI",
            "UTF-8",
            "UTF-8 WITH BOM"});
            this.Cb_To.Location = new System.Drawing.Point(228, 67);
            this.Cb_To.Margin = new System.Windows.Forms.Padding(2);
            this.Cb_To.Name = "Cb_To";
            this.Cb_To.Size = new System.Drawing.Size(117, 21);
            this.Cb_To.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "To Encrypt :";
            // 
            // Ep_From
            // 
            this.Ep_From.ContainerControl = this;
            // 
            // Ep_To
            // 
            this.Ep_To.ContainerControl = this;
            // 
            // Ep_Path
            // 
            this.Ep_Path.ContainerControl = this;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Modified Files : ";
            this.columnHeader1.Width = 333;
            // 
            // Frm_DocumentConvert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(366, 366);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cb_To);
            this.Controls.Add(this.Cb_From);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Lb_Path);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tb_FilePath);
            this.Controls.Add(this.Lv_Modificated);
            this.Controls.Add(this.Bt_Convert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Frm_DocumentConvert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Document Convert";
            ((System.ComponentModel.ISupportInitialize)(this.Ep_From)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ep_To)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ep_Path)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bt_Convert;
        private System.Windows.Forms.ListView Lv_Modificated;
        private System.Windows.Forms.TextBox Tb_FilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lb_Path;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Cb_From;
        private System.Windows.Forms.ComboBox Cb_To;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider Ep_From;
        private System.Windows.Forms.ErrorProvider Ep_To;
        private System.Windows.Forms.ErrorProvider Ep_Path;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}

