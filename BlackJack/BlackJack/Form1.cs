using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class Form1 : Form
    {
        int[] fr;
        int sEu, sDealer;
        int nrAeu, nrAdealer;
        List<int> cartiEu;
        List<int> cartiDealer;
        Random rnd;
        string strCartiEu="", strCartiDealer="";
        bool ok = false;
        bool ok2 = false;

        public Form1()
        {
            InitializeComponent();
            fr = new int[20];
            cartiDealer = new List<int>();
            cartiEu = new List<int>();
            rnd = new Random();
            nrAdealer = 0;
            nrAeu = 0;
            sEu = sDealer = 0;
        }       

        int createRandomCard()
        {
            
            int valoare = rnd.Next(2, 15);
            return valoare;
        }

        int verificareSiReturnare(int tura)
        {
            int val = createRandomCard();
            while(fr[val]>=4 || (tura==1 &&nrAeu!=0 && val==11) || (tura==2 && nrAdealer!=0 && val==11))
            {
                val = createRandomCard();
            }
            fr[val]++;

            if (tura==2)
            {
                if (sDealer == 0)
                    val = 11;
                else
                    val = 5;
            }
            return val;
        }

        void adaugareCarteDealer(int carte)
        {
            cartiDealer.Add(carte);
        }

        void adaugareCarteEu(int carte)
        {
            cartiEu.Add(carte);
        }

        string valToStr(int valoare)
        {
            if (valoare > 0 && valoare <= 10)
                return valoare.ToString();
            else if (valoare == 11)
                return "A";
            else if (valoare == 12)
                return "J";
            else if (valoare == 13)
                return "Q";
            else if (valoare == 14)
                return "K";
            return "0";
        }

        private void hit_Click(object sender, EventArgs e)
        {
            int valoare;

            valoare = verificareSiReturnare(1);
            strCartiEu += valToStr(valoare) + " ";
            player.Text = strCartiEu;
            Application.DoEvents();
            adaugareCarteEu(valoare);
            if (valoare == 11)
                nrAeu++;
            if (valoare >= 10 && valoare < 15)
                sEu += 10;
            else
                sEu += valoare;
            afisareSumPlayer();
            if (nrAeu!=0)
            {
                if(sEu-9>21)
                {
                    stand.Visible = false;
                    hit.Visible = false;
                    split.Visible = true;
                    label1.Visible = true;
                    label1.Text = "Dealer Won";
                }
            }
            else
            {
                if (sEu > 21)
                {
                    stand.Visible = false;
                    hit.Visible = false;
                    split.Visible = true;
                    label1.Visible = true;
                    label1.Text = "Dealer Won";
                }
            }
        }

        private void verdict()
        {
            label1.Visible = true;
            if (sDealer > 21)
            {
                label1.Text = "You Won";
            }
            else
            {
                if (nrAeu!=0)
                {
                    if (sEu + 1 <= 21)
                        sEu++;
                    else
                        sEu -= 9;
                }
                if (nrAdealer!= 0)
                {
                    if (sDealer + 1 <= 21)
                        sDealer++;
                    else
                        sDealer-= 9;
                }
                if (21 - sDealer < 21 - sEu)
                    label1.Text = "Dealer Won";
                else if (21 - sDealer > 21 - sEu)
                    label1.Text = "You Won";
                else
                    label1.Text = "Even";
            }

            hit.Visible = false;
            stand.Visible = false;
            split.Visible = true;
        }

        private void stand_Click(object sender, EventArgs e)
        {
            int valoare;
            while(sDealer<16)
            {
                if (nrAdealer > 0 && sDealer + 1 >= 16)
                    break;
                valoare = verificareSiReturnare(2);
                adaugareCarteDealer(valoare);
                strCartiDealer += valToStr(valoare) + " ";
                dealer.Text = strCartiDealer;
                if (valoare == 11)
                    nrAdealer++;
                if (valoare >= 10 && valoare < 15)
                    sDealer += 10;
                else
                    sDealer += valoare;
                if (nrAdealer!=0)
                {
                    if (sDealer+1>21 && ok==false)
                    {
                        sDealer -= 9;
                        ok = true;
                    }
                }
                
                afisareSumDealer();
                Application.DoEvents();
                System.Threading.Thread.Sleep(1000);
            }

            verdict();

            

        }
        void afisareSumPlayer()
        {
            if (nrAeu!=0)
            {
                if (sEu+1<=21)
                {
                    splayer.Text = (sEu+1).ToString() + "/" + (sEu - 9).ToString();
                }
                else
                {
                    splayer.Text = (sEu - 9).ToString();
                }
            }
            else
            {
                splayer.Text = sEu.ToString();
            }
        }

        void afisareSumDealer()
        {
            if (nrAdealer != 0 && ok == false)
            {
                if (sDealer + 1 <= 21)
                {
                    sdealer.Text = (sDealer + 1).ToString() + "/" + (sDealer - 9).ToString();
                }
                else
                {
                    sdealer.Text = (sDealer - 10).ToString();
                }
            }
            else
            {
                sdealer.Text = sDealer.ToString();
            }
        }

        private void split_Click(object sender, EventArgs e)
        {
            hit.Visible = true;
            stand.Visible = true;
            label1.Visible = false;
            Application.DoEvents();
            dealer.Text = "";
            player.Text = "";
            splayer.Text = "";
            sdealer.Text = "";
            strCartiDealer = "";
            strCartiEu = "";
            sEu = 0;
            sDealer = 0;
            nrAdealer = 0;
            nrAeu = 0;
            ok = false;
            ok2 = false;

            for (int i = 2; i <= 15; ++i)
                fr[i] = 0;
            cartiEu.Clear();
            cartiDealer.Clear();
            int valoare;

            valoare = verificareSiReturnare(1);
            strCartiEu += valToStr(valoare) + " ";
            player.Text = strCartiEu;
            adaugareCarteEu(valoare);
            if (valoare == 11)
                nrAeu++;
            if (valoare >= 10 && valoare < 15)
                sEu += 10;
            else
                sEu += valoare;
            Application.DoEvents();
            System.Threading.Thread.Sleep(500);

            valoare = verificareSiReturnare(2);
            adaugareCarteDealer(valoare);
            strCartiDealer += valToStr(valoare) + " ";
            dealer.Text = strCartiDealer;
            if (valoare == 11)
                nrAdealer++;
            if (valoare >= 10 && valoare < 15)
                sDealer += 10;
            else
                sDealer += valoare;
            Application.DoEvents();
            System.Threading.Thread.Sleep(500);

            valoare = verificareSiReturnare(1);
            adaugareCarteEu(valoare);
            strCartiEu += valToStr(valoare) + " ";
            player.Text = strCartiEu;
            if (valoare == 11)
                nrAeu++;
            if (valoare >= 10 && valoare < 15)
                sEu += 10;
            else
                sEu += valoare;


            afisareSumPlayer();
            afisareSumDealer();


            split.Visible = false;

        }
    }
}
