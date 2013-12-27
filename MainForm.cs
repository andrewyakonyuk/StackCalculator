using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StackCalc
{
    public partial class MainForm : Form
    {
        bool _isEnd = false;

        public MainForm()
        {
            InitializeComponent();
            this.Clear();
            this.TypeOfCalculation("infix");
        }

        void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void inputButtons_MouseClick(object sender, MouseEventArgs e)
        {
            if (this._isEnd)
            {
                this.Clear();
            }
            string expression = tb_display.Text;
            Button button = (Button)sender;
            if (expression.Length == 1 && expression[0] == '0')
            {
                tb_display.Text = button.Tag.ToString();
            }
            else tb_display.Text += button.Tag.ToString();
        }

        private void but_backspace_Click(object sender, EventArgs e)
        {
            string expression = tb_display.Text;
            if (expression.Length > 0)
            {
                expression = expression.Remove(expression.Length - 1);
                if (expression.Length == 0)
                    expression = "0";
                tb_display.Text = expression;
            }
        }

        private void but_clear_Click(object sender, EventArgs e)
        {
            this.Clear();
        }

        private void but_result_Click(object sender, EventArgs e)
        {
            string expression = tb_display.Text;
            try
            {
                object[] tokens = PolishNotationParser.Parse(expression);
                string reverse_polish_notation = string.Empty;
                foreach (object item in tokens)
                {
                    if (item is Operands)
                    {
                        reverse_polish_notation += " " + ((Operands)item).Value.ToString() + " ";
                    }
                    else if (item is Operation)
                    {
                        reverse_polish_notation += ((Operation)item).ToString();
                    }
                }
                addition_wizard.Text = reverse_polish_notation;
                double result = (double)PolishNotationParser.Calculate(tokens).Value;
                tb_display.Text = result.ToString("N");
                this._isEnd = true;
            }
            catch (Exception)
            {
                this.Clear();
                ToolTip toolTip = new ToolTip();
                toolTip.Show("Обнаружена ошибка в выражении. Не достает оператора или закрывающей скобки", tb_display,4000);
                toolTip.UseAnimation = true;
                toolTip.BackColor = Color.DimGray;
                toolTip.AutoPopDelay = 7000;
                toolTip.ToolTipIcon = ToolTipIcon.Error;
                toolTip.ShowAlways = false;
            }
        }

        void Clear()
        {
            _isEnd = false;
            tb_display.Text = "0";
            addition_wizard.Text = "0";
        }

        private void changeWizard_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            this.TypeOfCalculation((string)item.Tag);
        }

        public void TypeOfCalculation(string type)
        {
            switch (type)
            {
                case "postfix":
                    addition_wizard.Visible = false;
                    other_number.Visible = true;
                    инфикснаяВПостфикснуюToolStripMenuItem.Checked = false;
                    постфикснаяВИнфикснуюToolStripMenuItem.Checked = true;
                    break;
                case "infix":
                    addition_wizard.Visible = true;
                    other_number.Visible = false;
                    инфикснаяВПостфикснуюToolStripMenuItem.Checked = true;
                    постфикснаяВИнфикснуюToolStripMenuItem.Checked = false;
                    break;
                default:
                    throw new Exception("Неверный тип преобразований");
            }
        }

        private void other_number_Click(object sender, EventArgs e)
        {
            tb_display.Text += " ";
        }

        private void but_znak_MouseClick(object sender, MouseEventArgs e)
        {
            if (this._isEnd)
            {
                this.Clear();
            }
            string expression = tb_display.Text;
            if (expression.Length == 1 && expression[0] == '0')
            {
                tb_display.Text = "~";
            }
            else tb_display.Text += "~";
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
