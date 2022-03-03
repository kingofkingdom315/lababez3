using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lababez3
{
    public partial class FormWORDKEY : Form
    {
        public FormWORDKEY()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ANSWER.Text = "Работу выполнил: Студент гурппы ПКспк-219\r\nКенкебашвили Илья\r\nВаш текст после расшифровки: ";
                WordKeyCrypt.createNewAlpha(WORDKEY.Text.ToLower(), int.Parse(KEY.Text));
                ANSWER.Text += WordKeyCrypt.decrypt(MASSAGE.Text.ToLower());
                WordKeyCrypt.deleteNewAlpha();
            }
            catch { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                ANSWER.Text = "Работу выполнил: Студент гурппы ПКспк-219\r\nКенкебашвили Илья\r\nВаш текст после шифровки: ";
                WordKeyCrypt.createNewAlpha(WORDKEY.Text.ToLower(), int.Parse(KEY.Text));
                ANSWER.Text += WordKeyCrypt.encrypt(MASSAGE.Text.ToLower());
                WordKeyCrypt.deleteNewAlpha();
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ANSWER.Text = "";
                MASSAGE.Text = "";
                WORDKEY.Text = "";
                KEY.Text = "1";
            }
            catch { }
        }
    }
}
