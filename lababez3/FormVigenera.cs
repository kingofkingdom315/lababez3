﻿using System;
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
    public partial class FormVigenera : Form
    {
        public FormVigenera()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                ANSWER.Text = "Работу выполнил: Студент гурппы ПКспк-219\r\nКенкебашвили Илья\r\nВаш текст после шифровки: ";
                ANSWER.Text += CryptoVigenera.encrypt(MASSAGE.Text.ToLower(), WORDKEY.Text);
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ANSWER.Text = "Работу выполнил: Студент гурппы ПКспк-219\r\nКенкебашвили Илья\r\nВаш текст после расшифровки: ";
                ANSWER.Text += CryptoVigenera.decrypt(MASSAGE.Text.ToLower(), WORDKEY.Text);
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ANSWER.Text = "";
            MASSAGE.Text = "";
            WORDKEY.Text = "";
        }
    }
}
