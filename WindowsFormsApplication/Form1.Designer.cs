namespace WindowsFormsApplication
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
            this.btnSync = new System.Windows.Forms.Button();
            this.btnAsync = new System.Windows.Forms.Button();
            this.lblTempo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSync
            // 
            this.btnSync.Location = new System.Drawing.Point(13, 72);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(259, 23);
            this.btnSync.TabIndex = 0;
            this.btnSync.Text = "Executar Cozinha Sync";
            this.btnSync.UseVisualStyleBackColor = true;
            this.btnSync.Click += new System.EventHandler(this.btnSync_Click);
            // 
            // btnAsync
            // 
            this.btnAsync.Location = new System.Drawing.Point(13, 119);
            this.btnAsync.Name = "btnAsync";
            this.btnAsync.Size = new System.Drawing.Size(259, 23);
            this.btnAsync.TabIndex = 1;
            this.btnAsync.Text = "Executar Cozinha Async";
            this.btnAsync.UseVisualStyleBackColor = true;
            this.btnAsync.Click += new System.EventHandler(this.btnAsync_Click);
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempo.Location = new System.Drawing.Point(0, 0);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(0, 20);
            this.lblTempo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(619, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ao executar Cozinha Sync sua tela travará e ao executar a Cozinha Async sua tela " +
    "está livre mesmo com o processo executando.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.btnAsync);
            this.Controls.Add(this.btnSync);
            this.Name = "Form1";
            this.Text = "Sync / Async";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSync;
        private System.Windows.Forms.Button btnAsync;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.Label label1;
    }
}

