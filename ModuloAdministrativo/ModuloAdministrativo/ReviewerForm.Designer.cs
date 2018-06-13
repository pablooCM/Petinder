namespace ModuloAdministrativo
{
    partial class ReviewerForm
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
            this.buttonVisualizeClientAppInformation = new System.Windows.Forms.Button();
            this.buttonPetsManagement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonVisualizeClientAppInformation
            // 
            this.buttonVisualizeClientAppInformation.Location = new System.Drawing.Point(115, 43);
            this.buttonVisualizeClientAppInformation.Name = "buttonVisualizeClientAppInformation";
            this.buttonVisualizeClientAppInformation.Size = new System.Drawing.Size(177, 23);
            this.buttonVisualizeClientAppInformation.TabIndex = 0;
            this.buttonVisualizeClientAppInformation.Text = "Visualize Client App Information";
            this.buttonVisualizeClientAppInformation.UseVisualStyleBackColor = true;
            // 
            // buttonPetsManagement
            // 
            this.buttonPetsManagement.Location = new System.Drawing.Point(115, 106);
            this.buttonPetsManagement.Name = "buttonPetsManagement";
            this.buttonPetsManagement.Size = new System.Drawing.Size(177, 23);
            this.buttonPetsManagement.TabIndex = 1;
            this.buttonPetsManagement.Text = "Pets Management";
            this.buttonPetsManagement.UseVisualStyleBackColor = true;
            // 
            // ReviewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 234);
            this.Controls.Add(this.buttonPetsManagement);
            this.Controls.Add(this.buttonVisualizeClientAppInformation);
            this.Name = "ReviewerForm";
            this.Text = "Welcome Reviewer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonVisualizeClientAppInformation;
        private System.Windows.Forms.Button buttonPetsManagement;
    }
}