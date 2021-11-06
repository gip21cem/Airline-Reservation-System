namespace AirplaneReservation
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonReservation = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.comboBoxPosition = new System.Windows.Forms.ComboBox();
            this.checkBoxEconomy = new System.Windows.Forms.CheckBox();
            this.checkBoxFirst = new System.Windows.Forms.CheckBox();
            this.buttonSerialize = new System.Windows.Forms.Button();
            this.buttonDeSerialize = new System.Windows.Forms.Button();
            this.buttonSortByPassengerName = new System.Windows.Forms.Button();
            this.buttonSortBySeatNumber = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelDate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(56, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(749, 415);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonReservation);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.comboBoxPosition);
            this.groupBox1.Controls.Add(this.checkBoxEconomy);
            this.groupBox1.Controls.Add(this.checkBoxFirst);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(846, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 294);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Option 2. Please select your preferences and click \"Find a Match and Reserve\"";
            // 
            // buttonReservation
            // 
            this.buttonReservation.Location = new System.Drawing.Point(22, 244);
            this.buttonReservation.Name = "buttonReservation";
            this.buttonReservation.Size = new System.Drawing.Size(361, 44);
            this.buttonReservation.TabIndex = 7;
            this.buttonReservation.Text = "Find a Match and Reserve";
            this.buttonReservation.UseVisualStyleBackColor = true;
            this.buttonReservation.Click += new System.EventHandler(this.buttonReservation_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Select preferred position";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select number of passengers ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select class type";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(219, 193);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(164, 22);
            this.numericUpDown1.TabIndex = 3;
            // 
            // comboBoxPosition
            // 
            this.comboBoxPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPosition.FormattingEnabled = true;
            this.comboBoxPosition.Location = new System.Drawing.Point(219, 139);
            this.comboBoxPosition.Name = "comboBoxPosition";
            this.comboBoxPosition.Size = new System.Drawing.Size(164, 24);
            this.comboBoxPosition.TabIndex = 2;
            // 
            // checkBoxEconomy
            // 
            this.checkBoxEconomy.AutoSize = true;
            this.checkBoxEconomy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEconomy.Location = new System.Drawing.Point(219, 89);
            this.checkBoxEconomy.Name = "checkBoxEconomy";
            this.checkBoxEconomy.Size = new System.Drawing.Size(126, 21);
            this.checkBoxEconomy.TabIndex = 1;
            this.checkBoxEconomy.Text = "Economy Class";
            this.checkBoxEconomy.UseVisualStyleBackColor = true;
            this.checkBoxEconomy.CheckedChanged += new System.EventHandler(this.checkBoxEconomy_CheckedChanged);
            // 
            // checkBoxFirst
            // 
            this.checkBoxFirst.AutoSize = true;
            this.checkBoxFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxFirst.Location = new System.Drawing.Point(219, 47);
            this.checkBoxFirst.Name = "checkBoxFirst";
            this.checkBoxFirst.Size = new System.Drawing.Size(95, 21);
            this.checkBoxFirst.TabIndex = 0;
            this.checkBoxFirst.Text = "First Class";
            this.checkBoxFirst.UseVisualStyleBackColor = true;
            this.checkBoxFirst.CheckedChanged += new System.EventHandler(this.checkBoxFirst_CheckedChanged);
            // 
            // buttonSerialize
            // 
            this.buttonSerialize.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSerialize.Location = new System.Drawing.Point(54, 580);
            this.buttonSerialize.Name = "buttonSerialize";
            this.buttonSerialize.Size = new System.Drawing.Size(208, 44);
            this.buttonSerialize.TabIndex = 2;
            this.buttonSerialize.Text = "Save Reservation Details";
            this.buttonSerialize.UseVisualStyleBackColor = true;
            this.buttonSerialize.Click += new System.EventHandler(this.buttonSerialize_Click);
            // 
            // buttonDeSerialize
            // 
            this.buttonDeSerialize.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeSerialize.Location = new System.Drawing.Point(314, 580);
            this.buttonDeSerialize.Name = "buttonDeSerialize";
            this.buttonDeSerialize.Size = new System.Drawing.Size(201, 44);
            this.buttonDeSerialize.TabIndex = 3;
            this.buttonDeSerialize.Text = "Load Reservation Details";
            this.buttonDeSerialize.UseVisualStyleBackColor = true;
            this.buttonDeSerialize.Click += new System.EventHandler(this.buttonDeSerialize_Click);
            // 
            // buttonSortByPassengerName
            // 
            this.buttonSortByPassengerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSortByPassengerName.Location = new System.Drawing.Point(557, 580);
            this.buttonSortByPassengerName.Name = "buttonSortByPassengerName";
            this.buttonSortByPassengerName.Size = new System.Drawing.Size(201, 44);
            this.buttonSortByPassengerName.TabIndex = 4;
            this.buttonSortByPassengerName.Text = "Sort by Passenger Name";
            this.buttonSortByPassengerName.UseVisualStyleBackColor = true;
            this.buttonSortByPassengerName.Click += new System.EventHandler(this.buttonSortByPassengerName_Click);
            // 
            // buttonSortBySeatNumber
            // 
            this.buttonSortBySeatNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSortBySeatNumber.Location = new System.Drawing.Point(795, 580);
            this.buttonSortBySeatNumber.Name = "buttonSortBySeatNumber";
            this.buttonSortBySeatNumber.Size = new System.Drawing.Size(201, 44);
            this.buttonSortBySeatNumber.TabIndex = 5;
            this.buttonSortBySeatNumber.Text = "Sort by Seat Number";
            this.buttonSortBySeatNumber.UseVisualStyleBackColor = true;
            this.buttonSortBySeatNumber.Click += new System.EventHandler(this.buttonSortBySeatNumber_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(1028, 580);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(201, 44);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(1104, 41);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(52, 17);
            this.labelDate.TabIndex = 7;
            this.labelDate.Text = "label4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(56, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(436, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "AIRPLANE SEAT RESERVATION SYSTEM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(549, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Option 1. To make a reservation enter passengers\' names in the list below";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 672);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSortBySeatNumber);
            this.Controls.Add(this.buttonSortByPassengerName);
            this.Controls.Add(this.buttonDeSerialize);
            this.Controls.Add(this.buttonSerialize);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Airplane Reservation System";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxFirst;
        private System.Windows.Forms.CheckBox checkBoxEconomy;
        private System.Windows.Forms.ComboBox comboBoxPosition;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonReservation;
        private System.Windows.Forms.Button buttonSerialize;
        private System.Windows.Forms.Button buttonDeSerialize;
        private System.Windows.Forms.Button buttonSortByPassengerName;
        private System.Windows.Forms.Button buttonSortBySeatNumber;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

