
namespace Cargo_Fleet
{
    partial class TripUsage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TripUsage));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DTPappointment = new System.Windows.Forms.DateTimePicker();
            this.txtVehNo = new System.Windows.Forms.TextBox();
            this.txtProCode = new System.Windows.Forms.TextBox();
            this.txtDescrip = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtdestination = new System.Windows.Forms.TextBox();
            this.txtfuel = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.rbtnSchedule = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnStatement = new System.Windows.Forms.Button();
            this.btnOpTask = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtVehNum = new System.Windows.Forms.TextBox();
            this.txtPreDestination = new System.Windows.Forms.TextBox();
            this.txtProcCode = new System.Windows.Forms.TextBox();
            this.cBoxYesA = new System.Windows.Forms.CheckBox();
            this.cBoxNoA = new System.Windows.Forms.CheckBox();
            this.btnReport = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(817, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(174, 494);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(181, 31);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add trip on schedule";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vehicle number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "Appointment time\r\n and date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Procedure Code:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Description of trip:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(280, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Select the configuration and body type";
            // 
            // DTPappointment
            // 
            this.DTPappointment.Location = new System.Drawing.Point(234, 69);
            this.DTPappointment.Name = "DTPappointment";
            this.DTPappointment.Size = new System.Drawing.Size(206, 20);
            this.DTPappointment.TabIndex = 7;
            // 
            // txtVehNo
            // 
            this.txtVehNo.Location = new System.Drawing.Point(234, 19);
            this.txtVehNo.Name = "txtVehNo";
            this.txtVehNo.Size = new System.Drawing.Size(121, 20);
            this.txtVehNo.TabIndex = 8;
            // 
            // txtProCode
            // 
            this.txtProCode.Location = new System.Drawing.Point(234, 120);
            this.txtProCode.Name = "txtProCode";
            this.txtProCode.Size = new System.Drawing.Size(121, 20);
            this.txtProCode.TabIndex = 9;
            // 
            // txtDescrip
            // 
            this.txtDescrip.Location = new System.Drawing.Point(234, 155);
            this.txtDescrip.Name = "txtDescrip";
            this.txtDescrip.Size = new System.Drawing.Size(121, 20);
            this.txtDescrip.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Configuration:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(36, 277);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Body type:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(234, 246);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 15;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(234, 279);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 323);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Enter distance details";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(37, 364);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(153, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Destination (in kms):";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(37, 406);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(155, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "Fuel usage (in liters):";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(37, 449);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(180, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "Time travelled (in hours):";
            // 
            // txtdestination
            // 
            this.txtdestination.Location = new System.Drawing.Point(234, 364);
            this.txtdestination.Name = "txtdestination";
            this.txtdestination.Size = new System.Drawing.Size(121, 20);
            this.txtdestination.TabIndex = 21;
            // 
            // txtfuel
            // 
            this.txtfuel.Location = new System.Drawing.Point(234, 406);
            this.txtfuel.Name = "txtfuel";
            this.txtfuel.Size = new System.Drawing.Size(121, 20);
            this.txtfuel.TabIndex = 22;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(234, 451);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(121, 20);
            this.txtTime.TabIndex = 23;
            // 
            // rbtnSchedule
            // 
            this.rbtnSchedule.AutoSize = true;
            this.rbtnSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnSchedule.Location = new System.Drawing.Point(12, 62);
            this.rbtnSchedule.Name = "rbtnSchedule";
            this.rbtnSchedule.Size = new System.Drawing.Size(208, 24);
            this.rbtnSchedule.TabIndex = 24;
            this.rbtnSchedule.TabStop = true;
            this.rbtnSchedule.Text = "Schedule a vehicle trip";
            this.rbtnSchedule.UseVisualStyleBackColor = true;
            this.rbtnSchedule.CheckedChanged += new System.EventHandler(this.rbtnSchedule_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTime);
            this.groupBox1.Controls.Add(this.txtfuel);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtdestination);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtDescrip);
            this.groupBox1.Controls.Add(this.txtProCode);
            this.groupBox1.Controls.Add(this.txtVehNo);
            this.groupBox1.Controls.Add(this.DTPappointment);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(40, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 531);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnStatement);
            this.groupBox2.Controls.Add(this.btnOpTask);
            this.groupBox2.Location = new System.Drawing.Point(599, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(418, 137);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Shared Tasks";
            // 
            // btnStatement
            // 
            this.btnStatement.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatement.Location = new System.Drawing.Point(190, 42);
            this.btnStatement.Name = "btnStatement";
            this.btnStatement.Size = new System.Drawing.Size(198, 40);
            this.btnStatement.TabIndex = 1;
            this.btnStatement.Text = "Write Monthly Statement";
            this.btnStatement.UseVisualStyleBackColor = true;
            // 
            // btnOpTask
            // 
            this.btnOpTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpTask.Location = new System.Drawing.Point(6, 42);
            this.btnOpTask.Name = "btnOpTask";
            this.btnOpTask.Size = new System.Drawing.Size(136, 40);
            this.btnOpTask.TabIndex = 0;
            this.btnOpTask.Text = "Open Tasks";
            this.btnOpTask.UseVisualStyleBackColor = true;
            this.btnOpTask.Click += new System.EventHandler(this.btnOpTask_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(574, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Returned vehicles from trips";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(595, 392);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(123, 20);
            this.label13.TabIndex = 28;
            this.label13.Text = "Vehicle number:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(595, 433);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(206, 20);
            this.label14.TabIndex = 29;
            this.label14.Text = "Where was the destination?";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(595, 470);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(128, 20);
            this.label15.TabIndex = 30;
            this.label15.Text = "Procedure Code:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(606, 512);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(112, 20);
            this.label16.TabIndex = 31;
            this.label16.Text = "Any incidents?";
            // 
            // txtVehNum
            // 
            this.txtVehNum.Location = new System.Drawing.Point(817, 392);
            this.txtVehNum.Name = "txtVehNum";
            this.txtVehNum.Size = new System.Drawing.Size(120, 20);
            this.txtVehNum.TabIndex = 32;
            // 
            // txtPreDestination
            // 
            this.txtPreDestination.Location = new System.Drawing.Point(817, 435);
            this.txtPreDestination.Name = "txtPreDestination";
            this.txtPreDestination.Size = new System.Drawing.Size(120, 20);
            this.txtPreDestination.TabIndex = 33;
            // 
            // txtProcCode
            // 
            this.txtProcCode.Location = new System.Drawing.Point(817, 472);
            this.txtProcCode.Name = "txtProcCode";
            this.txtProcCode.Size = new System.Drawing.Size(120, 20);
            this.txtProcCode.TabIndex = 34;
            // 
            // cBoxYesA
            // 
            this.cBoxYesA.AutoSize = true;
            this.cBoxYesA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxYesA.Location = new System.Drawing.Point(817, 512);
            this.cBoxYesA.Name = "cBoxYesA";
            this.cBoxYesA.Size = new System.Drawing.Size(52, 22);
            this.cBoxYesA.TabIndex = 35;
            this.cBoxYesA.Text = "Yes";
            this.cBoxYesA.UseVisualStyleBackColor = true;
            // 
            // cBoxNoA
            // 
            this.cBoxNoA.AutoSize = true;
            this.cBoxNoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxNoA.Location = new System.Drawing.Point(916, 510);
            this.cBoxNoA.Name = "cBoxNoA";
            this.cBoxNoA.Size = new System.Drawing.Size(47, 22);
            this.cBoxNoA.TabIndex = 36;
            this.cBoxNoA.Text = "No";
            this.cBoxNoA.UseVisualStyleBackColor = true;
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Location = new System.Drawing.Point(605, 604);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(132, 31);
            this.btnReport.TabIndex = 37;
            this.btnReport.Text = "Create Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // TripUsage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1029, 662);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.cBoxNoA);
            this.Controls.Add(this.cBoxYesA);
            this.Controls.Add(this.txtProcCode);
            this.Controls.Add(this.txtPreDestination);
            this.Controls.Add(this.txtVehNum);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rbtnSchedule);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "TripUsage";
            this.Text = "TripUsage";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DTPappointment;
        private System.Windows.Forms.TextBox txtVehNo;
        private System.Windows.Forms.TextBox txtProCode;
        private System.Windows.Forms.TextBox txtDescrip;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtdestination;
        private System.Windows.Forms.TextBox txtfuel;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.RadioButton rbtnSchedule;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOpTask;
        private System.Windows.Forms.Button btnStatement;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtVehNum;
        private System.Windows.Forms.TextBox txtPreDestination;
        private System.Windows.Forms.TextBox txtProcCode;
        private System.Windows.Forms.CheckBox cBoxYesA;
        private System.Windows.Forms.CheckBox cBoxNoA;
        private System.Windows.Forms.Button btnReport;
    }
}