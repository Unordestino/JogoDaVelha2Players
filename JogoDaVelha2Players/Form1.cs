using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaVelha2Players {
    public partial class Form1 : Form {
        public string Jogador_Atual = "X";
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        public string InverterJogador() {
            if (Jogador_Atual == "X") {
                return "0";
            } 
            else {
                return "X";
            }
        }
        public void Zerar() {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            Jogador_Atual = "X";
        }
        public void Ganhar() {
            MessageBox.Show("O jogador " + Jogador_Atual + " ganhou!");
            Zerar();
        }
        public bool Verificar(string jogador_at) {
            if (button1.Text == jogador_at && button5.Text == jogador_at && button9.Text == jogador_at) {
                Ganhar();
                return true;
            }
            if (button3.Text == jogador_at && button5.Text == jogador_at && button7.Text == jogador_at) {
                Ganhar();
                return true;
            }
            if (button1.Text == jogador_at && button4.Text == jogador_at && button7.Text == jogador_at) {
                Ganhar();
                return true;
            }
            if (button2.Text == jogador_at && button5.Text == jogador_at && button8.Text == jogador_at) {
                Ganhar();
                return true;
            }
            if (button3.Text == jogador_at && button6.Text == jogador_at && button9.Text == jogador_at) {
                Ganhar();
                return true;
            }
            if (button1.Text == jogador_at && button2.Text == jogador_at && button3.Text == jogador_at) {
                Ganhar();
                return true;
            }
            if (button4.Text == jogador_at && button5.Text == jogador_at && button6.Text == jogador_at) {
                Ganhar();
                return true;
            }
            if (button7.Text == jogador_at && button8.Text == jogador_at && button9.Text == jogador_at) {
                Ganhar();
                return true;
            }
            if (button1.Text.Length !=0 && button2.Text.Length !=0 && button3.Text.Length != 0 && button4.Text.Length != 0
                && button5.Text.Length != 0 && button6.Text.Length != 0 && button7.Text.Length != 0 && button8.Text.Length != 0
                && button9.Text.Length != 0) {
                MessageBox.Show("Deu Velha!");
                Zerar();
            }
                Jogador_Atual = InverterJogador();
            label1.Text = "Jogador Atual: " + Jogador_Atual;
            return false;
        }

        private void button1_Click(object sender, EventArgs e) {
            if(button1.Text == "") {
                button1.Text = Jogador_Atual;
                Verificar(Jogador_Atual);
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            if (button2.Text == "") {
                button2.Text = Jogador_Atual;
                Verificar(Jogador_Atual);
            }
        }

        private void button3_Click(object sender, EventArgs e) {
            if (button3.Text == "") {
                button3.Text = Jogador_Atual;
                Verificar(Jogador_Atual);
            }
        }

        private void button4_Click(object sender, EventArgs e) {
            if (button4.Text == "") {
                button4.Text = Jogador_Atual;
                Verificar(Jogador_Atual);
            }
        }

        private void button5_Click(object sender, EventArgs e) {
            if (button5.Text == "") {
                button5.Text = Jogador_Atual;
                Verificar(Jogador_Atual);
            }
        }

        private void button6_Click(object sender, EventArgs e) {
            if (button6.Text == "") {
                button6.Text = Jogador_Atual;
                Verificar(Jogador_Atual);
            }
        }

        private void button7_Click(object sender, EventArgs e) {
            if (button7.Text == "") {
                button7.Text = Jogador_Atual;
                Verificar(Jogador_Atual);
            }
        }

        private void button8_Click(object sender, EventArgs e) {
            if (button8.Text == "") {
                button8.Text = Jogador_Atual;
                Verificar(Jogador_Atual);
            }
        }

        private void button9_Click(object sender, EventArgs e) {
            if (button9.Text == "") {
                button9.Text = Jogador_Atual;
                Verificar(Jogador_Atual);
            }
        }

        private void button10_Click(object sender, EventArgs e) {
            Zerar();
        }

    }
}
