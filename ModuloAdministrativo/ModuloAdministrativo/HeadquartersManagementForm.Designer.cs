namespace ModuloAdministrativo
{
    partial class HeadquartersManagementForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxCountry = new System.Windows.Forms.TextBox();
            this.dateTimePickerCreationDate = new System.Windows.Forms.DateTimePicker();
            this.buttonCreateHeadquarters = new System.Windows.Forms.Button();
            this.buttonReadHeadquarters = new System.Windows.Forms.Button();
            this.buttonUpdateHeadquarters = new System.Windows.Forms.Button();
            this.buttonDeleteHeadquarters = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxHeadquartersCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "City";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Country";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Creation Date";
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(119, 51);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(159, 20);
            this.textBoxCity.TabIndex = 3;
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.Location = new System.Drawing.Point(119, 94);
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.Size = new System.Drawing.Size(159, 20);
            this.textBoxCountry.TabIndex = 4;
            // 
            // dateTimePickerCreationDate
            // 
            this.dateTimePickerCreationDate.Location = new System.Drawing.Point(119, 128);
            this.dateTimePickerCreationDate.Name = "dateTimePickerCreationDate";
            this.dateTimePickerCreationDate.Size = new System.Drawing.Size(159, 20);
            this.dateTimePickerCreationDate.TabIndex = 5;
            // 
            // buttonCreateHeadquarters
            // 
            this.buttonCreateHeadquarters.Location = new System.Drawing.Point(353, 68);
            this.buttonCreateHeadquarters.Name = "buttonCreateHeadquarters";
            this.buttonCreateHeadquarters.Size = new System.Drawing.Size(126, 23);
            this.buttonCreateHeadquarters.TabIndex = 6;
            this.buttonCreateHeadquarters.Text = "Create Headquarters";
            this.buttonCreateHeadquarters.UseVisualStyleBackColor = true;
            // 
            // buttonReadHeadquarters
            // 
            this.buttonReadHeadquarters.Location = new System.Drawing.Point(353, 23);
            this.buttonReadHeadquarters.Name = "buttonReadHeadquarters";
            this.buttonReadHeadquarters.Size = new System.Drawing.Size(126, 23);
            this.buttonReadHeadquarters.TabIndex = 7;
            this.buttonReadHeadquarters.Text = "Read Headquarters";
            this.buttonReadHeadquarters.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateHeadquarters
            // 
            this.buttonUpdateHeadquarters.Location = new System.Drawing.Point(353, 112);
            this.buttonUpdateHeadquarters.Name = "buttonUpdateHeadquarters";
            this.buttonUpdateHeadquarters.Size = new System.Drawing.Size(126, 23);
            this.buttonUpdateHeadquarters.TabIndex = 8;
            this.buttonUpdateHeadquarters.Text = "Update Headquarters";
            this.buttonUpdateHeadquarters.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteHeadquarters
            // 
            this.buttonDeleteHeadquarters.Location = new System.Drawing.Point(353, 155);
            this.buttonDeleteHeadquarters.Name = "buttonDeleteHeadquarters";
            this.buttonDeleteHeadquarters.Size = new System.Drawing.Size(126, 23);
            this.buttonDeleteHeadquarters.TabIndex = 9;
            this.buttonDeleteHeadquarters.Text = "Delete Headquarters";
            this.buttonDeleteHeadquarters.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Headquarters\' code";
            // 
            // textBoxHeadquartersCode
            // 
            this.textBoxHeadquartersCode.Location = new System.Drawing.Point(118, 23);
            this.textBoxHeadquartersCode.Name = "textBoxHeadquartersCode";
            this.textBoxHeadquartersCode.Size = new System.Drawing.Size(103, 20);
            this.textBoxHeadquartersCode.TabIndex = 11;
            // 
            // HeadquartersManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 222);
            this.Controls.Add(this.textBoxHeadquartersCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonDeleteHeadquarters);
            this.Controls.Add(this.buttonUpdateHeadquarters);
            this.Controls.Add(this.buttonReadHeadquarters);
            this.Controls.Add(this.buttonCreateHeadquarters);
            this.Controls.Add(this.dateTimePickerCreationDate);
            this.Controls.Add(this.textBoxCountry);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HeadquartersManagementForm";
            this.Text = "Headquarters Management";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxCountry;
        private System.Windows.Forms.DateTimePicker dateTimePickerCreationDate;
        private System.Windows.Forms.Button buttonCreateHeadquarters;
        private System.Windows.Forms.Button buttonReadHeadquarters;
        private System.Windows.Forms.Button buttonUpdateHeadquarters;
        private System.Windows.Forms.Button buttonDeleteHeadquarters;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxHeadquartersCode;
    }
}