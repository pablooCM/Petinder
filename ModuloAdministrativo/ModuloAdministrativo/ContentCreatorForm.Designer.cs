namespace ModuloAdministrativo
{
    partial class ContentCreatorForm
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
            this.buttonHeadquartersManagement = new System.Windows.Forms.Button();
            this.buttonEmployeesManagement = new System.Windows.Forms.Button();
            this.buttonPetsManagement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonHeadquartersManagement
            // 
            this.buttonHeadquartersManagement.Location = new System.Drawing.Point(115, 33);
            this.buttonHeadquartersManagement.Name = "buttonHeadquartersManagement";
            this.buttonHeadquartersManagement.Size = new System.Drawing.Size(179, 23);
            this.buttonHeadquartersManagement.TabIndex = 0;
            this.buttonHeadquartersManagement.Text = "Headquarters Management";
            this.buttonHeadquartersManagement.UseVisualStyleBackColor = true;
            // 
            // buttonEmployeesManagement
            // 
            this.buttonEmployeesManagement.Location = new System.Drawing.Point(115, 90);
            this.buttonEmployeesManagement.Name = "buttonEmployeesManagement";
            this.buttonEmployeesManagement.Size = new System.Drawing.Size(179, 23);
            this.buttonEmployeesManagement.TabIndex = 1;
            this.buttonEmployeesManagement.Text = "Employees Management";
            this.buttonEmployeesManagement.UseVisualStyleBackColor = true;
            // 
            // buttonPetsManagement
            // 
            this.buttonPetsManagement.Location = new System.Drawing.Point(115, 145);
            this.buttonPetsManagement.Name = "buttonPetsManagement";
            this.buttonPetsManagement.Size = new System.Drawing.Size(179, 23);
            this.buttonPetsManagement.TabIndex = 2;
            this.buttonPetsManagement.Text = "Pets Management";
            this.buttonPetsManagement.UseVisualStyleBackColor = true;
            // 
            // ContentCreatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 247);
            this.Controls.Add(this.buttonPetsManagement);
            this.Controls.Add(this.buttonEmployeesManagement);
            this.Controls.Add(this.buttonHeadquartersManagement);
            this.Name = "ContentCreatorForm";
            this.Text = "Welcome Content Creator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonHeadquartersManagement;
        private System.Windows.Forms.Button buttonEmployeesManagement;
        private System.Windows.Forms.Button buttonPetsManagement;
    }
}