
namespace test_myhid
{
    partial class Form_main
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
            this.richTextBox_console = new System.Windows.Forms.RichTextBox();
            this.richTextBox_out_report = new System.Windows.Forms.RichTextBox();
            this.richTextBox_in_report = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_usb_vid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_usb_pid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_usb_usage_page = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_out_loop_count = new System.Windows.Forms.TextBox();
            this.button_send = new System.Windows.Forms.Button();
            this.button_read = new System.Windows.Forms.Button();
            this.label_byte_count_out = new System.Windows.Forms.Label();
            this.label_byte_count_in = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox_read_after_write = new System.Windows.Forms.CheckBox();
            this.button_test = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Label_usb_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox_console
            // 
            this.richTextBox_console.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.richTextBox_console.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_console.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.richTextBox_console.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.richTextBox_console.Location = new System.Drawing.Point(12, 363);
            this.richTextBox_console.Name = "richTextBox_console";
            this.richTextBox_console.Size = new System.Drawing.Size(776, 209);
            this.richTextBox_console.TabIndex = 29;
            this.richTextBox_console.Text = "";
            // 
            // richTextBox_out_report
            // 
            this.richTextBox_out_report.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.richTextBox_out_report.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_out_report.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.richTextBox_out_report.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.richTextBox_out_report.Location = new System.Drawing.Point(172, 32);
            this.richTextBox_out_report.Name = "richTextBox_out_report";
            this.richTextBox_out_report.Size = new System.Drawing.Size(616, 171);
            this.richTextBox_out_report.TabIndex = 29;
            this.richTextBox_out_report.Text = "*IDN?\\n";
            // 
            // richTextBox_in_report
            // 
            this.richTextBox_in_report.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.richTextBox_in_report.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_in_report.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.richTextBox_in_report.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.richTextBox_in_report.Location = new System.Drawing.Point(172, 229);
            this.richTextBox_in_report.Name = "richTextBox_in_report";
            this.richTextBox_in_report.Size = new System.Drawing.Size(616, 128);
            this.richTextBox_in_report.TabIndex = 29;
            this.richTextBox_in_report.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(170, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 12);
            this.label2.TabIndex = 30;
            this.label2.Text = "IN Report";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(170, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 12);
            this.label1.TabIndex = 30;
            this.label1.Text = "OUT Report";
            // 
            // textBox_usb_vid
            // 
            this.textBox_usb_vid.Location = new System.Drawing.Point(101, 13);
            this.textBox_usb_vid.Name = "textBox_usb_vid";
            this.textBox_usb_vid.Size = new System.Drawing.Size(55, 22);
            this.textBox_usb_vid.TabIndex = 31;
            this.textBox_usb_vid.Text = "0483";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(49, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 12);
            this.label3.TabIndex = 30;
            this.label3.Text = "VID  0X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(47, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 12);
            this.label4.TabIndex = 30;
            this.label4.Text = "PID  0X";
            // 
            // textBox_usb_pid
            // 
            this.textBox_usb_pid.Location = new System.Drawing.Point(101, 41);
            this.textBox_usb_pid.Name = "textBox_usb_pid";
            this.textBox_usb_pid.Size = new System.Drawing.Size(55, 22);
            this.textBox_usb_pid.TabIndex = 31;
            this.textBox_usb_pid.Text = "5750";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(7, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 12);
            this.label5.TabIndex = 30;
            this.label5.Text = "Usage Page  0X";
            // 
            // textBox_usb_usage_page
            // 
            this.textBox_usb_usage_page.Location = new System.Drawing.Point(101, 69);
            this.textBox_usb_usage_page.Name = "textBox_usb_usage_page";
            this.textBox_usb_usage_page.Size = new System.Drawing.Size(55, 22);
            this.textBox_usb_usage_page.TabIndex = 31;
            this.textBox_usb_usage_page.Text = "01";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(44, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 12);
            this.label6.TabIndex = 30;
            this.label6.Text = "Page  0X";
            // 
            // textBox_out_loop_count
            // 
            this.textBox_out_loop_count.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textBox_out_loop_count.Location = new System.Drawing.Point(98, 195);
            this.textBox_out_loop_count.Name = "textBox_out_loop_count";
            this.textBox_out_loop_count.Size = new System.Drawing.Size(55, 22);
            this.textBox_out_loop_count.TabIndex = 31;
            this.textBox_out_loop_count.Text = "1";
            // 
            // button_send
            // 
            this.button_send.Location = new System.Drawing.Point(9, 142);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(144, 47);
            this.button_send.TabIndex = 32;
            this.button_send.Text = "Send";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // button_read
            // 
            this.button_read.Location = new System.Drawing.Point(12, 257);
            this.button_read.Name = "button_read";
            this.button_read.Size = new System.Drawing.Size(144, 47);
            this.button_read.TabIndex = 32;
            this.button_read.Text = "Read";
            this.button_read.UseVisualStyleBackColor = true;
            this.button_read.Click += new System.EventHandler(this.button_read_Click);
            // 
            // label_byte_count_out
            // 
            this.label_byte_count_out.AutoSize = true;
            this.label_byte_count_out.Location = new System.Drawing.Point(264, 16);
            this.label_byte_count_out.Name = "label_byte_count_out";
            this.label_byte_count_out.Size = new System.Drawing.Size(49, 12);
            this.label_byte_count_out.TabIndex = 33;
            this.label_byte_count_out.Text = "count = 0";
            // 
            // label_byte_count_in
            // 
            this.label_byte_count_in.AutoSize = true;
            this.label_byte_count_in.Location = new System.Drawing.Point(264, 213);
            this.label_byte_count_in.Name = "label_byte_count_in";
            this.label_byte_count_in.Size = new System.Drawing.Size(49, 12);
            this.label_byte_count_in.TabIndex = 33;
            this.label_byte_count_in.Text = "count = 0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 12);
            this.label7.TabIndex = 33;
            this.label7.Text = "Repeat Count";
            // 
            // checkBox_read_after_write
            // 
            this.checkBox_read_after_write.AutoSize = true;
            this.checkBox_read_after_write.Location = new System.Drawing.Point(13, 229);
            this.checkBox_read_after_write.Name = "checkBox_read_after_write";
            this.checkBox_read_after_write.Size = new System.Drawing.Size(101, 16);
            this.checkBox_read_after_write.TabIndex = 34;
            this.checkBox_read_after_write.Text = "Read after Write";
            this.checkBox_read_after_write.UseVisualStyleBackColor = true;
            // 
            // button_test
            // 
            this.button_test.Location = new System.Drawing.Point(12, 310);
            this.button_test.Name = "button_test";
            this.button_test.Size = new System.Drawing.Size(144, 47);
            this.button_test.TabIndex = 32;
            this.button_test.Text = "Test";
            this.button_test.UseVisualStyleBackColor = true;
            this.button_test.Click += new System.EventHandler(this.button_test_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Label_usb_status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 575);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 35;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Label_usb_status
            // 
            this.Label_usb_status.Name = "Label_usb_status";
            this.Label_usb_status.Size = new System.Drawing.Size(30, 17);
            this.Label_usb_status.Text = "USB";
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 597);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.checkBox_read_after_write);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label_byte_count_in);
            this.Controls.Add(this.label_byte_count_out);
            this.Controls.Add(this.button_test);
            this.Controls.Add(this.button_read);
            this.Controls.Add(this.button_send);
            this.Controls.Add(this.textBox_out_loop_count);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_usb_usage_page);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_usb_pid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_usb_vid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox_in_report);
            this.Controls.Add(this.richTextBox_out_report);
            this.Controls.Add(this.richTextBox_console);
            this.Name = "Form_main";
            this.Text = "HID Test";
            this.Load += new System.EventHandler(this.Form_main_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_console;
        private System.Windows.Forms.RichTextBox richTextBox_out_report;
        private System.Windows.Forms.RichTextBox richTextBox_in_report;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_usb_vid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_usb_pid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_usb_usage_page;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_out_loop_count;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.Button button_read;
        private System.Windows.Forms.Label label_byte_count_out;
        private System.Windows.Forms.Label label_byte_count_in;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox_read_after_write;
        private System.Windows.Forms.Button button_test;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Label_usb_status;
    }
}

