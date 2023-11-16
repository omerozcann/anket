using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace anket2023
{
    public partial class anketFrm : Form
    {
        String[] sorular,cevaplar;
        int anketsayaci;
        public anketFrm()
        {
            InitializeComponent();
        }

        private void kaydetbtn_Click(object sender, EventArgs e)
        {
            String str=sorutxt.Text+";"+sec1txt.Text+";"+sec2txt.Text+";"+sec3txt.Text+"\n";
            File.AppendAllText("anketsorulari.txt",str);
        }

        private void listelebtn_Click(object sender, EventArgs e)
        {
            String[] dizi = File.ReadAllLines("anketsorulari.txt");
            listelst.Items.AddRange(dizi);
        }

        private void baslatbtn_Click(object sender, EventArgs e)
        {
            anketsayaci = 0;
            sorular= File.ReadAllLines("anketsorulari.txt");
            String[] soru = sorular[anketsayaci].Split(';');
            sorrtb.Text = soru[0];
            sec1rb.Text = soru[1];
            sec2rb.Text = soru[2];
            sec3rb.Text = soru[3];
        }

        private void ilerlebtn_Click(object sender, EventArgs e)
        {
            if(sec1rb.Checked==true) 
            {
            File.AppendAllText("cevaplar.txt",sorrtb.Text+";"+sec1rb.Text+"\n");
            }
            if (sec2rb.Checked == true)
            {
                File.AppendAllText("cevaplar.txt", sorrtb.Text + ";" + sec2rb.Text+"\n");
            }
            if (sec3rb.Checked == true)
            {
                File.AppendAllText("cevaplar.txt", sorrtb.Text + ";" + sec3rb.Text + "\n");
            }
            
            anketsayaci++;
            if (anketsayaci < sorular.Length)
            {
                String[] soru = sorular[anketsayaci].Split(';');
                sorrtb.Text = soru[0];
                sec1rb.Text = soru[1];
                sec2rb.Text = soru[2];
                sec3rb.Text = soru[3];
            }
            else
            {
                MessageBox.Show("Anket Tamamlandı");
            }
        }

        private void sgosterbtn_Click(object sender, EventArgs e)
        {
            istatistiklst.Items.Clear();
            anketsayaci = 0;
            sorular = File.ReadAllLines("anketsorulari.txt");
            
            cevaplar = File.ReadAllLines("cevaplar.txt");

            for (int j = 0; j < sorular.Length; j++)
            {
                String[] soru = sorular[j].Split(';');
                int s1=0,s2=0,s3=0;
                for (int i = 0; i < cevaplar.Length; i++)
                {
                    String[] cevap = cevaplar[i].Split(';');
                    
                    if (soru[0] == cevap[0])
                    {
                        
                        if (soru[1] == cevap[1])
                        {
                            s1++;
                        }
                        if (soru[2] == cevap[1])
                        {
                            s2++;
                        }
                        if (soru[3] == cevap[1])
                        {
                            s3++;
                        }
                    }
                }
                istatistiklst.Items.Add(soru[0] + " " + soru[1] + ":" + s1 + " " + soru[2] + ":" + s2 + " " + soru[3] + ":" + s3);
            }
            //sorrtb.Text = soru[0];
            //sec1rb.Text = soru[1];
            //sec2rb.Text = soru[2];
            //sec3rb.Text = soru[3];

        }
    }
}
