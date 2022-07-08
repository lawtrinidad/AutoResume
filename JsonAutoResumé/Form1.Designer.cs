namespace JsonAutoResumé
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonGenerateJSON = new System.Windows.Forms.Button();
            this.buttonCreatePDF = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGenerateJSON
            // 
            this.buttonGenerateJSON.Location = new System.Drawing.Point(136, 115);
            this.buttonGenerateJSON.Name = "buttonGenerateJSON";
            this.buttonGenerateJSON.Size = new System.Drawing.Size(98, 23);
            this.buttonGenerateJSON.TabIndex = 0;
            this.buttonGenerateJSON.Text = "Generate JSON";
            this.buttonGenerateJSON.UseVisualStyleBackColor = true;
            this.buttonGenerateJSON.Click += new System.EventHandler(this.buttonGenerateJSON_Click);
            // 
            // buttonCreatePDF
            // 
            this.buttonCreatePDF.Location = new System.Drawing.Point(136, 144);
            this.buttonCreatePDF.Name = "buttonCreatePDF";
            this.buttonCreatePDF.Size = new System.Drawing.Size(98, 23);
            this.buttonCreatePDF.TabIndex = 1;
            this.buttonCreatePDF.Text = "Convert to PDF";
            this.buttonCreatePDF.UseVisualStyleBackColor = true;
            this.buttonCreatePDF.Click += new System.EventHandler(this.buttonCreatePDF_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(12, 255);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 35);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Application Form:";
            this.textBox1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 94);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 302);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonCreatePDF);
            this.Controls.Add(this.buttonGenerateJSON);
            this.Name = "Form1";
            this.Text = "AutoResumé";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonGenerateJSON;
        private Button buttonCreatePDF;
        private TextBox textBox1;
        private PictureBox pictureBox1;
    }
}