using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookEncrypter;

namespace BookEncrypterTool
{
    public partial class Form1 : Form 
    {
        public Form1()
        {
            InitializeComponent();

            tbMessages.ReadOnly = true;
            btnAddClearText.Enabled = false;
            btnAddCipherText.Enabled = false;
            btnEncode.Enabled = false;
            btnDecode.Enabled = false;
            btnSaveClearText.Enabled = false;
            btnSaveCipherText.Enabled = false;
        }

        MagicDecoderRing mdr;

        private void btnCreateDecoder_Click(object sender, EventArgs e)
        {
            mdr = new MagicDecoderRing();
            btnAddClearText.Enabled = true;
            btnAddCipherText.Enabled = true;
        }

        private void btnAddClearText_Click(object sender, EventArgs e)
        {
            mdr.addClearTextMessage();
            tbMessages.Clear();
            foreach (char c in mdr.ClearText.Text)
                tbMessages.Text += c;
            btnDecode.Enabled = false;
            btnEncode.Enabled = true;
        }

        private void btnAddCipherText_Click(object sender, EventArgs e)
        {
            mdr.addCipherTextMessage();
            tbMessages.Clear();
            foreach(char c in mdr.CipherText.Text)
                tbMessages.Text += c;
            btnEncode.Enabled = false;
            btnDecode.Enabled = true;
            btnSaveClearText.Enabled = false;
            btnSaveCipherText.Enabled = true;
        }

        private void btnEncode_Click(object sender, EventArgs e)
        {
            mdr.Encode();
            tbMessages.Clear();
            foreach(char c in mdr.CipherText.Text)
                tbMessages.Text += c;
            btnEncode.Enabled = false;
            btnDecode.Enabled = true;
            btnSaveCipherText.Enabled = true;
            btnSaveClearText.Enabled = false;
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            mdr.Decode();
            tbMessages.Clear();
            foreach(char c in mdr.ClearText.Text)
                tbMessages.Text += c;
            btnDecode.Enabled = false;
            btnEncode.Enabled = true;
            btnSaveClearText.Enabled = true;
            btnSaveCipherText.Enabled = false;
        }

        private void btnSaveClearText_Click(object sender, EventArgs e)
        {
            mdr.saveClearText();
        }

        private void btnSaveCipherText_Click(object sender, EventArgs e)
        {
            mdr.saveCipherText();
        }
    }
}
