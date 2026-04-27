namespace Assignment_2
{
    partial class TaskDForm
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
            this.txtMake = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtEngineType = new System.Windows.Forms.TextBox();
            this.txtHorsePower = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(12, 12);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(220, 22);
            this.txtMake.TabIndex = 0;
            this.txtMake.Text = "Make";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(12, 40);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(220, 22);
            this.txtModel.TabIndex = 1;
            this.txtModel.Text = "Model";
            // 
            // txtEngineType
            // 
            this.txtEngineType.Location = new System.Drawing.Point(12, 68);
            this.txtEngineType.Name = "txtEngineType";
            this.txtEngineType.Size = new System.Drawing.Size(220, 22);
            this.txtEngineType.TabIndex = 2;
            this.txtEngineType.Text = "Engine Type";
            // 
            // txtHorsePower
            // 
            this.txtHorsePower.Location = new System.Drawing.Point(12, 96);
            this.txtHorsePower.Name = "txtHorsePower";
            this.txtHorsePower.Size = new System.Drawing.Size(220, 22);
            this.txtHorsePower.TabIndex = 3;
            this.txtHorsePower.Text = "Horse Power";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(13, 125);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(219, 23);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(13, 155);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(48, 16);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "Result:";
            // 
            // TaskDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtHorsePower);
            this.Controls.Add(this.txtEngineType);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtMake);
            this.Name = "TaskDForm";
            this.Text = "TaskDForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtEngineType;
        private System.Windows.Forms.TextBox txtHorsePower;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblResult;
    }
}