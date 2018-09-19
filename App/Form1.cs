using System;
using System.Windows.Forms;
using LibDisp;

namespace App
{
    public partial class Form1 : Form
    {
        IDisplayCall disp = new DisplayCall();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Carrega informações básicas na dll
            disp._serverIp = "192.168.0.113";

            // Carrega informações básicas nos controles do programa
            textBox_ipserver.Text = "192.168.0.113";
            numericUpDown_row.Value = 1;
            numericUpDown_ticket.Value = 1;
            numericUpDown_mesa.Value = 1;
            comboBox_alpha.SelectedIndex = 0;
        }

        private void button_call_Click(object sender, EventArgs e)
        {
            // Chama uma senha especifica diretamente no painel de chamada
            disp.CallTicket(Convert.ToByte(numericUpDown_row.Value), Convert.ToChar(comboBox_alpha.SelectedItem), Convert.ToUInt16(numericUpDown_ticket.Value), Convert.ToByte(numericUpDown_mesa.Value), textBox_depName.Text);
            PrintResultDisp();
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            // Solicita para o painel mostrar a próxima chamada
            disp.CallNext(Convert.ToByte(numericUpDown_row.Value), Convert.ToByte(numericUpDown_mesa.Value));
            PrintResultDisp();
        }

        private void button_repeat_Click(object sender, EventArgs e)
        {
            // Solicita para o painel repetir a última chamada
            disp.RepeatCall(Convert.ToByte(numericUpDown_row.Value), Convert.ToByte(numericUpDown_mesa.Value));
            PrintResultDisp();
        }

        private void button_adjust_Click(object sender, EventArgs e)
        {
            // Ajusta no painel o número da chamada
            disp.AdjustNum(Convert.ToByte(numericUpDown_row.Value), Convert.ToByte(numericUpDown_mesa.Value), Convert.ToUInt16(numericUpDown_ticket.Value));
            PrintResultDisp();
        }
          private void button_ins_Click(object sender, EventArgs e)
        {
            // Insere na fila do painel o número do box
            disp.InsertCall (Convert.ToByte(numericUpDown_mesa.Value));
            PrintResultDisp();
        }

        private void button_exc_Click(object sender, EventArgs e)
        {
            // Retira da fila do painel o número do box
            disp.DeleteCall(Convert.ToByte(numericUpDown_mesa.Value));
            PrintResultDisp();
        }
        private void button_inf_Click(object sender, EventArgs e)
        {
            // Retira da fila do painel o número do box
            while (disp.InfoAtd())
                PrintResultDisp();
        }
        private void PrintResultDisp()
        {
            textBox1.Text += disp._status + Convert.ToChar(13) + Convert.ToChar(10);
        }

        private void button_apply_Click(object sender, EventArgs e)
        {
            // Carrega informações básicas na dll
            disp._serverIp = textBox_ipserver.Text;
        }

    }
}
