
namespace Cargo_Fleet
{
    partial class ServiceManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceManager));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnAddServ = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVNum = new System.Windows.Forms.TextBox();
            this.cBoxServType = new System.Windows.Forms.ComboBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ServiceBox = new System.Windows.Forms.GroupBox();
            this.btnSaveServ = new System.Windows.Forms.Button();
            this.btnTasks = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ServiceBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(804, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // btnAddServ
            // 
            this.btnAddServ.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddServ.Location = new System.Drawing.Point(10, 0);
            this.btnAddServ.Name = "btnAddServ";
            this.btnAddServ.Size = new System.Drawing.Size(125, 30);
            this.btnAddServ.TabIndex = 3;
            this.btnAddServ.Text = "Add Service";
            this.btnAddServ.UseVisualStyleBackColor = true;
            this.btnAddServ.Click += new System.EventHandler(this.btnAddServ_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter the following details:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vehicle number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Service Type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Appointment date and time:";
            // 
            // txtVNum
            // 
            this.txtVNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVNum.Location = new System.Drawing.Point(271, 91);
            this.txtVNum.Name = "txtVNum";
            this.txtVNum.Size = new System.Drawing.Size(121, 24);
            this.txtVNum.TabIndex = 8;
            // 
            // cBoxServType
            // 
            this.cBoxServType.FormattingEnabled = true;
            this.cBoxServType.Location = new System.Drawing.Point(271, 133);
            this.cBoxServType.Name = "cBoxServType";
            this.cBoxServType.Size = new System.Drawing.Size(121, 21);
            this.cBoxServType.TabIndex = 9;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(271, 172);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(196, 20);
            this.dateTimePicker2.TabIndex = 10;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(271, 217);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(132, 96);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 40);
            this.label6.TabIndex = 12;
            this.label6.Text = "Description of \r\nwork to be done:";
            // 
            // ServiceBox
            // 
            this.ServiceBox.Controls.Add(this.btnSaveServ);
            this.ServiceBox.Controls.Add(this.label2);
            this.ServiceBox.Controls.Add(this.label6);
            this.ServiceBox.Controls.Add(this.richTextBox1);
            this.ServiceBox.Controls.Add(this.btnAddServ);
            this.ServiceBox.Controls.Add(this.dateTimePicker2);
            this.ServiceBox.Controls.Add(this.cBoxServType);
            this.ServiceBox.Controls.Add(this.txtVNum);
            this.ServiceBox.Controls.Add(this.label5);
            this.ServiceBox.Controls.Add(this.label4);
            this.ServiceBox.Controls.Add(this.label3);
            this.ServiceBox.Location = new System.Drawing.Point(18, 83);
            this.ServiceBox.Name = "ServiceBox";
            this.ServiceBox.Size = new System.Drawing.Size(494, 368);
            this.ServiceBox.TabIndex = 13;
            this.ServiceBox.TabStop = false;
            // 
            // btnSaveServ
            // 
            this.btnSaveServ.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveServ.Location = new System.Drawing.Point(151, 330);
            this.btnSaveServ.Name = "btnSaveServ";
            this.btnSaveServ.Size = new System.Drawing.Size(156, 32);
            this.btnSaveServ.TabIndex = 13;
            this.btnSaveServ.Text = "Save ";
            this.btnSaveServ.UseVisualStyleBackColor = true;
            this.btnSaveServ.Click += new System.EventHandler(this.btnSaveServ_Click);
            // 
            // btnTasks
            // 
            this.btnTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTasks.Location = new System.Drawing.Point(6, 45);
            this.btnTasks.Name = "btnTasks";
            this.btnTasks.Size = new System.Drawing.Size(167, 36);
            this.btnTasks.TabIndex = 14;
            this.btnTasks.Text = "Complete Tasks";
            this.btnTasks.UseVisualStyleBackColor = true;
            this.btnTasks.Click += new System.EventHandler(this.btnTasks_Click);
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Location = new System.Drawing.Point(249, 45);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(176, 34);
            this.btnReport.TabIndex = 15;
            this.btnReport.Text = "Create Reports";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnReport);
            this.groupBox2.Controls.Add(this.btnTasks);
            this.groupBox2.Location = new System.Drawing.Point(573, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(450, 124);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Shared Tasks";
            // 
            // ServiceManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1035, 491);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ServiceBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "ServiceManager";
            this.Text = "ServiceManager";
            this.ServiceBox.ResumeLayout(false);
            this.ServiceBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnAddServ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVNum;
        private System.Windows.Forms.ComboBox cBoxServType;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox ServiceBox;
        private System.Windows.Forms.Button btnSaveServ;
        private System.Windows.Forms.Button btnTasks;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}