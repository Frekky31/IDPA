namespace IDPA
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
            this.btnSentiment = new System.Windows.Forms.Button();
            this.btnObject = new System.Windows.Forms.Button();
            this.btnHeart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSentiment
            // 
            this.btnSentiment.Location = new System.Drawing.Point(74, 123);
            this.btnSentiment.Name = "btnSentiment";
            this.btnSentiment.Size = new System.Drawing.Size(118, 55);
            this.btnSentiment.TabIndex = 0;
            this.btnSentiment.Text = "Sentiment";
            this.btnSentiment.UseVisualStyleBackColor = true;
            this.btnSentiment.Click += new System.EventHandler(this.btnSentiment_Click);
            // 
            // btnObject
            // 
            this.btnObject.Location = new System.Drawing.Point(214, 123);
            this.btnObject.Name = "btnObject";
            this.btnObject.Size = new System.Drawing.Size(118, 55);
            this.btnObject.TabIndex = 1;
            this.btnObject.Text = "Object Detection";
            this.btnObject.UseVisualStyleBackColor = true;
            // 
            // btnHeart
            // 
            this.btnHeart.Location = new System.Drawing.Point(356, 123);
            this.btnHeart.Name = "btnHeart";
            this.btnHeart.Size = new System.Drawing.Size(118, 55);
            this.btnHeart.TabIndex = 2;
            this.btnHeart.Text = "Heart Disease";
            this.btnHeart.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 305);
            this.Controls.Add(this.btnHeart);
            this.Controls.Add(this.btnObject);
            this.Controls.Add(this.btnSentiment);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSentiment;
        private System.Windows.Forms.Button btnObject;
        private System.Windows.Forms.Button btnHeart;
    }
}