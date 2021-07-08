namespace USB_Communication
{
    partial class GUI
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
            this.textBox_VID = new System.Windows.Forms.TextBox();
            this.textBox_PID = new System.Windows.Forms.TextBox();
            this.textBox_UsagePage = new System.Windows.Forms.TextBox();
            this.textBox_Usage = new System.Windows.Forms.TextBox();
            this.textBox_RID = new System.Windows.Forms.TextBox();
            this.textBox_Read = new System.Windows.Forms.TextBox();
            this.button_Read = new System.Windows.Forms.Button();
            this.label_PID = new System.Windows.Forms.Label();
            this.label_VID = new System.Windows.Forms.Label();
            this.gb_filter = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_RID = new System.Windows.Forms.Label();
            this.label_Usage = new System.Windows.Forms.Label();
            this.textBox_Send = new System.Windows.Forms.TextBox();
            this.label_UsagePage = new System.Windows.Forms.Label();
            this.button_Send = new System.Windows.Forms.Button();
            this.label_PIDa = new System.Windows.Forms.Label();
            this.label_VIDa = new System.Windows.Forms.Label();
            this.textBox_VIDa = new System.Windows.Forms.TextBox();
            this.textBox_PIDa = new System.Windows.Forms.TextBox();
            this.gb_filter.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_VID
            // 
            this.textBox_VID.Location = new System.Drawing.Point(124, 23);
            this.textBox_VID.Name = "textBox_VID";
            this.textBox_VID.Size = new System.Drawing.Size(100, 20);
            this.textBox_VID.TabIndex = 0;
            this.textBox_VID.TextChanged += new System.EventHandler(this.textBox_VID_TextChanged);
            // 
            // textBox_PID
            // 
            this.textBox_PID.Location = new System.Drawing.Point(124, 57);
            this.textBox_PID.Name = "textBox_PID";
            this.textBox_PID.Size = new System.Drawing.Size(100, 20);
            this.textBox_PID.TabIndex = 1;
            this.textBox_PID.TextChanged += new System.EventHandler(this.textBox_PID_TextChanged);
            // 
            // textBox_UsagePage
            // 
            this.textBox_UsagePage.Location = new System.Drawing.Point(123, 85);
            this.textBox_UsagePage.Name = "textBox_UsagePage";
            this.textBox_UsagePage.Size = new System.Drawing.Size(100, 20);
            this.textBox_UsagePage.TabIndex = 2;
            this.textBox_UsagePage.TextChanged += new System.EventHandler(this.textBox_UsagePage_TextChanged);
            // 
            // textBox_Usage
            // 
            this.textBox_Usage.Location = new System.Drawing.Point(123, 117);
            this.textBox_Usage.Name = "textBox_Usage";
            this.textBox_Usage.Size = new System.Drawing.Size(100, 20);
            this.textBox_Usage.TabIndex = 3;
            this.textBox_Usage.TextChanged += new System.EventHandler(this.textBox_Usage_TextChanged);
            // 
            // textBox_RID
            // 
            this.textBox_RID.Location = new System.Drawing.Point(123, 148);
            this.textBox_RID.Name = "textBox_RID";
            this.textBox_RID.Size = new System.Drawing.Size(100, 20);
            this.textBox_RID.TabIndex = 4;
            this.textBox_RID.TextChanged += new System.EventHandler(this.textBox_RID_TextChanged);
            // 
            // textBox_Read
            // 
            this.textBox_Read.Location = new System.Drawing.Point(15, 146);
            this.textBox_Read.Name = "textBox_Read";
            this.textBox_Read.Size = new System.Drawing.Size(209, 20);
            this.textBox_Read.TabIndex = 15;
            // 
            // button_Read
            // 
            this.button_Read.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Read.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Read.ForeColor = System.Drawing.Color.White;
            this.button_Read.Location = new System.Drawing.Point(15, 93);
            this.button_Read.Name = "button_Read";
            this.button_Read.Size = new System.Drawing.Size(209, 43);
            this.button_Read.TabIndex = 7;
            this.button_Read.Text = "Read";
            this.button_Read.UseVisualStyleBackColor = true;
            this.button_Read.Click += new System.EventHandler(this.button_Read_Click);
            // 
            // label_PID
            // 
            this.label_PID.AutoSize = true;
            this.label_PID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PID.Location = new System.Drawing.Point(12, 57);
            this.label_PID.Name = "label_PID";
            this.label_PID.Size = new System.Drawing.Size(88, 13);
            this.label_PID.TabIndex = 6;
            this.label_PID.Text = "Product ID (PID):";
            // 
            // label_VID
            // 
            this.label_VID.AutoSize = true;
            this.label_VID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label_VID.Location = new System.Drawing.Point(11, 26);
            this.label_VID.Name = "label_VID";
            this.label_VID.Size = new System.Drawing.Size(88, 13);
            this.label_VID.TabIndex = 5;
            this.label_VID.Text = "Vendor  ID (VID):";
            // 
            // gb_filter
            // 
            this.gb_filter.Controls.Add(this.button_Read);
            this.gb_filter.Controls.Add(this.label_PID);
            this.gb_filter.Controls.Add(this.label_VID);
            this.gb_filter.Controls.Add(this.textBox_Read);
            this.gb_filter.Controls.Add(this.textBox_VID);
            this.gb_filter.Controls.Add(this.textBox_PID);
            this.gb_filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.gb_filter.ForeColor = System.Drawing.Color.White;
            this.gb_filter.Location = new System.Drawing.Point(14, 14);
            this.gb_filter.Name = "gb_filter";
            this.gb_filter.Size = new System.Drawing.Size(240, 277);
            this.gb_filter.TabIndex = 17;
            this.gb_filter.TabStop = false;
            this.gb_filter.Text = "Device Description:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_RID);
            this.groupBox2.Controls.Add(this.label_Usage);
            this.groupBox2.Controls.Add(this.textBox_Send);
            this.groupBox2.Controls.Add(this.label_UsagePage);
            this.groupBox2.Controls.Add(this.button_Send);
            this.groupBox2.Controls.Add(this.label_PIDa);
            this.groupBox2.Controls.Add(this.label_VIDa);
            this.groupBox2.Controls.Add(this.textBox_VIDa);
            this.groupBox2.Controls.Add(this.textBox_PIDa);
            this.groupBox2.Controls.Add(this.textBox_UsagePage);
            this.groupBox2.Controls.Add(this.textBox_RID);
            this.groupBox2.Controls.Add(this.textBox_Usage);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(273, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 277);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Device Description:";
            // 
            // label_RID
            // 
            this.label_RID.AutoSize = true;
            this.label_RID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_RID.Location = new System.Drawing.Point(15, 151);
            this.label_RID.Name = "label_RID";
            this.label_RID.Size = new System.Drawing.Size(84, 13);
            this.label_RID.TabIndex = 14;
            this.label_RID.Text = "Report ID (RID):";
            // 
            // label_Usage
            // 
            this.label_Usage.AutoSize = true;
            this.label_Usage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Usage.Location = new System.Drawing.Point(15, 120);
            this.label_Usage.Name = "label_Usage";
            this.label_Usage.Size = new System.Drawing.Size(41, 13);
            this.label_Usage.TabIndex = 12;
            this.label_Usage.Text = "Usage:";
            // 
            // textBox_Send
            // 
            this.textBox_Send.Location = new System.Drawing.Point(16, 187);
            this.textBox_Send.Name = "textBox_Send";
            this.textBox_Send.Size = new System.Drawing.Size(207, 20);
            this.textBox_Send.TabIndex = 14;
            this.textBox_Send.TextChanged += new System.EventHandler(this.textBox_Send_TextChanged);
            // 
            // label_UsagePage
            // 
            this.label_UsagePage.AutoSize = true;
            this.label_UsagePage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_UsagePage.Location = new System.Drawing.Point(15, 88);
            this.label_UsagePage.Name = "label_UsagePage";
            this.label_UsagePage.Size = new System.Drawing.Size(69, 13);
            this.label_UsagePage.TabIndex = 10;
            this.label_UsagePage.Text = "Usage Page:";
            // 
            // button_Send
            // 
            this.button_Send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Send.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Send.ForeColor = System.Drawing.Color.White;
            this.button_Send.Location = new System.Drawing.Point(16, 219);
            this.button_Send.Name = "button_Send";
            this.button_Send.Size = new System.Drawing.Size(208, 43);
            this.button_Send.TabIndex = 7;
            this.button_Send.Text = "Send";
            this.button_Send.UseVisualStyleBackColor = true;
            this.button_Send.Click += new System.EventHandler(this.button_Send_Click);
            // 
            // label_PIDa
            // 
            this.label_PIDa.AutoSize = true;
            this.label_PIDa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PIDa.Location = new System.Drawing.Point(13, 57);
            this.label_PIDa.Name = "label_PIDa";
            this.label_PIDa.Size = new System.Drawing.Size(88, 13);
            this.label_PIDa.TabIndex = 6;
            this.label_PIDa.Text = "Product ID (PID):";
            // 
            // label_VIDa
            // 
            this.label_VIDa.AutoSize = true;
            this.label_VIDa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label_VIDa.Location = new System.Drawing.Point(12, 26);
            this.label_VIDa.Name = "label_VIDa";
            this.label_VIDa.Size = new System.Drawing.Size(88, 13);
            this.label_VIDa.TabIndex = 5;
            this.label_VIDa.Text = "Vendor  ID (VID):";
            // 
            // textBox_VIDa
            // 
            this.textBox_VIDa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.textBox_VIDa.Location = new System.Drawing.Point(123, 23);
            this.textBox_VIDa.Name = "textBox_VIDa";
            this.textBox_VIDa.Size = new System.Drawing.Size(100, 20);
            this.textBox_VIDa.TabIndex = 1;
            this.textBox_VIDa.TextChanged += new System.EventHandler(this.textBox_VIDa_TextChanged);
            // 
            // textBox_PIDa
            // 
            this.textBox_PIDa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.textBox_PIDa.Location = new System.Drawing.Point(123, 54);
            this.textBox_PIDa.Name = "textBox_PIDa";
            this.textBox_PIDa.Size = new System.Drawing.Size(100, 20);
            this.textBox_PIDa.TabIndex = 2;
            this.textBox_PIDa.TextChanged += new System.EventHandler(this.textBox_PIDa_TextChanged);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(532, 308);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gb_filter);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GUI";
            this.Text = "USB Communication";
            this.Load += new System.EventHandler(this.GUI_Load);
            this.gb_filter.ResumeLayout(false);
            this.gb_filter.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_VID;
        private System.Windows.Forms.TextBox textBox_PID;
        private System.Windows.Forms.TextBox textBox_UsagePage;
        private System.Windows.Forms.TextBox textBox_Usage;
        private System.Windows.Forms.TextBox textBox_RID;
        private System.Windows.Forms.TextBox textBox_Read;
        private System.Windows.Forms.Button button_Read;
        private System.Windows.Forms.Label label_PID;
        private System.Windows.Forms.Label label_VID;
        private System.Windows.Forms.GroupBox gb_filter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_RID;
        private System.Windows.Forms.Label label_Usage;
        private System.Windows.Forms.Label label_UsagePage;
        private System.Windows.Forms.Button button_Send;
        private System.Windows.Forms.Label label_PIDa;
        private System.Windows.Forms.Label label_VIDa;
        private System.Windows.Forms.TextBox textBox_VIDa;
        private System.Windows.Forms.TextBox textBox_PIDa;
        private System.Windows.Forms.TextBox textBox_Send;
    }
}

