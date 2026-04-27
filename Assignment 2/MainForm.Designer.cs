namespace Assignment_2
{
    partial class MainForm
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
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnTaskB = new System.Windows.Forms.Button();
            this.btnTaskC = new System.Windows.Forms.Button();
            this.btnTaskD = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnTaskA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(267, 368);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(226, 62);
            this.btnQuit.TabIndex = 0;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnTaskB
            // 
            this.btnTaskB.Location = new System.Drawing.Point(267, 96);
            this.btnTaskB.Name = "btnTaskB";
            this.btnTaskB.Size = new System.Drawing.Size(226, 62);
            this.btnTaskB.TabIndex = 1;
            this.btnTaskB.Text = "Task B - Drag & Drop";
            this.btnTaskB.UseVisualStyleBackColor = true;
            this.btnTaskB.Click += new System.EventHandler(this.btnTaskB_Click);
            // 
            // btnTaskC
            // 
            this.btnTaskC.Location = new System.Drawing.Point(267, 164);
            this.btnTaskC.Name = "btnTaskC";
            this.btnTaskC.Size = new System.Drawing.Size(226, 62);
            this.btnTaskC.TabIndex = 2;
            this.btnTaskC.Text = "Task C - Doubly Linked List";
            this.btnTaskC.UseVisualStyleBackColor = true;
            this.btnTaskC.Click += new System.EventHandler(this.btnTaskC_Click);
            // 
            // btnTaskD
            // 
            this.btnTaskD.Location = new System.Drawing.Point(267, 232);
            this.btnTaskD.Name = "btnTaskD";
            this.btnTaskD.Size = new System.Drawing.Size(226, 62);
            this.btnTaskD.TabIndex = 3;
            this.btnTaskD.Text = "Task D - Nested Classes";
            this.btnTaskD.UseVisualStyleBackColor = true;
            this.btnTaskD.Click += new System.EventHandler(this.btnTaskD_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(267, 300);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(226, 62);
            this.btnHelp.TabIndex = 4;
            this.btnHelp.Text = "Help/About";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnTaskA
            // 
            this.btnTaskA.Location = new System.Drawing.Point(267, 28);
            this.btnTaskA.Name = "btnTaskA";
            this.btnTaskA.Size = new System.Drawing.Size(226, 62);
            this.btnTaskA.TabIndex = 5;
            this.btnTaskA.Text = "Task A - 2D Graphics";
            this.btnTaskA.UseVisualStyleBackColor = true;
            this.btnTaskA.Click += new System.EventHandler(this.btnTaskA_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTaskA);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnTaskD);
            this.Controls.Add(this.btnTaskC);
            this.Controls.Add(this.btnTaskB);
            this.Controls.Add(this.btnQuit);
            this.Name = "Form1";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnTaskB;
        private System.Windows.Forms.Button btnTaskC;
        private System.Windows.Forms.Button btnTaskD;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnTaskA;
    }
}

