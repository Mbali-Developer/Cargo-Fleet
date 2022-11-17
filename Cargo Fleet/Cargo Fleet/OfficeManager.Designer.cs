
namespace Cargo_Fleet
{
    partial class OfficeManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OfficeManager));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chBoxVehInfo = new System.Windows.Forms.CheckBox();
            this.chBoxTrip = new System.Windows.Forms.CheckBox();
            this.chBoxService = new System.Windows.Forms.CheckBox();
            this.chBoxTimesheet = new System.Windows.Forms.CheckBox();
            this.btnReport = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OMtimer = new System.Windows.Forms.Timer(this.components);
            this.rbtnWriteReport = new System.Windows.Forms.RadioButton();
            this.rbtnTasks = new System.Windows.Forms.RadioButton();
            this.rbtnStatement = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(936, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(96, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select one Report to open";
            // 
            // chBoxVehInfo
            // 
            this.chBoxVehInfo.AutoSize = true;
            this.chBoxVehInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBoxVehInfo.Location = new System.Drawing.Point(19, 80);
            this.chBoxVehInfo.Name = "chBoxVehInfo";
            this.chBoxVehInfo.Size = new System.Drawing.Size(152, 22);
            this.chBoxVehInfo.TabIndex = 4;
            this.chBoxVehInfo.Text = "Vehicle Information";
            this.chBoxVehInfo.UseVisualStyleBackColor = true;
            // 
            // chBoxTrip
            // 
            this.chBoxTrip.AutoSize = true;
            this.chBoxTrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBoxTrip.Location = new System.Drawing.Point(19, 115);
            this.chBoxTrip.Name = "chBoxTrip";
            this.chBoxTrip.Size = new System.Drawing.Size(99, 22);
            this.chBoxTrip.TabIndex = 5;
            this.chBoxTrip.Text = "Trip/Usage";
            this.chBoxTrip.UseVisualStyleBackColor = true;
            // 
            // chBoxService
            // 
            this.chBoxService.AutoSize = true;
            this.chBoxService.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBoxService.Location = new System.Drawing.Point(19, 149);
            this.chBoxService.Name = "chBoxService";
            this.chBoxService.Size = new System.Drawing.Size(76, 22);
            this.chBoxService.TabIndex = 6;
            this.chBoxService.Text = "Service";
            this.chBoxService.UseVisualStyleBackColor = true;
            // 
            // chBoxTimesheet
            // 
            this.chBoxTimesheet.AutoSize = true;
            this.chBoxTimesheet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBoxTimesheet.Location = new System.Drawing.Point(19, 183);
            this.chBoxTimesheet.Name = "chBoxTimesheet";
            this.chBoxTimesheet.Size = new System.Drawing.Size(96, 22);
            this.chBoxTimesheet.TabIndex = 7;
            this.chBoxTimesheet.Text = "Timesheet";
            this.chBoxTimesheet.UseVisualStyleBackColor = true;
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Location = new System.Drawing.Point(135, 224);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(102, 33);
            this.btnReport.TabIndex = 8;
            this.btnReport.Text = "Open";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReport);
            this.groupBox1.Controls.Add(this.chBoxTimesheet);
            this.groupBox1.Controls.Add(this.chBoxService);
            this.groupBox1.Controls.Add(this.chBoxTrip);
            this.groupBox1.Controls.Add(this.chBoxVehInfo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(95, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 275);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Report Reviews, Monitor and Control";
            // 
            // rbtnWriteReport
            // 
            this.rbtnWriteReport.AutoSize = true;
            this.rbtnWriteReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnWriteReport.Location = new System.Drawing.Point(30, 51);
            this.rbtnWriteReport.Name = "rbtnWriteReport";
            this.rbtnWriteReport.Size = new System.Drawing.Size(137, 24);
            this.rbtnWriteReport.TabIndex = 10;
            this.rbtnWriteReport.TabStop = true;
            this.rbtnWriteReport.Text = "Write a report";
            this.rbtnWriteReport.UseVisualStyleBackColor = true;
            this.rbtnWriteReport.CheckedChanged += new System.EventHandler(this.rbtnWriteReport_CheckedChanged);
            // 
            // rbtnTasks
            // 
            this.rbtnTasks.AutoSize = true;
            this.rbtnTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnTasks.Location = new System.Drawing.Point(30, 99);
            this.rbtnTasks.Name = "rbtnTasks";
            this.rbtnTasks.Size = new System.Drawing.Size(236, 24);
            this.rbtnTasks.TabIndex = 11;
            this.rbtnTasks.TabStop = true;
            this.rbtnTasks.Text = "Shared Tasks to complete";
            this.rbtnTasks.UseVisualStyleBackColor = true;
            this.rbtnTasks.CheckedChanged += new System.EventHandler(this.rbtnTasks_CheckedChanged);
            // 
            // rbtnStatement
            // 
            this.rbtnStatement.AutoSize = true;
            this.rbtnStatement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnStatement.Location = new System.Drawing.Point(30, 147);
            this.rbtnStatement.Name = "rbtnStatement";
            this.rbtnStatement.Size = new System.Drawing.Size(222, 24);
            this.rbtnStatement.TabIndex = 12;
            this.rbtnStatement.TabStop = true;
            this.rbtnStatement.Text = "Write monthly statement";
            this.rbtnStatement.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnStatement);
            this.groupBox2.Controls.Add(this.rbtnTasks);
            this.groupBox2.Controls.Add(this.rbtnWriteReport);
            this.groupBox2.Location = new System.Drawing.Point(555, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(285, 221);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select which task to do";
            // 
            // OfficeManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1044, 462);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "OfficeManager";
            this.Text = "OfficeManager";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chBoxVehInfo;
        private System.Windows.Forms.CheckBox chBoxTrip;
        private System.Windows.Forms.CheckBox chBoxService;
        private System.Windows.Forms.CheckBox chBoxTimesheet;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer OMtimer;
        private System.Windows.Forms.RadioButton rbtnWriteReport;
        private System.Windows.Forms.RadioButton rbtnTasks;
        private System.Windows.Forms.RadioButton rbtnStatement;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}