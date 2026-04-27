namespace Assignment_2
{
    partial class TaskCForm
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnBackwards = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 12);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(294, 22);
            this.txtInput.TabIndex = 0;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(312, 11);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(113, 23);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnForward
            // 
            this.btnForward.Location = new System.Drawing.Point(12, 40);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(210, 36);
            this.btnForward.TabIndex = 2;
            this.btnForward.Text = "Forward";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(12, 79);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(52, 16);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "Results";
            // 
            // btnBackwards
            // 
            this.btnBackwards.Location = new System.Drawing.Point(228, 40);
            this.btnBackwards.Name = "btnBackwards";
            this.btnBackwards.Size = new System.Drawing.Size(210, 36);
            this.btnBackwards.TabIndex = 5;
            this.btnBackwards.Text = "Backwards";
            this.btnBackwards.UseVisualStyleBackColor = true;
            this.btnBackwards.Click += new System.EventHandler(this.btnBackwards_Click);
            // 
            // TaskCForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBackwards);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtInput);
            this.Name = "TaskCForm";
            this.Text = "TaskCForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnBackwards;
    }
}