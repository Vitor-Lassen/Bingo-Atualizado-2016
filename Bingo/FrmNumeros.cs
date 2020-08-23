using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace Bingo
{
    public partial class FrmNumeros : Form
    {
        public FrmNumeros()
        {
            InitializeComponent();
            zerar();

        }

        private void sorteio(object sender, EventArgs e)
        {

            Random number = new Random();

            for (int i = 1; i <= 1; i++)
                textBoxRandom.Text = Convert.ToString(number.Next(1, 76));

        }
        private void zerar() {

            UltNumero.Text = Convert.ToString(0);
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
            label11.Text = "";
            label12.Text = "";
            label13.Text = "";
            label13.Text = "";
            label14.Text = "";
            label15.Text = "";
            label16.Text = "";
            label17.Text = "";
            label18.Text = "";
            label19.Text = "";
            label20.Text = "";
            label21.Text = "";
            label22.Text = "";
            label23.Text = "";
            label24.Text = "";
            label25.Text = "";
            label26.Text = "";
            label27.Text = "";
            label28.Text = "";
            label29.Text = "";
            label30.Text = "";
            label31.Text = "";
            label32.Text = "";
            label33.Text = "";
            label34.Text = "";
            label35.Text = "";
            label36.Text = "";
            label37.Text = "";
            label38.Text = "";
            label39.Text = "";
            label40.Text = "";
            label41.Text = "";
            label42.Text = "";
            label43.Text = "";
            label44.Text = "";
            label45.Text = "";
            label46.Text = "";
            label47.Text = "";
            label48.Text = "";
            label49.Text = "";
            label50.Text = "";
            label51.Text = "";
            label52.Text = "";
            label53.Text = "";
            label54.Text = "";
            label55.Text = "";
            label56.Text = "";
            label57.Text = "";
            label58.Text = "";
            label59.Text = "";
            label60.Text = "";
            label61.Text = "";
            label62.Text = "";
            label63.Text = "";
            label64.Text = "";
            label65.Text = "";
            label66.Text = "";
            label67.Text = "";
            label68.Text = "";
            label69.Text = "";
            label70.Text = "";
            label71.Text = "";
            label72.Text = "";
            label73.Text = "";
            label74.Text = "";
            label75.Text = "";
            labelItensSelecionados.Text = "0";
        }
        private void btnZerar_Click(object sender, EventArgs e)
        {
            zerar();
        }

        private void txtNumManual_KeyUp(object sender, KeyEventArgs e)
        {
   
            if (e.KeyCode == Keys.Enter)
            {
                BtnAddNum_Click(sender, e);
            }
        }
        private void BtnSortear_Click(object sender, EventArgs e)
        {
          
            bool tentaDenovo = true;
            while (tentaDenovo)

                if (Convert.ToInt32(labelItensSelecionados.Text) < 75)
                {
                    {
                        if (labelItensSelecionados.Text == "0")
                        {
                         
                            MessageBox.Show("Jogo Iniciado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        sorteio(sender, e);

                        {
                            for (int i = 1; i < 76; i++)
                            {
                                if (textBoxRandom.Text == Convert.ToString(i))
                                {

                                    foreach (Control x in PanelNum.Controls)
                                    {
                                        if (x is Label)
                                        {

                                            if (((Label)x).Name == "label" + i)
                                            {
                                                if (((Label)x).Text == "")
                                                {
                                                    ((Label)x).Text = textBoxRandom.Text;
                                                    
                                                    tentaDenovo = false;
                                                    labelItensSelecionados.Text = Convert.ToString(Convert.ToInt32(labelItensSelecionados.Text) + 1);
                                                    try
                                                    {
                                                       anunciaNum();
                                                       
                                                    }
                                                    catch { }
                                                    
                                                    
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                else
                {
                    
                    MessageBox.Show("Jogo Concluído", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnZerar_Click(sender, e);
                    tentaDenovo = false;
                }


        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            labelFesta.Text = textfesta.Text;
            labelPremiotxt.Text = textPremio.Text;
        }

        private void chekAlternaModo_CheckedChanged(object sender, EventArgs e)
        {
            if (chekAlternaModo.Checked == true)
            {
                textBoxRandom.Visible = true;
                textBoxRandom.ReadOnly = false;
                BtnSortear.Visible = false;
                BtnAddNum.Visible = true;
                textBoxRandom.Clear();
            }
            else
            {
                textBoxRandom.Visible = false;
                textBoxRandom.ReadOnly = true;
                BtnSortear.Visible = true;
                BtnAddNum.Visible = false;
                textBoxRandom.Clear();
            }

        }

        private void BtnAddNum_Click(object sender, EventArgs e)
        {
            
            if (labelItensSelecionados.Text == "0")
            {   
                MessageBox.Show("Jogo Iniciado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                for (int i = 1; i < 76; i++)
                {
                    if (textBoxRandom.Text == Convert.ToString(i))
                    {

                        foreach (Control x in PanelNum.Controls)
                        {
                            if (x is Label)
                            {

                                if (((Label)x).Name == "label" + i)
                                {
                                    if (((Label)x).Text == "")
                                    {
                                        ((Label)x).Text = textBoxRandom.Text;
                                       

                                        labelItensSelecionados.Text = Convert.ToString(Convert.ToInt32(labelItensSelecionados.Text) + 1);
                                        try
                                        {
                                            anunciaNum();
                                        }
                                        catch { }
                                    }
                                 }
                            }
                        }
                    }
              }
        }
        private void anunciaNum()
        {
            SpeechSynthesizer fala = new SpeechSynthesizer();
            fala.Speak("");
            if (Convert.ToInt16(textBoxRandom.Text) <= 15)
            {
                UltNumero.Text = "B" + textBoxRandom.Text;
                fala.Speak("B." + textBoxRandom.Text);
                
            }
            else if (Convert.ToInt16(textBoxRandom.Text) <= 30)
            {
                UltNumero.Text = "I" + textBoxRandom.Text;
                fala.Speak("I." + textBoxRandom.Text);
            }
            else if (Convert.ToInt16(textBoxRandom.Text) <= 45)
            {
                UltNumero.Text = "N" + textBoxRandom.Text;
                fala.Speak("N." + textBoxRandom.Text);
            }
            else if (Convert.ToInt16(textBoxRandom.Text) <= 60)
            {
                UltNumero.Text = "G" + textBoxRandom.Text;
                fala.Speak("G" + textBoxRandom.Text);
            }
            else if (Convert.ToInt16(textBoxRandom.Text) <= 75)
            {
                UltNumero.Text = "O" + textBoxRandom.Text;
                fala.Speak("O." + textBoxRandom.Text);
            }
        }
    }
}     


    



                                                                                            
                                  

        

 
    

        