
namespace RandomQuoteGenerator
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
            this.components = new System.ComponentModel.Container();
            this.txtRandomQuote = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnRandomQuote = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRandomQuote
            // 
            this.txtRandomQuote.Location = new System.Drawing.Point(22, 102);
            this.txtRandomQuote.Multiline = true;
            this.txtRandomQuote.Name = "txtRandomQuote";
            this.txtRandomQuote.Size = new System.Drawing.Size(469, 49);
            this.txtRandomQuote.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnRandomQuote
            // 
            this.btnRandomQuote.Location = new System.Drawing.Point(155, 27);
            this.btnRandomQuote.Name = "btnRandomQuote";
            this.btnRandomQuote.Size = new System.Drawing.Size(188, 52);
            this.btnRandomQuote.TabIndex = 2;
            this.btnRandomQuote.Text = "Random Quote";
            this.btnRandomQuote.UseVisualStyleBackColor = true;
            this.btnRandomQuote.Click += new System.EventHandler(this.btnRandomQuote_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 180);
            this.Controls.Add(this.btnRandomQuote);
            this.Controls.Add(this.txtRandomQuote);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRandomQuote;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnRandomQuote;
    }
}

