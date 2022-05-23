namespace week_13_praktikum
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
            this.button_prev2 = new System.Windows.Forms.Button();
            this.button_prev = new System.Windows.Forms.Button();
            this.button_next = new System.Windows.Forms.Button();
            this.button_next2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_playerID = new System.Windows.Forms.TextBox();
            this.textBox_playerName = new System.Windows.Forms.TextBox();
            this.dateTimePicker_birthDate = new System.Windows.Forms.DateTimePicker();
            this.comboBox_nationality = new System.Windows.Forms.ComboBox();
            this.numericUpDown_teamNumber = new System.Windows.Forms.NumericUpDown();
            this.button_save = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.comboBox_team = new System.Windows.Forms.ComboBox();
            this.label_avail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_teamNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // button_prev2
            // 
            this.button_prev2.Location = new System.Drawing.Point(51, 42);
            this.button_prev2.Name = "button_prev2";
            this.button_prev2.Size = new System.Drawing.Size(75, 23);
            this.button_prev2.TabIndex = 0;
            this.button_prev2.Text = "<<";
            this.button_prev2.UseVisualStyleBackColor = true;
            this.button_prev2.Click += new System.EventHandler(this.button_prev2_Click);
            // 
            // button_prev
            // 
            this.button_prev.Location = new System.Drawing.Point(132, 42);
            this.button_prev.Name = "button_prev";
            this.button_prev.Size = new System.Drawing.Size(75, 23);
            this.button_prev.TabIndex = 1;
            this.button_prev.Text = "<";
            this.button_prev.UseVisualStyleBackColor = true;
            this.button_prev.Click += new System.EventHandler(this.button_prev_Click);
            // 
            // button_next
            // 
            this.button_next.Location = new System.Drawing.Point(213, 42);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(75, 23);
            this.button_next.TabIndex = 2;
            this.button_next.Text = ">";
            this.button_next.UseVisualStyleBackColor = true;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // button_next2
            // 
            this.button_next2.Location = new System.Drawing.Point(294, 42);
            this.button_next2.Name = "button_next2";
            this.button_next2.Size = new System.Drawing.Size(75, 23);
            this.button_next2.TabIndex = 3;
            this.button_next2.Text = ">>";
            this.button_next2.UseVisualStyleBackColor = true;
            this.button_next2.Click += new System.EventHandler(this.button_next2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Player ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Player Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "BirthDate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nationality";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Team";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Team Number";
            // 
            // textBox_playerID
            // 
            this.textBox_playerID.Location = new System.Drawing.Point(153, 90);
            this.textBox_playerID.Name = "textBox_playerID";
            this.textBox_playerID.Size = new System.Drawing.Size(100, 20);
            this.textBox_playerID.TabIndex = 10;
            // 
            // textBox_playerName
            // 
            this.textBox_playerName.Location = new System.Drawing.Point(153, 131);
            this.textBox_playerName.Name = "textBox_playerName";
            this.textBox_playerName.Size = new System.Drawing.Size(185, 20);
            this.textBox_playerName.TabIndex = 11;
            // 
            // dateTimePicker_birthDate
            // 
            this.dateTimePicker_birthDate.Location = new System.Drawing.Point(153, 167);
            this.dateTimePicker_birthDate.Name = "dateTimePicker_birthDate";
            this.dateTimePicker_birthDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_birthDate.TabIndex = 12;
            // 
            // comboBox_nationality
            // 
            this.comboBox_nationality.FormattingEnabled = true;
            this.comboBox_nationality.Location = new System.Drawing.Point(153, 201);
            this.comboBox_nationality.Name = "comboBox_nationality";
            this.comboBox_nationality.Size = new System.Drawing.Size(185, 21);
            this.comboBox_nationality.TabIndex = 13;
            // 
            // numericUpDown_teamNumber
            // 
            this.numericUpDown_teamNumber.Location = new System.Drawing.Point(153, 274);
            this.numericUpDown_teamNumber.Name = "numericUpDown_teamNumber";
            this.numericUpDown_teamNumber.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_teamNumber.TabIndex = 15;
            this.numericUpDown_teamNumber.ValueChanged += new System.EventHandler(this.numericUpDown_teamNumber_ValueChanged);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(69, 308);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(111, 23);
            this.button_save.TabIndex = 16;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(196, 308);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(111, 23);
            this.button_Cancel.TabIndex = 17;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // comboBox_team
            // 
            this.comboBox_team.FormattingEnabled = true;
            this.comboBox_team.Location = new System.Drawing.Point(152, 233);
            this.comboBox_team.Name = "comboBox_team";
            this.comboBox_team.Size = new System.Drawing.Size(186, 21);
            this.comboBox_team.TabIndex = 18;
            // 
            // label_avail
            // 
            this.label_avail.AutoSize = true;
            this.label_avail.Location = new System.Drawing.Point(303, 274);
            this.label_avail.Name = "label_avail";
            this.label_avail.Size = new System.Drawing.Size(50, 13);
            this.label_avail.TabIndex = 19;
            this.label_avail.Text = "Available";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_avail);
            this.Controls.Add(this.comboBox_team);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.numericUpDown_teamNumber);
            this.Controls.Add(this.comboBox_nationality);
            this.Controls.Add(this.dateTimePicker_birthDate);
            this.Controls.Add(this.textBox_playerName);
            this.Controls.Add(this.textBox_playerID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_next2);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.button_prev);
            this.Controls.Add(this.button_prev2);
            this.Name = "Form1";
            this.Text = "BirthDate";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_teamNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_prev2;
        private System.Windows.Forms.Button button_prev;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Button button_next2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_playerID;
        private System.Windows.Forms.TextBox textBox_playerName;
        private System.Windows.Forms.DateTimePicker dateTimePicker_birthDate;
        private System.Windows.Forms.ComboBox comboBox_nationality;
        private System.Windows.Forms.NumericUpDown numericUpDown_teamNumber;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.ComboBox comboBox_team;
        private System.Windows.Forms.Label label_avail;
    }
}

