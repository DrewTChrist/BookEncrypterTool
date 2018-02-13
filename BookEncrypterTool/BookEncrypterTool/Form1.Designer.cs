namespace BookEncrypterTool
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
            this.tbMessages = new System.Windows.Forms.RichTextBox();
            this.pnlButtonHolder = new System.Windows.Forms.Panel();
            this.btnCreateDecoder = new System.Windows.Forms.Button();
            this.btnEncode = new System.Windows.Forms.Button();
            this.btnSaveCipherText = new System.Windows.Forms.Button();
            this.btnAddCipherText = new System.Windows.Forms.Button();
            this.btnDecode = new System.Windows.Forms.Button();
            this.btnSaveClearText = new System.Windows.Forms.Button();
            this.btnAddClearText = new System.Windows.Forms.Button();
            this.pnlButtonHolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbMessages
            // 
            this.tbMessages.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbMessages.Location = new System.Drawing.Point(0, 0);
            this.tbMessages.Name = "tbMessages";
            this.tbMessages.Size = new System.Drawing.Size(303, 221);
            this.tbMessages.TabIndex = 0;
            this.tbMessages.Text = "Create a Magic Decoder Ring\n\n\nAdd your clear text or cipher text message\n\n\nEncode" +
    " or Decode your message\n\n\nSave your clear text or cipher text message";
            // 
            // pnlButtonHolder
            // 
            this.pnlButtonHolder.Controls.Add(this.btnCreateDecoder);
            this.pnlButtonHolder.Controls.Add(this.btnEncode);
            this.pnlButtonHolder.Controls.Add(this.btnSaveCipherText);
            this.pnlButtonHolder.Controls.Add(this.btnAddCipherText);
            this.pnlButtonHolder.Controls.Add(this.btnDecode);
            this.pnlButtonHolder.Controls.Add(this.btnSaveClearText);
            this.pnlButtonHolder.Controls.Add(this.btnAddClearText);
            this.pnlButtonHolder.Location = new System.Drawing.Point(302, 0);
            this.pnlButtonHolder.Name = "pnlButtonHolder";
            this.pnlButtonHolder.Size = new System.Drawing.Size(167, 221);
            this.pnlButtonHolder.TabIndex = 8;
            // 
            // btnCreateDecoder
            // 
            this.btnCreateDecoder.Location = new System.Drawing.Point(0, 0);
            this.btnCreateDecoder.Name = "btnCreateDecoder";
            this.btnCreateDecoder.Size = new System.Drawing.Size(167, 31);
            this.btnCreateDecoder.TabIndex = 8;
            this.btnCreateDecoder.Text = "Create a Magic Decoder Ring";
            this.btnCreateDecoder.UseVisualStyleBackColor = true;
            this.btnCreateDecoder.Click += new System.EventHandler(this.btnCreateDecoder_Click);
            // 
            // btnEncode
            // 
            this.btnEncode.Location = new System.Drawing.Point(0, 83);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(167, 49);
            this.btnEncode.TabIndex = 11;
            this.btnEncode.Text = "Encode";
            this.btnEncode.UseVisualStyleBackColor = true;
            this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
            // 
            // btnSaveCipherText
            // 
            this.btnSaveCipherText.Location = new System.Drawing.Point(0, 186);
            this.btnSaveCipherText.Name = "btnSaveCipherText";
            this.btnSaveCipherText.Size = new System.Drawing.Size(167, 35);
            this.btnSaveCipherText.TabIndex = 14;
            this.btnSaveCipherText.Text = "Save Cipher Text";
            this.btnSaveCipherText.UseVisualStyleBackColor = true;
            this.btnSaveCipherText.Click += new System.EventHandler(this.btnSaveCipherText_Click);
            // 
            // btnAddCipherText
            // 
            this.btnAddCipherText.Location = new System.Drawing.Point(0, 54);
            this.btnAddCipherText.Name = "btnAddCipherText";
            this.btnAddCipherText.Size = new System.Drawing.Size(167, 31);
            this.btnAddCipherText.TabIndex = 10;
            this.btnAddCipherText.Text = "Add Cipher Text Message";
            this.btnAddCipherText.UseVisualStyleBackColor = true;
            this.btnAddCipherText.Click += new System.EventHandler(this.btnAddCipherText_Click);
            // 
            // btnDecode
            // 
            this.btnDecode.Location = new System.Drawing.Point(0, 129);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(167, 31);
            this.btnDecode.TabIndex = 12;
            this.btnDecode.Text = "Decode";
            this.btnDecode.UseVisualStyleBackColor = true;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // btnSaveClearText
            // 
            this.btnSaveClearText.Location = new System.Drawing.Point(0, 158);
            this.btnSaveClearText.Name = "btnSaveClearText";
            this.btnSaveClearText.Size = new System.Drawing.Size(167, 31);
            this.btnSaveClearText.TabIndex = 13;
            this.btnSaveClearText.Text = "Save Clear Text";
            this.btnSaveClearText.UseVisualStyleBackColor = true;
            this.btnSaveClearText.Click += new System.EventHandler(this.btnSaveClearText_Click);
            // 
            // btnAddClearText
            // 
            this.btnAddClearText.Location = new System.Drawing.Point(0, 28);
            this.btnAddClearText.Name = "btnAddClearText";
            this.btnAddClearText.Size = new System.Drawing.Size(167, 31);
            this.btnAddClearText.TabIndex = 9;
            this.btnAddClearText.Text = "Add Clear Text Message";
            this.btnAddClearText.UseVisualStyleBackColor = true;
            this.btnAddClearText.Click += new System.EventHandler(this.btnAddClearText_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 221);
            this.Controls.Add(this.pnlButtonHolder);
            this.Controls.Add(this.tbMessages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Book Encrypter Tool";
            this.pnlButtonHolder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox tbMessages;
        private System.Windows.Forms.Panel pnlButtonHolder;
        private System.Windows.Forms.Button btnCreateDecoder;
        private System.Windows.Forms.Button btnEncode;
        private System.Windows.Forms.Button btnSaveCipherText;
        private System.Windows.Forms.Button btnAddCipherText;
        private System.Windows.Forms.Button btnDecode;
        private System.Windows.Forms.Button btnSaveClearText;
        private System.Windows.Forms.Button btnAddClearText;
    }
}

