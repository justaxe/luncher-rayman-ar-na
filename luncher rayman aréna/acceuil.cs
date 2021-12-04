using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Web.WebView2.Core;
using System.IO;

namespace luncher_rayman_aréna
{


   


    public partial class acceuil : Form
    {



        string cheminfichier = @"game\HD\arenaPatch.cfg "; //chemain fichier txt carte reseau
        string cheminfichier2 = @"game\SD\arenaPatch.cfg "; //chemain fichier txt carte reseau
        string cheminfichierLangue = @"fils\Langue.txt "; //chemain fichier txt carte reseau


        string curItem; //contenue de l'asenseur selectionner carte reseau

       

      

        public acceuil()
        {



       








            InitializeComponent();




            //test si le fichier txt est present (partie langue)
            if (!File.Exists(cheminfichierLangue))
            {
                File.WriteAllText(cheminfichierLangue, "EN");
                changelangue.SelectedIndex = 0;
                choixlangue();
            }
            else
            {
                string lecture = File.ReadAllText(cheminfichierLangue);

                if (lecture == "EN")
                {
                    changelangue.SelectedIndex = 0;
                    choixlangue();

                }
                else if (lecture == "FR")
                {
                    changelangue.SelectedIndex = 1;
                    choixlangue();

                }
                else if (lecture == "ES")
                {
                    changelangue.SelectedIndex = 2;
                    choixlangue();

                }
            }

            








            // affiche les interface reseau au demarrage
            Adapters obj = new Adapters();
            var value = obj.net_adapters();
            foreach (var name in value) { comboBox1.Items.Add(name); Console.WriteLine(name); }

            comboBox1.SelectedIndex = 0; // combo carte reseau

            int radminok = 0; //radmin vpn installer


            //test si le fichier txt est present
            if (!File.Exists(cheminfichier))
            {
                //MessageBox.Show("fichier non present");
                foreach (var name in value)  // on cherche si la personne a bien radmin vpn sur son pc
                {
                    if (name == "Radmin VPN")
                    {
                        radminok = 1;
                    }
                }

                if (radminok == 0) // si il la pas on  l'avertie de l'installer
                {
                    MessageBox.Show(Pasradmin);
                }
                else
                {
                    File.WriteAllText(cheminfichier, "Radmin VPN");
                    File.WriteAllText(cheminfichier2, "Radmin VPN");
                }

            }




                Choixperso1.Text = "Rayman";
            Choixperso1.Items.Insert(0, "Rayman");
            Choixperso1.SelectedIndex = 0;
            skin1.SelectedIndex = 0;
            empl1.SelectedIndex = 0;

            Choixperso2.Text = "Rayman";
            Choixperso2.Items.Insert(0, "Rayman");
            Choixperso2.SelectedIndex = 0;
            skin2.SelectedIndex = 0;
            empl2.SelectedIndex = 0;


            Choixperso3.Text = "Rayman";
            Choixperso3.Items.Insert(0, "Rayman");
            Choixperso3.SelectedIndex = 0;
            skin3.SelectedIndex = 0;
            empl3.SelectedIndex = 0;

            Choixperso4.Text = "Rayman";
            Choixperso4.Items.Insert(0, "Rayman");
            Choixperso4.SelectedIndex = 0;
            skin4.SelectedIndex = 0;
            empl4.SelectedIndex = 0;

        }

        // variable global
        string messageboxLangue = "";
        string messageboxNoVideo = "game intro videos have been disabled";
        string messageboxOkVideo= "the game's intro videos have been reactivated";
        string Choixcard = " well was to select";
        string Pasradmin = "we have detected that you do not have Radmin Vpn installed. This program is required to play the game online";
        string CopieNomReseau = "the network name has been copied to the clipboard";
        string CopieMdpReseau = "the network passord has been copied to the clipboard";




        void Choiximagetexturecustom()
        {
            //choix rayman
            if (Choixperso1.SelectedIndex.ToString() == "0")
            {

                if (skin1.SelectedIndex.ToString() == "0")
                {
                    photoskin1.Image = Properties.Resources.r5;
                }
                else if (skin1.SelectedIndex.ToString() == "1")
                {
                    photoskin1.Image = Properties.Resources.r1;
                }
                else if (skin1.SelectedIndex.ToString() == "2")
                {
                    photoskin1.Image = Properties.Resources.r2;
                }
                else if (skin1.SelectedIndex.ToString() == "3")
                {
                    photoskin1.Image = Properties.Resources.r3;
                }
                else if (skin1.SelectedIndex.ToString() == "4")
                {
                    photoskin1.Image = Properties.Resources.r4;
                }
            }

            //choix razor
            if (Choixperso1.SelectedIndex.ToString() == "1")
            {

                if (skin1.SelectedIndex.ToString() == "0")
                {
                    photoskin1.Image = Properties.Resources.ra5;
                }
                else if (skin1.SelectedIndex.ToString() == "1")
                {
                    photoskin1.Image = Properties.Resources.ra1;
                }
                else if (skin1.SelectedIndex.ToString() == "2")
                {
                    photoskin1.Image = Properties.Resources.ra2;
                }
                else if (skin1.SelectedIndex.ToString() == "3")
                {
                    photoskin1.Image = Properties.Resources.ra3;
                }
                else if (skin1.SelectedIndex.ToString() == "4")
                {
                    photoskin1.Image = Properties.Resources.ra4;
                }
            }

            //choix razorwife
            if (Choixperso1.SelectedIndex.ToString() == "2")
            {

                if (skin1.SelectedIndex.ToString() == "0")
                {
                    photoskin1.Image = Properties.Resources.rw4;
                }
                else if (skin1.SelectedIndex.ToString() == "1")
                {
                    photoskin1.Image = Properties.Resources.rw1;
                }
                else if (skin1.SelectedIndex.ToString() == "2")
                {
                    photoskin1.Image = Properties.Resources.rw2;
                }
                else if (skin1.SelectedIndex.ToString() == "3")
                {
                    photoskin1.Image = Properties.Resources.rw3;
                }
            }
            //choix globox
            if (Choixperso1.SelectedIndex.ToString() == "3")
            {

                if (skin1.SelectedIndex.ToString() == "0")
                {
                    photoskin1.Image = Properties.Resources.g5;
                }
                else if (skin1.SelectedIndex.ToString() == "1")
                {
                    photoskin1.Image = Properties.Resources.g1;
                }
                else if (skin1.SelectedIndex.ToString() == "2")
                {
                    photoskin1.Image = Properties.Resources.g2;
                }
                else if (skin1.SelectedIndex.ToString() == "3")
                {
                    photoskin1.Image = Properties.Resources.g3;
                }
                else if (skin1.SelectedIndex.ToString() == "4")
                {
                    photoskin1.Image = Properties.Resources.g4;
                }
                else if (skin1.SelectedIndex.ToString() == "5")
                {
                    photoskin1.Image = Properties.Resources.g6;
                }
            }
            //choix huchman
            if (Choixperso1.SelectedIndex.ToString() == "4")
            {

                if (skin1.SelectedIndex.ToString() == "0")
                {
                    photoskin1.Image = Properties.Resources.h3;
                }
                else if (skin1.SelectedIndex.ToString() == "1")
                {
                    photoskin1.Image = Properties.Resources.h1;
                }
                else if (skin1.SelectedIndex.ToString() == "2")
                {
                    photoskin1.Image = Properties.Resources.h2;
                }
            }
            //choix ptizetre
            if (Choixperso1.SelectedIndex.ToString() == "5")
            {

                if (skin1.SelectedIndex.ToString() == "0")
                {
                    photoskin1.Image = Properties.Resources.p3;
                }
                else if (skin1.SelectedIndex.ToString() == "1")
                {
                    photoskin1.Image = Properties.Resources.p1;
                }
                else if (skin1.SelectedIndex.ToString() == "2")
                {
                    photoskin1.Image = Properties.Resources.p2;
                }
            }

            //choix tily
            if (Choixperso1.SelectedIndex.ToString() == "6")
            {

                if (skin1.SelectedIndex.ToString() == "0")
                {
                    photoskin1.Image = Properties.Resources.t5;
                }
                else if (skin1.SelectedIndex.ToString() == "1")
                {
                    photoskin1.Image = Properties.Resources.t1;
                }
                else if (skin1.SelectedIndex.ToString() == "2")
                {
                    photoskin1.Image = Properties.Resources.t2;
                }
                else if (skin1.SelectedIndex.ToString() == "3")
                {
                    photoskin1.Image = Properties.Resources.t3;
                }
                else if (skin1.SelectedIndex.ToString() == "4")
                {
                    photoskin1.Image = Properties.Resources.t4;
                }
            }

        }

        void Choiximagetexturecustom2()
        {
            //choix rayman
            if (Choixperso2.SelectedIndex.ToString() == "0")
            {

                if (skin2.SelectedIndex.ToString() == "0")
                {
                    photoskin2.Image = Properties.Resources.r5;
                }
                else if (skin2.SelectedIndex.ToString() == "1")
                {
                    photoskin2.Image = Properties.Resources.r1;
                }
                else if (skin2.SelectedIndex.ToString() == "2")
                {
                    photoskin2.Image = Properties.Resources.r2;
                }
                else if (skin2.SelectedIndex.ToString() == "3")
                {
                    photoskin2.Image = Properties.Resources.r3;
                }
                else if (skin2.SelectedIndex.ToString() == "4")
                {
                    photoskin2.Image = Properties.Resources.r4;
                }
            }

            //choix razor
            if (Choixperso2.SelectedIndex.ToString() == "1")
            {

                if (skin2.SelectedIndex.ToString() == "0")
                {
                    photoskin2.Image = Properties.Resources.ra5;
                }
                else if (skin2.SelectedIndex.ToString() == "1")
                {
                    photoskin2.Image = Properties.Resources.ra1;
                }
                else if (skin2.SelectedIndex.ToString() == "2")
                {
                    photoskin2.Image = Properties.Resources.ra2;
                }
                else if (skin2.SelectedIndex.ToString() == "3")
                {
                    photoskin2.Image = Properties.Resources.ra3;
                }
                else if (skin2.SelectedIndex.ToString() == "4")
                {
                    photoskin2.Image = Properties.Resources.ra4;
                }
            }

            //choix razorwife
            if (Choixperso2.SelectedIndex.ToString() == "2")
            {

                if (skin2.SelectedIndex.ToString() == "0")
                {
                    photoskin2.Image = Properties.Resources.rw4;
                }
                else if (skin2.SelectedIndex.ToString() == "1")
                {
                    photoskin2.Image = Properties.Resources.rw1;
                }
                else if (skin2.SelectedIndex.ToString() == "2")
                {
                    photoskin2.Image = Properties.Resources.rw2;
                }
                else if (skin2.SelectedIndex.ToString() == "3")
                {
                    photoskin2.Image = Properties.Resources.rw3;
                }
            }
            //choix globox
            if (Choixperso2.SelectedIndex.ToString() == "3")
            {

                if (skin2.SelectedIndex.ToString() == "0")
                {
                    photoskin2.Image = Properties.Resources.g5;
                }
                else if (skin2.SelectedIndex.ToString() == "1")
                {
                    photoskin2.Image = Properties.Resources.g1;
                }
                else if (skin2.SelectedIndex.ToString() == "2")
                {
                    photoskin2.Image = Properties.Resources.g2;
                }
                else if (skin2.SelectedIndex.ToString() == "3")
                {
                    photoskin2.Image = Properties.Resources.g3;
                }
                else if (skin2.SelectedIndex.ToString() == "4")
                {
                    photoskin2.Image = Properties.Resources.g4;
                }
                else if (skin2.SelectedIndex.ToString() == "5")
                {
                    photoskin2.Image = Properties.Resources.g6;
                }
            }
            //choix huchman
            if (Choixperso2.SelectedIndex.ToString() == "4")
            {

                if (skin2.SelectedIndex.ToString() == "0")
                {
                    photoskin2.Image = Properties.Resources.h3;
                }
                else if (skin2.SelectedIndex.ToString() == "1")
                {
                    photoskin2.Image = Properties.Resources.h1;
                }
                else if (skin2.SelectedIndex.ToString() == "2")
                {
                    photoskin2.Image = Properties.Resources.h2;
                }
            }
            //choix ptizetre
            if (Choixperso2.SelectedIndex.ToString() == "5")
            {

                if (skin2.SelectedIndex.ToString() == "0")
                {
                    photoskin2.Image = Properties.Resources.p3;
                }
                else if (skin2.SelectedIndex.ToString() == "1")
                {
                    photoskin2.Image = Properties.Resources.p1;
                }
                else if (skin2.SelectedIndex.ToString() == "2")
                {
                    photoskin2.Image = Properties.Resources.p2;
                }
            }

            //choix tily
            if (Choixperso2.SelectedIndex.ToString() == "6")
            {

                if (skin2.SelectedIndex.ToString() == "0")
                {
                    photoskin2.Image = Properties.Resources.t5;
                }
                else if (skin2.SelectedIndex.ToString() == "1")
                {
                    photoskin2.Image = Properties.Resources.t1;
                }
                else if (skin2.SelectedIndex.ToString() == "2")
                {
                    photoskin2.Image = Properties.Resources.t2;
                }
                else if (skin2.SelectedIndex.ToString() == "3")
                {
                    photoskin2.Image = Properties.Resources.t3;
                }
                else if (skin2.SelectedIndex.ToString() == "4")
                {
                    photoskin2.Image = Properties.Resources.t4;
                }
            }

        }


        void Choiximagetexturecustom3()
        {
            //choix rayman
            if (Choixperso3.SelectedIndex.ToString() == "0")
            {

                if (skin3.SelectedIndex.ToString() == "0")
                {
                    photoskin3.Image = Properties.Resources.r5;
                }
                else if (skin3.SelectedIndex.ToString() == "1")
                {
                    photoskin3.Image = Properties.Resources.r1;
                }
                else if (skin3.SelectedIndex.ToString() == "2")
                {
                    photoskin3.Image = Properties.Resources.r2;
                }
                else if (skin3.SelectedIndex.ToString() == "3")
                {
                    photoskin3.Image = Properties.Resources.r3;
                }
                else if (skin3.SelectedIndex.ToString() == "4")
                {
                    photoskin3.Image = Properties.Resources.r4;
                }
            }

            //choix razor
            if (Choixperso3.SelectedIndex.ToString() == "1")
            {

                if (skin3.SelectedIndex.ToString() == "0")
                {
                    photoskin3.Image = Properties.Resources.ra5;
                }
                else if (skin3.SelectedIndex.ToString() == "1")
                {
                    photoskin3.Image = Properties.Resources.ra1;
                }
                else if (skin3.SelectedIndex.ToString() == "2")
                {
                    photoskin3.Image = Properties.Resources.ra2;
                }
                else if (skin3.SelectedIndex.ToString() == "3")
                {
                    photoskin3.Image = Properties.Resources.ra3;
                }
                else if (skin3.SelectedIndex.ToString() == "4")
                {
                    photoskin3.Image = Properties.Resources.ra4;
                }
            }

            //choix razorwife
            if (Choixperso3.SelectedIndex.ToString() == "2")
            {

                if (skin3.SelectedIndex.ToString() == "0")
                {
                    photoskin3.Image = Properties.Resources.rw4;
                }
                else if (skin3.SelectedIndex.ToString() == "1")
                {
                    photoskin3.Image = Properties.Resources.rw1;
                }
                else if (skin3.SelectedIndex.ToString() == "2")
                {
                    photoskin3.Image = Properties.Resources.rw2;
                }
                else if (skin3.SelectedIndex.ToString() == "3")
                {
                    photoskin3.Image = Properties.Resources.rw3;
                }
            }
            //choix globox
            if (Choixperso3.SelectedIndex.ToString() == "3")
            {

                if (skin3.SelectedIndex.ToString() == "0")
                {
                    photoskin3.Image = Properties.Resources.g5;
                }
                else if (skin3.SelectedIndex.ToString() == "1")
                {
                    photoskin3.Image = Properties.Resources.g1;
                }
                else if (skin3.SelectedIndex.ToString() == "2")
                {
                    photoskin3.Image = Properties.Resources.g2;
                }
                else if (skin3.SelectedIndex.ToString() == "3")
                {
                    photoskin3.Image = Properties.Resources.g3;
                }
                else if (skin3.SelectedIndex.ToString() == "4")
                {
                    photoskin3.Image = Properties.Resources.g4;
                }
                else if (skin3.SelectedIndex.ToString() == "5")
                {
                    photoskin3.Image = Properties.Resources.g6;
                }
            }
            //choix huchman
            if (Choixperso3.SelectedIndex.ToString() == "4")
            {

                if (skin3.SelectedIndex.ToString() == "0")
                {
                    photoskin3.Image = Properties.Resources.h3;
                }
                else if (skin3.SelectedIndex.ToString() == "1")
                {
                    photoskin3.Image = Properties.Resources.h1;
                }
                else if (skin3.SelectedIndex.ToString() == "2")
                {
                    photoskin3.Image = Properties.Resources.h2;
                }
            }
            //choix ptizetre
            if (Choixperso3.SelectedIndex.ToString() == "5")
            {

                if (skin3.SelectedIndex.ToString() == "0")
                {
                    photoskin3.Image = Properties.Resources.p3;
                }
                else if (skin3.SelectedIndex.ToString() == "1")
                {
                    photoskin3.Image = Properties.Resources.p1;
                }
                else if (skin3.SelectedIndex.ToString() == "2")
                {
                    photoskin3.Image = Properties.Resources.p2;
                }
            }

            //choix tily
            if (Choixperso3.SelectedIndex.ToString() == "6")
            {

                if (skin3.SelectedIndex.ToString() == "0")
                {
                    photoskin3.Image = Properties.Resources.t5;
                }
                else if (skin3.SelectedIndex.ToString() == "1")
                {
                    photoskin3.Image = Properties.Resources.t1;
                }
                else if (skin3.SelectedIndex.ToString() == "2")
                {
                    photoskin3.Image = Properties.Resources.t2;
                }
                else if (skin3.SelectedIndex.ToString() == "3")
                {
                    photoskin3.Image = Properties.Resources.t3;
                }
                else if (skin3.SelectedIndex.ToString() == "4")
                {
                    photoskin3.Image = Properties.Resources.t4;
                }
            }

        }

        void Choiximagetexturecustom4()
        {
            //choix rayman
            if (Choixperso4.SelectedIndex.ToString() == "0")
            {

                if (skin4.SelectedIndex.ToString() == "0")
                {
                    photoskin4.Image = Properties.Resources.r5;
                }
                else if (skin4.SelectedIndex.ToString() == "1")
                {
                    photoskin4.Image = Properties.Resources.r1;
                }
                else if (skin4.SelectedIndex.ToString() == "2")
                {
                    photoskin4.Image = Properties.Resources.r2;
                }
                else if (skin4.SelectedIndex.ToString() == "3")
                {
                    photoskin4.Image = Properties.Resources.r3;
                }
                else if (skin4.SelectedIndex.ToString() == "4")
                {
                    photoskin4.Image = Properties.Resources.r4;
                }
            }

            //choix razor
            if (Choixperso4.SelectedIndex.ToString() == "1")
            {

                if (skin4.SelectedIndex.ToString() == "0")
                {
                    photoskin4.Image = Properties.Resources.ra5;
                }
                else if (skin4.SelectedIndex.ToString() == "1")
                {
                    photoskin4.Image = Properties.Resources.ra1;
                }
                else if (skin4.SelectedIndex.ToString() == "2")
                {
                    photoskin4.Image = Properties.Resources.ra2;
                }
                else if (skin4.SelectedIndex.ToString() == "3")
                {
                    photoskin4.Image = Properties.Resources.ra3;
                }
                else if (skin4.SelectedIndex.ToString() == "4")
                {
                    photoskin4.Image = Properties.Resources.ra4;
                }
            }

            //choix razorwife
            if (Choixperso4.SelectedIndex.ToString() == "2")
            {

                if (skin4.SelectedIndex.ToString() == "0")
                {
                    photoskin4.Image = Properties.Resources.rw4;
                }
                else if (skin4.SelectedIndex.ToString() == "1")
                {
                    photoskin4.Image = Properties.Resources.rw1;
                }
                else if (skin4.SelectedIndex.ToString() == "2")
                {
                    photoskin4.Image = Properties.Resources.rw2;
                }
                else if (skin4.SelectedIndex.ToString() == "3")
                {
                    photoskin4.Image = Properties.Resources.rw3;
                }
            }
            //choix globox
            if (Choixperso4.SelectedIndex.ToString() == "3")
            {

                if (skin4.SelectedIndex.ToString() == "0")
                {
                    photoskin4.Image = Properties.Resources.g5;
                }
                else if (skin4.SelectedIndex.ToString() == "1")
                {
                    photoskin4.Image = Properties.Resources.g1;
                }
                else if (skin4.SelectedIndex.ToString() == "2")
                {
                    photoskin4.Image = Properties.Resources.g2;
                }
                else if (skin4.SelectedIndex.ToString() == "3")
                {
                    photoskin4.Image = Properties.Resources.g3;
                }
                else if (skin4.SelectedIndex.ToString() == "4")
                {
                    photoskin4.Image = Properties.Resources.g4;
                }
                else if (skin4.SelectedIndex.ToString() == "5")
                {
                    photoskin4.Image = Properties.Resources.g6;
                }
            }
            //choix huchman
            if (Choixperso4.SelectedIndex.ToString() == "4")
            {

                if (skin4.SelectedIndex.ToString() == "0")
                {
                    photoskin4.Image = Properties.Resources.h3;
                }
                else if (skin4.SelectedIndex.ToString() == "1")
                {
                    photoskin4.Image = Properties.Resources.h1;
                }
                else if (skin4.SelectedIndex.ToString() == "2")
                {
                    photoskin4.Image = Properties.Resources.h2;
                }
            }
            //choix ptizetre
            if (Choixperso4.SelectedIndex.ToString() == "5")
            {

                if (skin4.SelectedIndex.ToString() == "0")
                {
                    photoskin4.Image = Properties.Resources.p3;
                }
                else if (skin4.SelectedIndex.ToString() == "1")
                {
                    photoskin4.Image = Properties.Resources.p1;
                }
                else if (skin4.SelectedIndex.ToString() == "2")
                {
                    photoskin4.Image = Properties.Resources.p2;
                }
            }

            //choix tily
            if (Choixperso4.SelectedIndex.ToString() == "6")
            {

                if (skin4.SelectedIndex.ToString() == "0")
                {
                    photoskin4.Image = Properties.Resources.t5;
                }
                else if (skin4.SelectedIndex.ToString() == "1")
                {
                    photoskin4.Image = Properties.Resources.t1;
                }
                else if (skin4.SelectedIndex.ToString() == "2")
                {
                    photoskin4.Image = Properties.Resources.t2;
                }
                else if (skin4.SelectedIndex.ToString() == "3")
                {
                    photoskin4.Image = Properties.Resources.t3;
                }
                else if (skin4.SelectedIndex.ToString() == "4")
                {
                    photoskin4.Image = Properties.Resources.t4;
                }
            }

        }



        private void BtnLuncheurGameFull_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }






        private async  void acceuil_Load(object sender, EventArgs e)
        {

            var webViewEnvironnement = await CoreWebView2Environment.CreateAsync(null, @"c:/temp");
            await webView22.EnsureCoreWebView2Async(webViewEnvironnement);
            webView22.CoreWebView2.Navigate("https://www.youtube.com/embed/jTdGHXCD3s8");


          





        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("cmd", @"/c copy fils\dgVoodoo\full\dgVoodoo.conf %APPDATA%\dgVoodoo\dgVoodoo.conf");
            System.Diagnostics.Process.Start("cmd", @"/c copy fils\dgVoodoo\full\dgVoodooSetupPaths.dat %APPDATA%\dgVoodoo\dgVoodooSetupPaths.dat");
            System.Diagnostics.Process.Start("cmd", @"/c start game\HD\R_Arenaadmin");
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.radmin-vpn.com/");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/sQMXyNQA");
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("cmd", @"/c copy fils\dgVoodoo\fenetre1\dgVoodoo.conf %APPDATA%\dgVoodoo\dgVoodoo.conf");
            System.Diagnostics.Process.Start("cmd", @"/c copy fils\dgVoodoo\fenetre1\dgVoodooSetupPaths.dat %APPDATA%\dgVoodoo\dgVoodooSetupPaths.dat");
            System.Diagnostics.Process.Start("cmd", @"/c start game\SD\R_Arenaadmin");
            Application.Exit();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("cmd", @"/c start game\HD\R_Arenaadmin");
            Application.Exit();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("cmd", @"/c copy fils\dgVoodoo\full\dgVoodoo.conf %APPDATA%\dgVoodoo\dgVoodoo.conf");
            System.Diagnostics.Process.Start("cmd", @"/c copy fils\dgVoodoo\full\dgVoodooSetupPaths.dat %APPDATA%\dgVoodoo\dgVoodooSetupPaths.dat");
            System.Diagnostics.Process.Start("cmd", @"/c start game\SD\R_Arenaadmin");
            Application.Exit();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("cmd", @"/c copy fils\video\vierge\Videos\Intro.bik game\SD\Videos\Intro.bik");
            System.Diagnostics.Process.Start("cmd", @"/c copy fils\video\vierge\Videos\Outro.bik game\SD\Videos\Outro.bik");
            System.Diagnostics.Process.Start("cmd", @"/c copy fils\video\vierge\Videos\Ubi.bik game\SD\Videos\Ubi.bik");

            System.Diagnostics.Process.Start("cmd", @"/c copy fils\video\vierge\Videos\Intro.bik game\HD\Videos\Intro.bik");
            System.Diagnostics.Process.Start("cmd", @"/c copy fils\video\vierge\Videos\Outro.bik game\HD\Videos\Outro.bik");
            System.Diagnostics.Process.Start("cmd", @"/c copy fils\video\vierge\Videos\Ubi.bik game\HD\Videos\Ubi.bik");
            MessageBox.Show(messageboxNoVideo);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("cmd", @"/c copy fils\video\normal\Videos\Intro.bik game\SD\Videos\Intro.bik");
            System.Diagnostics.Process.Start("cmd", @"/c copy fils\video\normal\Videos\Outro.bik game\SD\Videos\Outro.bik");
            System.Diagnostics.Process.Start("cmd", @"/c copy fils\video\normal\Videos\Ubi.bik game\SD\Videos\Ubi.bik");

            System.Diagnostics.Process.Start("cmd", @"/c copy fils\video\normal\Videos\Intro.bik game\HD\Videos\Intro.bik");
            System.Diagnostics.Process.Start("cmd", @"/c copy fils\video\normal\Videos\Outro.bik game\HD\Videos\Outro.bik");
            System.Diagnostics.Process.Start("cmd", @"/c copy fils\video\normal\Videos\Ubi.bik game\HD\Videos\Ubi.bik");
            MessageBox.Show(messageboxOkVideo);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("cmd", @"/c start game\SD\R_Arenaadmin");
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Process.Start(@"fils\RaymanControlPanel.exe");
        }

        private void button8_Click_2(object sender, EventArgs e)
        {
            Process.Start(@"game\SD\RM_Setup_DX8.exe");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Process proc = new Process(); proc.StartInfo.FileName = @"game\SD\dgVoodooCpl.exe"; proc.StartInfo.UseShellExecute = true; proc.StartInfo.Verb = "runas"; proc.Start(); 

            //System.Diagnostics.Process.Start("cmd", @"/c cd game\SD\ & start dgVoodooCpl.exe");

            Process.Start(@"dgVoodooCpl.exe");

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("cmd", @"/c copy fils\dgVoodoo\fenetre3\dgVoodoo.conf %APPDATA%\dgVoodoo\dgVoodoo.conf");
            System.Diagnostics.Process.Start("cmd", @"/c copy fils\dgVoodoo\fenetre3\dgVoodooSetupPaths.dat %APPDATA%\dgVoodoo\dgVoodooSetupPaths.dat");
            System.Diagnostics.Process.Start("cmd", @"/c start game\SD\R_Arenaadmin");
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("cmd", @"/c copy fils\dgVoodoo\fenetre2\dgVoodoo.conf %APPDATA%\dgVoodoo\dgVoodoo.conf");
            System.Diagnostics.Process.Start("cmd", @"/c copy fils\dgVoodoo\fenetre2\dgVoodooSetupPaths.dat %APPDATA%\dgVoodoo\dgVoodooSetupPaths.dat");
            System.Diagnostics.Process.Start("cmd", @"/c start game\SD\R_Arenaadmin");
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("cmd", @"/c copy fils\dgVoodoo\fenetre4\dgVoodoo.conf %APPDATA%\dgVoodoo\dgVoodoo.conf");
            System.Diagnostics.Process.Start("cmd", @"/c copy fils\dgVoodoo\fenetre4\dgVoodooSetupPaths.dat %APPDATA%\dgVoodoo\dgVoodooSetupPaths.dat");
            System.Diagnostics.Process.Start("cmd", @"/c start game\SD\R_Arenaadmin");
            Application.Exit();
        }

        private void changelangue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        void choixlangue() {

            if (changelangue.SelectedIndex.ToString() == "0")
            {
                System.Diagnostics.Process.Start("cmd", @"/c copy fils\ini\ModEN\Ubisoft\ubi.ini C:\Windows\Ubisoft\ubi.ini /Y	");

                File.WriteAllText(cheminfichierLangue, "EN");
                messageboxLangue = "the game is now in English !!";
                CopieNomReseau = "the name of the network was copied to the clipboard";
                CopieMdpReseau = "the network password has been copied to the clipboard";
                //MessageBox.Show(messageboxLangue);
                //changement de langue 

                groupBox9.Text = "Language ";
                groupBox8.Text = "To play online ";
                label8.Text = "To play online, follow this short video:";
                label20.Text = "select the language of the game:";
                label10.Text = "- To download";
                label24.Text = "- Install it on your PC";
                label11.Text = "-join the following private network:";
                label26.Text = "-select the network card \"radmin vpn\"";
                label27.Text = "-Starting the game";
                label28.Text = "-select mode \"LAN\" ";
                label29.Text = "-to play!! ";
                label30.Text = "Forgot to join the game discord";
                label31.Text = "to organize matches and many other things !! ";
                label21.Text = "choose the network card with which you play online";
                label7.Text = "name";
                label25.Text = "password";

                label1.Text = "💻 Launch the game in full screen";
                label12.Text = "Without video";
                label13.Text = "With video ";
                label14.Text = "low graphics";
                label2.Text = "💻  Launch the game in windowed mode: ";
                label9.Text = "Launch a custom config";
                groupBox7.Text = "problem / advanced settings ";
                label18.Text = "to fix ";
                label19.Text = "ask us for help";

                groupBox5.Text = "Custom skin";

                groupBox1.Text = "player 1";
                groupBox2.Text = "player 2";
                groupBox3.Text = "player 3";
                groupBox4.Text = "player 4";
                label34.Text = "Custom skin";
                label35.Text = "Custom skin";
                label38.Text = "Custom skin";
                label41.Text = "Custom skin";

                label32.Text = "character";
                label37.Text = "character";
                label40.Text = "character";
                label43.Text = "character";

                label33.Text = "locations";
                label36.Text = "locations";
                label39.Text = "locations";
                label42.Text = "locations";

                btnValidskin1.Text = "edit skin";
                btnValidskin2.Text = "edit skin";
                btnValidskin3.Text = "edit skin";
                btnValidskin4.Text = "edit skin";

                reseauSociaux.Text = "Follow us";


                button21.Text = "reset all skin to default";

                //modifie les toltip
                toolTip1.SetToolTip(button17, "for advanced users who create their own config");
                toolTip1.SetToolTip(button10, "for advanced users who create their own config");

                toolTip1.SetToolTip(button13, "leave the intro video of the game");
                toolTip1.SetToolTip(button12, "remove intro video from game");


                //modifer les boite de dialogue

                messageboxNoVideo = "game intro videos have been disabled";
                messageboxOkVideo = "the game's intro videos have been reactivated";
                Choixcard = " well was to select";
                Pasradmin = "we have detected that you do not have Radmin Vpn installed. This program is required to play the game online";

                toolTip1.SetToolTip(Modifier, "modify");


            }
            else if (changelangue.SelectedIndex.ToString() == "1")
            {
                System.Diagnostics.Process.Start("cmd", @"/c copy fils\ini\ModFR\Ubisoft\ubi.ini C:\Windows\Ubisoft\ubi.ini /Y	");

                File.WriteAllText(cheminfichierLangue, "FR");
                messageboxLangue = "le jeu est maintenant en français !!";
                //MessageBox.Show(messageboxLangue);
                CopieNomReseau = "le nom du réseau à été copié dans le presse-papiers";
                CopieMdpReseau = "le mot de passe réseau a été copié dans le presse-papiers";


                //changement de langue 

                groupBox9.Text = "Langue ";
                label8.Text = "Pour jouer en ligne suiver cette court video:";
                groupBox8.Text = "jouer en ligne ";
                label20.Text = "selectionner la langue du jeu: ";
                label10.Text = "- Telecharger";
                label24.Text = "- Installer le sur votre PC";
                label11.Text = "-rejoindre le reseau privé suivant:";
                label26.Text = "-selectionner la carte reseaux \"radmin vpn\"";
                label27.Text = "-lancer le jeu";
                label28.Text = "-selectionner le mode \"LAN\" ";
                label29.Text = "-Jouer!! ";
                label30.Text = "Oublié pas de rejoindre le discord du jeu";
                label31.Text = "pour organiser des match et plain d'autre choses!! ";
                label21.Text = "choisir la carte réseaux avec la qu'elle vous jouer en ligne ";
                label7.Text = "nom";
                label25.Text = "mot de passe";

                label1.Text = "💻 Lancer le jeu en plein écran";
                label12.Text = "Sans video ";
                label13.Text = "Avec video ";
                label14.Text = "graphisme bas";
                label2.Text = "💻 Lancer le jeu en mode fentre :";
                label9.Text = "Lancer une config personnaliser";
                groupBox7.Text = "problem / paramétres avancée ";
                label18.Text = "Réparer ";
                label19.Text = "demandez nous de l'aide";

                groupBox5.Text = "Skin personnalisée";

                groupBox1.Text = "Joueur 1";
                groupBox2.Text = "Joueur 2";
                groupBox3.Text = "Joueur 3";
                groupBox4.Text = "Joueur 4";
                label34.Text = "Skin personnalisée";
                label35.Text = "Skin personnalisée";
                label38.Text = "Skin personnalisée";
                label41.Text = "Skin personnalisée";

                label32.Text = "Personnage";
                label37.Text = "Personnage";
                label40.Text = "Personnage";
                label43.Text = "Personnage";

                label33.Text = "Emplacement";
                label36.Text = "Emplacement";
                label39.Text = "Emplacement";
                label42.Text = "Emplacement";

                btnValidskin1.Text = "modifier skin";
                btnValidskin2.Text = "modifier skin";
                btnValidskin3.Text = "modifier skin";
                btnValidskin4.Text = "modifier skin";

                button21.Text = "remettre tous les skin par default";

                reseauSociaux.Text = "Suivez-nous";

                //modifie les toltip
                toolTip1.SetToolTip(button17, "pour les utilisateur avancer qui on crée leur prpore config");
                toolTip1.SetToolTip(button10, "pour les utilisateur avancer qui on crée leur prpore config");


                toolTip1.SetToolTip(button13, "laisser les video d'introduction du jeu");
                toolTip1.SetToolTip(button12, "Enlever les video d'introduction du jeu");

                //modifer les boite de dialogue

                messageboxNoVideo = "les vidéos d'introduction du jeu ont été désactivées";
                messageboxOkVideo = "les vidéos d'introduction du jeu ont été réactivées";
                Choixcard = " bien a été sélectionné";
                Pasradmin = "nous avons détecté que vous n'avez pas installé Radmin Vpn. Ce programme est nécessaire pour jouer au jeu en ligne";


                toolTip1.SetToolTip(Modifier, "Modifier");


            }
            else if (changelangue.SelectedIndex.ToString() == "2")
            {
                System.Diagnostics.Process.Start("cmd", @"/c copy fils\ini\ModES\Ubisoft\ubi.ini C:\Windows\Ubisoft\ubi.ini /Y	");
                File.WriteAllText(cheminfichierLangue, "ES");
                messageboxLangue = "el juego ahora esta en español !! !!";
               // MessageBox.Show(messageboxLangue);
                CopieNomReseau = "el nombre de la red se ha copiado en el portapapeles";
                CopieMdpReseau = "la contraseña de la red se ha copiado en el portapapeles";


                //changement de langue 

                groupBox9.Text = "idioma ";
                label8.Text = "Para jugar en línea, siga este breve video:";
                groupBox8.Text = "jugar en línea ";
                label20.Text = "selecciona el idioma del juego: ";
                label10.Text = "- Descargar";
                label24.Text = "- Instálalo en tu PC";
                label11.Text = "-únete a la siguiente red privada:";
                label26.Text = "-seleccione la tarjeta de red \"radmin vpn\"";
                label27.Text = "-Comenzando el juego";
                label28.Text = "-Seleccionar modo \"LAN\" ";
                label29.Text = "-Para jugar!! ";
                label30.Text = "no te olvides de unirte al juego de la discord";
                label31.Text = "para organizar partidos y muchas otras cosas !! ";
                label21.Text = "elige la tarjeta de red con la que te jugará online ";
                label7.Text = "apellido";
                label25.Text = "contraseña";

                label1.Text = "💻 Inicie el juego en pantalla completa.";
                label12.Text = "No hay video ";
                label13.Text = "con video ";
                label14.Text = "gráficos bajos";
                label2.Text = "💻 Inicia el juego en modo ventana. :";
                label9.Text = "Lanzar una configuración personalizada";
                groupBox7.Text = "problema / configuración avanzada";
                label18.Text = "reparar ";
                label19.Text = "pídenos ayuda";

                groupBox5.Text = "Apariencia personalizada";

                groupBox1.Text = "Jugador 1";
                groupBox2.Text = "Jugador 2";
                groupBox3.Text = "Jugador 3";
                groupBox4.Text = "Jugador 4";
                label34.Text = "Apariencia personalizadae";
                label35.Text = "Apariencia personalizada";
                label38.Text = "Apariencia personalizada";
                label41.Text = "Apariencia personalizada";

                label32.Text = "personaje";
                label37.Text = "personaje";
                label40.Text = "personaje";
                label43.Text = "personaje";

                label33.Text = "sitio";
                label36.Text = "sitio";
                label39.Text = "sitio";
                label42.Text = "sitio";

                btnValidskin1.Text = "editar piel";
                btnValidskin2.Text = "editar piel";
                btnValidskin3.Text = "editar piel";
                btnValidskin4.Text = "editar piel";

                button21.Text = "restablecer todos los aspectos a los predeterminados";

                reseauSociaux.Text = "Síguenos";

                //modifie les toltip
                toolTip1.SetToolTip(button17, "para usuarios avanzados que crean su propia configuración");
                toolTip1.SetToolTip(button10, "para usuarios avanzados que crean su propia configuración");


                toolTip1.SetToolTip(button13, "dejar el video de introducción del juego");
                toolTip1.SetToolTip(button12, "Eliminar el video de introducción del juego");

                //modifer les boite de dialogue

                messageboxNoVideo = "Se han desactivado los vídeos de introducción al juego.";
                messageboxOkVideo = "Se reactivaron los videos de introducción del juego.";
                Choixcard = " bien fue seleccionado";
                Pasradmin = "Hemos detectado que no tiene Radmin Vpn instalado. Este programa es necesario para jugar el juego en línea.";


                toolTip1.SetToolTip(Modifier, "Editar");


            }

        }


        private void BtnChangeLangue_Click(object sender, EventArgs e)
        {

            choixlangue();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            //MessageBox.Show("the function is not yet supported. ");
            //MessageBox.Show("Please choose your card once the game has started. ");

        }

        private void Choixperso1_SelectedIndexChanged(object sender, EventArgs e)
        {
            



            if (Choixperso1.SelectedIndex.ToString() == "0")
            {
                // emplacement skin jeu

                string[] rayman = {  };
                empl1.Items.Clear();
                empl1.Items.AddRange(rayman);
                empl1.Text = "1";
                empl1.Items.Insert(0, "1");
                empl1.SelectedIndex = 0;

                //skin perso

                Choiximagetexturecustom();
                string[] raymancust = {  "1", "2", "3", "4"};
                skin1.Items.Clear();
                skin1.Items.AddRange(raymancust);
                skin1.Text = "original";
                skin1.Items.Insert(0, "original");
                skin1.SelectedIndex = 0;


            }
            else if (Choixperso1.SelectedIndex.ToString() == "1")
            {
                // emplacement skin jeu

                string[] Razor = { };
                empl1.Items.Clear();
                empl1.Items.AddRange(Razor);
                empl1.Text = "1";
                empl1.Items.Insert(0, "1");
                empl1.SelectedIndex = 0;

                //skin perso

                Choiximagetexturecustom();
                string[] Razorcust = {  "1", "2", "3", "4" };
                skin1.Items.Clear();
                skin1.Items.AddRange(Razorcust);
                skin1.Text = "original";
                skin1.Items.Insert(0, "original");
                skin1.SelectedIndex = 0;

            }
            else if (Choixperso1.SelectedIndex.ToString() == "2")
            {
                // emplacement skin jeu

                string[] Razorwife = { };
                empl1.Items.Clear();
                empl1.Items.AddRange(Razorwife);
                empl1.Text = "1";
                empl1.Items.Insert(0, "1");
                empl1.SelectedIndex = 0;


                //skin perso
                Choiximagetexturecustom();
                string[] Razorwifecust = { "1", "2", "3"};
                skin1.Items.Clear();
                skin1.Items.AddRange(Razorwifecust);
                skin1.Text = "original";
                skin1.Items.Insert(0, "original");
                skin1.SelectedIndex = 0;

            }
            else if (Choixperso1.SelectedIndex.ToString() == "3")
            {
                // emplacement skin jeu
                Choiximagetexturecustom();
                string[] globox = { "2" , "3", "4" };
                empl1.Items.Clear();
                empl1.Items.AddRange(globox);
                empl1.Text = "1";
                empl1.Items.Insert(0, "1");
                empl1.SelectedIndex = 0;

                //skin perso
                Choiximagetexturecustom();
                string[] globoxcust = {  "1","2","3","4","5"};
                skin1.Items.Clear();
                skin1.Items.AddRange(globoxcust);
                skin1.Text = "original";
                skin1.Items.Insert(0, "original");
                skin1.SelectedIndex = 0;

            }
            else if (Choixperso1.SelectedIndex.ToString() == "4")
            {
                // emplacement skin jeu

                string[] Hunchman = {  "2", "3", "4" };
                empl1.Items.Clear();
                empl1.Items.AddRange(Hunchman);
                empl1.Text = "1";
                empl1.Items.Insert(0, "1");
                empl1.SelectedIndex = 0;

                //skin perso
                Choiximagetexturecustom();
                string[] Hunchmancust = {  "1", "2"};
                skin1.Items.Clear();
                skin1.Items.AddRange(Hunchmancust);
                skin1.Text = "original";
                skin1.Items.Insert(0, "original");
                skin1.SelectedIndex = 0;
            }
            else if (Choixperso1.SelectedIndex.ToString() == "5")
            {
                // emplacement skin jeu

                string[] ptizetre = { "2", "3", "4" };
                empl1.Items.Clear();
                empl1.Items.AddRange(ptizetre);
                empl1.Text = "1";
                empl1.Items.Insert(0, "1");
                empl1.SelectedIndex = 0;


                //skin perso
                Choiximagetexturecustom();
                string[] ptizetrecust = {  "1", "2"};
                skin1.Items.Clear();
                skin1.Items.AddRange(ptizetrecust);
                skin1.Text = "original";
                skin1.Items.Insert(0, "original");
                skin1.SelectedIndex = 0;
            }
            else if (Choixperso1.SelectedIndex.ToString() == "6")
            {
                // emplacement skin jeu

                string[] Tily = { };
                empl1.Items.Clear();
                empl1.Items.AddRange(Tily);
                empl1.Text = "1";
                empl1.Items.Insert(0, "1");
                empl1.SelectedIndex = 0;

                //skin perso

                Choiximagetexturecustom();
                string[] Tilycust = {   "1", "2", "3", "4" };
                skin1.Items.Clear();
                skin1.Items.AddRange(Tilycust);
                                skin1.Text = "original";
                skin1.Items.Insert(0, "original");
                skin1.SelectedIndex = 0;


            }




        }

        private void empl1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void skin1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Choiximagetexturecustom();
        }

        private void photoskin1_Click(object sender, EventArgs e)
        {
        }

        private void Choixperso2_SelectedIndexChanged(object sender, EventArgs e)
        {

            

            if (Choixperso2.SelectedIndex.ToString() == "0")
            {
                // emplacement skin jeu

                string[] rayman = {  };
                empl2.Items.Clear();
                empl2.Items.AddRange(rayman);
                empl2.Text = "1";
                empl2.Items.Insert(0, "1");
                empl2.SelectedIndex = 0;

                //skin perso

                Choiximagetexturecustom2();
                string[] raymancust = { "original", "1", "2", "3", "4" };
                skin2.Items.Clear();
                skin2.Items.AddRange(raymancust);
                skin2.SelectedIndex = 0;

            }
            else if (Choixperso2.SelectedIndex.ToString() == "1")
            {
                // emplacement skin jeu

                string[] Razor = {  };
                empl2.Items.Clear();
                empl2.Items.AddRange(Razor);
                empl2.Text = "1";
                empl2.Items.Insert(0, "1");
                empl2.SelectedIndex = 0;

                //skin perso
                
                Choiximagetexturecustom2();
                string[] Razorcust = { "original", "1", "2", "3", "4" };
                skin2.Items.Clear();
                skin2.Items.AddRange(Razorcust);
                skin2.SelectedIndex = 0;
            }
            else if (Choixperso2.SelectedIndex.ToString() == "2")
            {
                // emplacement skin jeu

                string[] Razorwife = { };
                empl2.Items.Clear();
                empl2.Items.AddRange(Razorwife);
                empl2.Text = "1";
                empl2.Items.Insert(0, "1");
                empl2.SelectedIndex = 0;

                //skin perso
                
                Choiximagetexturecustom2();
                string[] Razorwifecust = { "original", "1", "2", "3" };
                skin2.Items.Clear();
                skin2.Items.AddRange(Razorwifecust);
                skin2.SelectedIndex = 0;
            }
            else if (Choixperso2.SelectedIndex.ToString() == "3")
            {
                // emplacement skin jeu

                string[] globox = { "2", "3", "4" };
                empl2.Items.Clear();
                empl2.Items.AddRange(globox);
                empl2.Text = "1";
                empl2.Items.Insert(0, "1");
                empl2.SelectedIndex = 0;

                //skin perso
                Choiximagetexturecustom2();
                string[] globoxcust = { "original", "1", "2", "3", "4", "5" };
                skin2.Items.Clear();
                skin2.Items.AddRange(globoxcust);
                skin2.SelectedIndex = 0;
            }
            else if (Choixperso2.SelectedIndex.ToString() == "4")
            {
                // emplacement skin jeu
                string[] Hunchman = {  "2", "3", "4" };
                empl2.Items.Clear();
                empl2.Items.AddRange(Hunchman);
                empl2.Text = "1";
                empl2.Items.Insert(0, "1");
                empl2.SelectedIndex = 0;

                //skin perso
                string[] Hunchmancust = { "original", "1", "2" };
                skin2.Items.Clear();
                skin2.Items.AddRange(Hunchmancust);
                skin2.SelectedIndex = 0;                
            }
            else if (Choixperso2.SelectedIndex.ToString() == "5")
            {
                // emplacement skin jeu
                string[] ptizetre = { "2", "3", "4" };
                empl2.Items.Clear();
                empl2.Items.AddRange(ptizetre);
                empl2.Text = "1";
                empl2.Items.Insert(0, "1");
                empl2.SelectedIndex = 0;


                //skin perso
                
                Choiximagetexturecustom2();
                string[] ptizetrecust = { "original", "1", "2" };
                skin2.Items.Clear();
                skin2.Items.AddRange(ptizetrecust);
                skin2.SelectedIndex = 0;
            }
            else if (Choixperso2.SelectedIndex.ToString() == "6")
            {
                // emplacement skin jeu

                string[] Tily = { };
                empl2.Items.Clear();
                empl2.Items.AddRange(Tily);
                empl2.Text = "1";
                empl2.Items.Insert(0, "1");
                empl2.SelectedIndex = 0;

                //skin perso
                
                Choiximagetexturecustom2();
                string[] Tilycust = { "original", "1", "2", "3", "4" };
                skin2.Items.Clear();
                skin2.Items.AddRange(Tilycust);
                skin2.SelectedIndex = 0;



            }
            
        }

        private void empl2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void skin2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Choiximagetexturecustom2();
        }

        private void skin3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Choiximagetexturecustom3();
        }

        private void skin4_SelectedIndexChanged(object sender, EventArgs e)
        {
            Choiximagetexturecustom4();
        }

        private void Choixperso3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Choixperso3.SelectedIndex.ToString() == "0")
            {
                // emplacement skin jeu

                string[] rayman = {  };
                empl3.Items.Clear();
                empl3.Items.AddRange(rayman);
                empl3.Text = "1";
                empl3.Items.Insert(0, "1");
                empl3.SelectedIndex = 0;

                //skin perso

                Choiximagetexturecustom3();
                string[] raymancust = { "original", "1", "2", "3", "4" };
                skin3.Items.Clear();
                skin3.Items.AddRange(raymancust);
                skin3.SelectedIndex = 0;

            }
            else if (Choixperso3.SelectedIndex.ToString() == "1")
            {
                // emplacement skin jeu

                string[] Razor = { };
                empl3.Items.Clear();
                empl3.Items.AddRange(Razor);
                empl3.Text = "1";
                empl3.Items.Insert(0, "1");
                empl3.SelectedIndex = 0;

                //skin perso
                
                Choiximagetexturecustom3();
                string[] Razorcust = { "original", "1", "2", "3", "4" };
                skin3.Items.Clear();
                skin3.Items.AddRange(Razorcust);
                skin3.SelectedIndex = 0;

            }
            else if (Choixperso3.SelectedIndex.ToString() == "2")
            {
                // emplacement skin jeu

                string[] Razorwife = {  };
                empl3.Items.Clear();
                empl3.Items.AddRange(Razorwife);
                empl3.Text = "1";
                empl3.Items.Insert(0, "1");
                empl3.SelectedIndex = 0;

                //skin perso
                
                Choiximagetexturecustom3();
                string[] Razorwifecust = { "original", "1", "2", "3" };
                skin3.Items.Clear();
                skin3.Items.AddRange(Razorwifecust);
                skin3.SelectedIndex = 0;
            }
            else if (Choixperso3.SelectedIndex.ToString() == "3")
            {
                // emplacement skin jeu

                string[] globox = { "2", "3", "4" };
                empl3.Items.Clear();
                empl3.Items.AddRange(globox);
                empl3.Text = "1";
                empl3.Items.Insert(0, "1");
                empl3.SelectedIndex = 0;

                //skin perso
                Choiximagetexturecustom3();
                string[] globoxcust = { "original", "1", "2", "3", "4", "5" };
                skin3.Items.Clear();
                skin3.Items.AddRange(globoxcust);
                skin3.SelectedIndex = 0;
            }
            else if (Choixperso3.SelectedIndex.ToString() == "4")
            {
                // emplacement skin jeu
                string[] Hunchman = {  "2", "3", "4" };
                empl3.Items.Clear();
                empl3.Items.AddRange(Hunchman);
                empl3.Text = "1";
                empl3.Items.Insert(0, "1");
                empl3.SelectedIndex = 0;

                //skin perso
                Choiximagetexturecustom3();
                string[] Hunchmancust = { "original", "1", "2" };
                skin3.Items.Clear();
                skin3.Items.AddRange(Hunchmancust);
                skin3.SelectedIndex = 0;
            }
            else if (Choixperso3.SelectedIndex.ToString() == "5")
            {
                // emplacement skin jeu

                string[] ptizetre = { "2", "3", "4" };
                empl3.Items.Clear();
                empl3.Items.AddRange(ptizetre);
                empl3.Text = "1";
                empl3.Items.Insert(0, "1");
                empl3.SelectedIndex = 0;


                //skin perso
                Choiximagetexturecustom3();
                string[] ptizetrecust = { "original", "1", "2" };
                skin3.Items.Clear();
                skin3.Items.AddRange(ptizetrecust);
                skin3.SelectedIndex = 0;
            }
            else if (Choixperso3.SelectedIndex.ToString() == "6")
            {
                // emplacement skin jeu

                string[] Tily = { };
                empl3.Items.Clear();
                empl3.Items.AddRange(Tily);
                empl3.Text = "1";
                empl3.Items.Insert(0, "1");
                empl3.SelectedIndex = 0;

                //skin perso
                
                Choiximagetexturecustom3();
                string[] Tilycust = { "original", "1", "2", "3", "4" };
                skin3.Items.Clear();
                skin3.Items.AddRange(Tilycust);
                skin3.SelectedIndex = 0;



            }
        }

        private void Choixperso4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Choixperso4.SelectedIndex.ToString() == "0")
            {
                // emplacement skin jeu

                string[] rayman = {  };
                empl4.Items.Clear();
                empl4.Items.AddRange(rayman);
                empl4.Text = "1";
                empl4.Items.Insert(0, "1");
                empl4.SelectedIndex = 0;

                //skin perso

                Choiximagetexturecustom4();
                string[] raymancust = {  "1", "2", "3", "4" };
                skin4.Items.Clear();
                skin4.Items.AddRange(raymancust);
                skin4.Text = "original";
                skin4.Items.Insert(0, "original");
                skin4.SelectedIndex = 0;

            }
            else if (Choixperso4.SelectedIndex.ToString() == "1")
            {
                // emplacement skin jeu

                string[] Razor = {  };
                empl4.Items.Clear();
                empl4.Items.AddRange(Razor);
                empl4.Text = "1";
                empl4.Items.Insert(0, "1");
                empl4.SelectedIndex = 0;

                //skin perso

                Choiximagetexturecustom4();
                string[] Razorcust = {  "1", "2", "3", "4" };
                skin4.Items.Clear();
                skin4.Items.AddRange(Razorcust);
                skin4.Text = "original";
                skin4.Items.Insert(0, "original");
                skin4.SelectedIndex = 0;

            }
            else if (Choixperso4.SelectedIndex.ToString() == "2")
            {
                // emplacement skin jeu

                string[] Razorwife = { };
                empl4.Items.Clear();
                empl4.Items.AddRange(Razorwife);
                empl4.Text = "1";
                empl4.Items.Insert(0, "1");
                empl4.SelectedIndex = 0;

                //skin perso

                Choiximagetexturecustom4();
                string[] Razorwifecust = {  "1", "2", "4" };
                skin4.Items.Clear();
                skin4.Items.AddRange(Razorwifecust);
                skin4.Text = "original";
                skin4.Items.Insert(0, "original");
                skin4.SelectedIndex = 0;

            }
            else if (Choixperso4.SelectedIndex.ToString() == "3")
            {
                // emplacement skin jeu

                string[] globox = {  "2", "3", "4" };
                empl4.Items.Clear();
                empl4.Items.AddRange(globox);
                empl4.Text = "1";
                empl4.Items.Insert(0, "1");
                empl4.SelectedIndex = 0;

                //skin perso
                Choiximagetexturecustom4();
                string[] globoxcust = { "1", "2", "3", "4", "5" };
                skin4.Items.Clear();
                skin4.Items.AddRange(globoxcust);
                skin4.Text = "original";
                skin4.Items.Insert(0, "original");
                skin4.SelectedIndex = 0;

            }
            else if (Choixperso4.SelectedIndex.ToString() == "4")
            {
                // emplacement skin jeu

                
                string[] Hunchman = { "2", "3", "4" };
                empl4.Items.Clear();
                empl4.Items.AddRange(Hunchman);
                empl4.Text = "1";
                empl4.Items.Insert(0, "1");
                empl4.SelectedIndex = 0;

                //skin perso
                Choiximagetexturecustom4();
                string[] Hunchmancust = { "1", "2" };
                skin4.Items.Clear();
                skin4.Items.AddRange(Hunchmancust);
                skin4.Text = "original";
                skin4.Items.Insert(0, "original");
                skin4.SelectedIndex = 0;
            }
            else if (Choixperso4.SelectedIndex.ToString() == "5")
            {
                // emplacement skin jeu
                string[] ptizetre = { "2", "3", "4" };
                empl4.Items.Clear();
                empl4.Items.AddRange(ptizetre);
                empl4.Text = "1";
                empl4.Items.Insert(0, "1");
                empl4.SelectedIndex = 0;



                //skin perso
                Choiximagetexturecustom4();
                string[] ptizetrecust = {"1", "2" };
                skin4.Items.Clear();
                skin4.Items.AddRange(ptizetrecust);
                skin4.Text = "original";
                skin4.Items.Insert(0, "original");
                skin4.SelectedIndex = 0;
            }
            else if (Choixperso4.SelectedIndex.ToString() == "6")
            {
                // emplacement skin jeu
                string[] Tily = { };
                empl4.Items.Clear();
                empl4.Items.AddRange(Tily);
                empl4.Text = "1";
                empl4.Items.Insert(0, "1");
                empl4.SelectedIndex = 0;

                //skin perso
                Choiximagetexturecustom4();
                string[] Tilycust = {  "1", "2", "3", "4" };
                skin4.Items.Clear();
                skin4.Items.AddRange(Tilycust);
                skin4.Text = "original";
                skin4.Items.Insert(0, "original");
                skin4.SelectedIndex = 0;
            }
        }

        private void btnValidskin1_Click(object sender, EventArgs e)
        {
            if (Choixperso1.SelectedIndex.ToString() == "0")
            {

                if (skin1.SelectedIndex.ToString() == "0")
                {
                    if (empl1.SelectedIndex.ToString() == "0")
                    {


                        // COPY texture\Original\HD\textures_perso\RaymanT.gf  TO  game\HD\MenuBin\tex32.cnt:\textures_perso\RaymanT.gf
                        // COPY texture\Original\HD\textures_perso\RaymanT.gf  TO  game\HD\FishBin\tex32.cnt:\textures_perso\RaymanT.gf
                        // COPY texture\Original\HD\textures_perso\RaymanT.gf  TO  game\HD\TribeBin\tex32.cnt:\actor\RaymanT\RaymanT.gf

                        // COPY texture\Original\SD\textures_perso\RaymanT.gf  TO  game\SD\MenuBin\tex32.cnt:\textures_perso\RaymanT.gf
                        // COPY texture\Original\SD\textures_perso\RaymanT.gf  TO  game\SD\FishBin\tex32.cnt:\textures_perso\RaymanT.gf
                        // COPY texture\Original\SD\textures_perso\RaymanT.gf  TO  game\SD\TribeBin\tex32.cnt:\actor\RaymanT\RaymanT.gf


                        // COPY texture\Original\HD\textures_perso\Helice.gf  TO  game\HD\MenuBin\tex32.cnt:\textures_perso\Helice.gf
                        // COPY texture\Original\HD\textures_perso\Helice.gf  TO  game\HD\FishBin\tex32.cnt:\textures_perso\Helice.gf
                        // COPY texture\Original\HD\textures_perso\Helice.gf  TO  game\HD\TribeBin\tex32.cnt:\actor\RaymanT\Helice.gf

                        // COPY texture\Original\SD\textures_perso\Helice.gf  TO  game\SD\MenuBin\tex32.cnt:\textures_perso\Helice.gf
                        // COPY texture\Original\SD\textures_perso\Helice.gf  TO  game\SD\FishBin\tex32.cnt:\textures_perso\Helice.gf
                        // COPY texture\Original\SD\textures_perso\Helice.gf  TO  game\SD\TribeBin\tex32.cnt:\actor\RaymanT\Helice.gf



                        // MessageBox.Show("rayman original emplacement 1");
                        MessageBox.Show("this function is not yet available.");
                        
                    }
                       
                }
                else if (skin1.SelectedIndex.ToString() == "1")
                {
                    if (empl1.SelectedIndex.ToString() == "0")
                    {
                        //MessageBox.Show("rayman skin1 emplacement 1");
                        MessageBox.Show("this function is not yet available.");

                        // COPY \texture\RaymanT\1\hd\gf\RaymanT.gf  TO  game\HD\MenuBin\tex32.cnt:\textures_perso\RaymanT.gf
                        // COPY \texture\RaymanT\1\hd\gf\RaymanT.gf  TO  game\HD\FishBin\tex32.cnt:\textures_perso\RaymanT.gf
                        // COPY \texture\RaymanT\1\hd\gf\RaymanT.gf  TO  game\HD\TribeBin\tex32.cnt:\actor\RaymanT\RaymanT.gf

                        // COPY texture\RaymanT\1\gf\RaymanT.gf  TO  game\SD\MenuBin\tex32.cnt:\textures_perso\RaymanT.gf
                        // COPY texture\RaymanT\1\gf\RaymanT.gf  TO  game\SD\FishBin\tex32.cnt:\textures_perso\RaymanT.gf
                        // COPY texture\RaymanT\1\gf\RaymanT.gf  TO  game\SD\TribeBin\tex32.cnt:\actor\RaymanT\RaymanT.gf


                        // COPY \texture\RaymanT\1\hd\gf\Helice.gf  TO  game\HD\MenuBin\tex32.cnt:\textures_perso\Helice.gf
                        // COPY \texture\RaymanT\1\hd\gf\Helice.gf  TO  game\HD\FishBin\tex32.cnt:\textures_perso\Helice.gf
                        // COPY \texture\RaymanT\1\hd\gf\Helice.gf  TO  game\HD\TribeBin\tex32.cnt:\actor\RaymanT\Helice.gf

                        // COPY texture\RaymanT\1\gf\Helice.gf  TO  game\SD\MenuBin\tex32.cnt:\textures_perso\Helice.gf
                        // COPY texture\RaymanT\1\gf\Helice.gf  TO  game\SD\FishBin\tex32.cnt:\textures_perso\Helice.gf
                        // COPY texture\RaymanT\1\gf\Helice.gf  TO  game\SD\TribeBin\tex32.cnt:\actor\RaymanT\Helice.gf


                    }
                }
                else if (skin1.SelectedIndex.ToString() == "2")
                {
                    if (empl1.SelectedIndex.ToString() == "0")
                    {
                        //MessageBox.Show("rayman skin2 emplacement 1");
                        MessageBox.Show("this function is not yet available.");


                        // COPY \texture\RaymanT\2\hd\gf\RaymanT.gf  TO  game\HD\MenuBin\tex32.cnt:\textures_perso\RaymanT.gf
                        // COPY \texture\RaymanT\2\hd\gf\RaymanT.gf  TO  game\HD\FishBin\tex32.cnt:\textures_perso\RaymanT.gf
                        // COPY \texture\RaymanT\2\hd\gf\RaymanT.gf  TO  game\HD\TribeBin\tex32.cnt:\actor\RaymanT\RaymanT.gf

                        // COPY texture\RaymanT\2\gf\RaymanT.gf  TO  game\SD\MenuBin\tex32.cnt:\textures_perso\RaymanT.gf
                        // COPY texture\RaymanT\2\gf\RaymanT.gf  TO  game\SD\FishBin\tex32.cnt:\textures_perso\RaymanT.gf
                        // COPY texture\RaymanT\2\gf\RaymanT.gf  TO  game\SD\TribeBin\tex32.cnt:\actor\RaymanT\RaymanT.gf


                        // COPY \texture\RaymanT\2\hd\gf\Helice.gf  TO  game\HD\MenuBin\tex32.cnt:\textures_perso\Helice.gf
                        // COPY \texture\RaymanT\2\hd\gf\Helice.gf  TO  game\HD\FishBin\tex32.cnt:\textures_perso\Helice.gf
                        // COPY \texture\RaymanT\2\hd\gf\Helice.gf  TO  game\HD\TribeBin\tex32.cnt:\actor\RaymanT\Helice.gf

                        // COPY texture\RaymanT\2\gf\Helice.gf  TO  game\SD\MenuBin\tex32.cnt:\textures_perso\Helice.gf
                        // COPY texture\RaymanT\2\gf\Helice.gf  TO  game\SD\FishBin\tex32.cnt:\textures_perso\Helice.gf
                        // COPY texture\RaymanT\2\gf\Helice.gf  TO  game\SD\TribeBin\tex32.cnt:\actor\RaymanT\Helice.gf




                    }
                }
                else if (skin1.SelectedIndex.ToString() == "3")
                {
                    if (empl1.SelectedIndex.ToString() == "0")
                    {
                        //MessageBox.Show("rayman skin3 emplacement 1");
                        MessageBox.Show("this function is not yet available.");
                    }
                }
                else if (skin1.SelectedIndex.ToString() == "4")
                {
                    if (empl1.SelectedIndex.ToString() == "0")
                    {
                        //MessageBox.Show("rayman skin4 emplacement 1");
                        MessageBox.Show("this function is not yet available.");
                    }
                }
            }

            //choix razor
            if (Choixperso1.SelectedIndex.ToString() == "1")
            {

                if (skin1.SelectedIndex.ToString() == "0")
                {
                    if (empl1.SelectedIndex.ToString() == "0")
                    {
                        //MessageBox.Show("razor original emplacement 1");
                        MessageBox.Show("this function is not yet available.");
                    }

                }
                else if (skin1.SelectedIndex.ToString() == "1")
                {
                    if (empl1.SelectedIndex.ToString() == "0")
                    {
                        //MessageBox.Show("razor skin1 emplacement 1");
                        MessageBox.Show("this function is not yet available.");
                    }
                }
                else if (skin1.SelectedIndex.ToString() == "2")
                {
                    if (empl1.SelectedIndex.ToString() == "0")
                    {
                        //MessageBox.Show("razor skin2 emplacement 1");
                        MessageBox.Show("this function is not yet available.");
                    }
                }
                else if (skin1.SelectedIndex.ToString() == "3")
                {
                    if (empl1.SelectedIndex.ToString() == "0")
                    {
                       // MessageBox.Show("razor skin3 emplacement 1");
                        MessageBox.Show("this function is not yet available.");
                    }
                }
                else if (skin1.SelectedIndex.ToString() == "4")
                {
                    if (empl1.SelectedIndex.ToString() == "0")
                    {
                        //MessageBox.Show("razor skin4 emplacement 1");
                        MessageBox.Show("this function is not yet available.");
                    }
                }
            }

            //choix razorwife
            if (Choixperso1.SelectedIndex.ToString() == "2")
            {

                if (skin1.SelectedIndex.ToString() == "0")
                {
                    if (empl1.SelectedIndex.ToString() == "0")
                    {
                        //MessageBox.Show("razorwife original emplacement 1");
                        MessageBox.Show("this function is not yet available.");
                    }

                }
                else if (skin1.SelectedIndex.ToString() == "1")
                {
                    if (empl1.SelectedIndex.ToString() == "0")
                    {
                        //MessageBox.Show("razorwife skin1 emplacement 1");
                        MessageBox.Show("this function is not yet available.");
                    }
                }
                else if (skin1.SelectedIndex.ToString() == "2")
                {
                    if (empl1.SelectedIndex.ToString() == "0")
                    {
                        //MessageBox.Show("razorwife skin2 emplacement 1");
                        MessageBox.Show("this function is not yet available.");
                    }
                }
                else if (skin1.SelectedIndex.ToString() == "3")
                {
                    if (empl1.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("razorwife skin3 emplacement 1");
                        MessageBox.Show("this function is not yet available.");
                    }
                }

            }
            //choix globox
            if (Choixperso1.SelectedIndex.ToString() == "3")
            {

                if (empl1.SelectedIndex.ToString() == "0")
                {
                    if (skin1.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("globox original emplacement 1");
                        MessageBox.Show("this function is not yet available.");
                    }
                    else if (skin1.SelectedIndex.ToString() == "1")
                    {
                        MessageBox.Show("globox skin1 emplacement 1");
                        MessageBox.Show("this function is not yet available.");
                    }
                    else if (skin1.SelectedIndex.ToString() == "2")
                    {
                        MessageBox.Show("globox skin2 emplacement 1");
                        MessageBox.Show("this function is not yet available.");
                    }
                    else if (skin1.SelectedIndex.ToString() == "3")
                    {
                        MessageBox.Show("globox skin3 emplacement 1");
                        MessageBox.Show("this function is not yet available.");
                    }
                    else if (skin1.SelectedIndex.ToString() == "4")
                    {
                        MessageBox.Show("globox  skin4  emplacement 1");
                        MessageBox.Show("this function is not yet available.");
                    }
                    else if (skin1.SelectedIndex.ToString() == "5")
                    {
                        MessageBox.Show("globox  skin5  emplacement 1");
                        MessageBox.Show("this function is not yet available.");
                    }
                }

                else if (empl1.SelectedIndex.ToString() == "1")
                {
                    if (skin1.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("globox original emplacement 2");
                        MessageBox.Show("this function is not yet available.");
                    }
                    else if (skin1.SelectedIndex.ToString() == "1")
                    {
                        MessageBox.Show("globox skin1 emplacement 2");
                        MessageBox.Show("this function is not yet available.");
                    }
                    else if (skin1.SelectedIndex.ToString() == "2")
                    {
                        MessageBox.Show("globox skin2 emplacement 2");
                        MessageBox.Show("this function is not yet available.");
                    }
                    else if (skin1.SelectedIndex.ToString() == "3")
                    {
                        MessageBox.Show("globox skin3 emplacement 2");
                        MessageBox.Show("this function is not yet available.");
                    }
                    else if (skin1.SelectedIndex.ToString() == "4")
                    {
                        MessageBox.Show("globox  skin4  emplacement 2");
                        MessageBox.Show("this function is not yet available.");
                    }
                    else if (skin1.SelectedIndex.ToString() == "5")
                    {
                        MessageBox.Show("globox  skin5  emplacement 2");
                        MessageBox.Show("this function is not yet available.");
                    }
                }

                else if (empl1.SelectedIndex.ToString() == "2")
                {
                    if (skin1.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("globox original emplacement 3");
                        MessageBox.Show("this function is not yet available.");
                    }
                    else if (skin1.SelectedIndex.ToString() == "1")
                    {
                        MessageBox.Show("globox skin1 emplacement 3");
                        MessageBox.Show("this function is not yet available.");
                    }
                    else if (skin1.SelectedIndex.ToString() == "2")
                    {
                        MessageBox.Show("globox skin2 emplacement 3");
                        MessageBox.Show("this function is not yet available.");
                    }
                    else if (skin1.SelectedIndex.ToString() == "3")
                    {
                        MessageBox.Show("globox skin3 emplacement 3");
                        MessageBox.Show("this function is not yet available.");
                    }
                    else if (skin1.SelectedIndex.ToString() == "4")
                    {
                        MessageBox.Show("globox  skin4  emplacement 3");
                        MessageBox.Show("this function is not yet available.");
                    }
                    else if (skin1.SelectedIndex.ToString() == "5")
                    {
                        MessageBox.Show("globox  skin5  emplacement 3");
                        MessageBox.Show("this function is not yet available.");
                    }
                }

                else if (empl1.SelectedIndex.ToString() == "3")
                {
                    if (skin1.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("globox original emplacement 4");
                        MessageBox.Show("this function is not yet available.");
                    }
                    else if (skin1.SelectedIndex.ToString() == "1")
                    {
                        MessageBox.Show("globox skin1 emplacement 4");
                        MessageBox.Show("this function is not yet available.");
                    }
                    else if (skin1.SelectedIndex.ToString() == "2")
                    {
                        MessageBox.Show("globox skin2 emplacement 4");
                        MessageBox.Show("this function is not yet available.");
                    }
                    else if (skin1.SelectedIndex.ToString() == "3")
                    {
                        MessageBox.Show("globox skin3 emplacement 4");
                        MessageBox.Show("this function is not yet available.");
                    }
                    else if (skin1.SelectedIndex.ToString() == "4")
                    {
                        MessageBox.Show("globox  skin4  emplacement 4");
                        MessageBox.Show("this function is not yet available.");
                    }
                    else if (skin1.SelectedIndex.ToString() == "5")
                    {
                        MessageBox.Show("globox  skin5  emplacement 4");
                        MessageBox.Show("this function is not yet available.");
                    }
                }

               else if (empl1.SelectedIndex.ToString() == "4")
                {
                    if (skin1.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("globox original emplacement 5");
                        MessageBox.Show("this function is not yet available.");
                    }
                    else if (skin1.SelectedIndex.ToString() == "1")
                    {
                        MessageBox.Show("globox skin1 emplacement 5");
                        MessageBox.Show("this function is not yet available.");
                    }
                    else if (skin1.SelectedIndex.ToString() == "2")
                    {
                        MessageBox.Show("globox skin2 emplacement 5");
                        MessageBox.Show("this function is not yet available.");
                    }
                    else if (skin1.SelectedIndex.ToString() == "3")
                    {
                        MessageBox.Show("globox skin3 emplacement 5");
                        MessageBox.Show("this function is not yet available.");
                    }
                    else if (skin1.SelectedIndex.ToString() == "4")
                    {
                        MessageBox.Show("globox  skin4  emplacement 5");
                        MessageBox.Show("this function is not yet available.");
                    }
                    else if (skin1.SelectedIndex.ToString() == "5")
                    {
                        MessageBox.Show("globox  skin5  emplacement 5");
                        MessageBox.Show("this function is not yet available.");
                    }
                }



            }
            //choix huchman
            if (Choixperso1.SelectedIndex.ToString() == "4")
            {

                if (empl1.SelectedIndex.ToString() == "0")
                {
                    if (skin1.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("huchman original emplacement 1");
                        MessageBox.Show("this function is not yet available.");
                    }
                    else if (skin1.SelectedIndex.ToString() == "1")
                    {
                        MessageBox.Show("huchman skin1 emplacement 1");
                        MessageBox.Show("this function is not yet available.");
                    }
                    else if (skin1.SelectedIndex.ToString() == "2")
                    {
                        MessageBox.Show("huchman skin2 emplacement 1");
                        MessageBox.Show("this function is not yet available.");
                    }
                   
                }

                else if (empl1.SelectedIndex.ToString() == "1")
                {
                    if (skin1.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("huchman original emplacement 2");
                        MessageBox.Show("this function is not yet available.");
                    }
                    else if (skin1.SelectedIndex.ToString() == "1")
                    {
                        MessageBox.Show("huchman skin1 emplacement 2");
                        MessageBox.Show("this function is not yet available.");
                    }
                    else if (skin1.SelectedIndex.ToString() == "2")
                    {
                        MessageBox.Show("huchman skin2 emplacement 2");
                        MessageBox.Show("this function is not yet available.");
                    }
                }

                else if (empl1.SelectedIndex.ToString() == "2")
                {
                    if (skin1.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("huchman original emplacement 3");
                        MessageBox.Show("this function is not yet available.");
                    }
                    else if (skin1.SelectedIndex.ToString() == "1")
                    {
                        MessageBox.Show("huchman skin1 emplacement 3");
                        MessageBox.Show("this function is not yet available.");
                    }
                    else if (skin1.SelectedIndex.ToString() == "2")
                    {
                        MessageBox.Show("huchman skin2 emplacement 3");
                        MessageBox.Show("this function is not yet available.");
                    }
                }

                else if (empl1.SelectedIndex.ToString() == "3")
                {
                    if (skin1.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("huchman original emplacement 4");
                        MessageBox.Show("this function is not yet available.");
                    }
                    else if (skin1.SelectedIndex.ToString() == "1")
                    {
                        MessageBox.Show("huchman skin1 emplacement 4");
                        MessageBox.Show("this function is not yet available.");
                    }
                    else if (skin1.SelectedIndex.ToString() == "2")
                    {
                        MessageBox.Show("huchman skin2 emplacement 4");
                        MessageBox.Show("this function is not yet available.");
                    }
                }

                else if (empl1.SelectedIndex.ToString() == "4")
                {
                    if (skin1.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("huchman original emplacement 5");
                        MessageBox.Show("this function is not yet available.");
                    }
                    else if (skin1.SelectedIndex.ToString() == "1")
                    {
                        MessageBox.Show("huchman skin1 emplacement 5");
                        MessageBox.Show("this function is not yet available.");
                    }
                    else if (skin1.SelectedIndex.ToString() == "2")
                    {
                        MessageBox.Show("huchman skin2 emplacement 5");
                        MessageBox.Show("this function is not yet available.");
                    }
                }

            }
            //choix ptizetre
            if (Choixperso1.SelectedIndex.ToString() == "5")
            {

                if (empl1.SelectedIndex.ToString() == "0")
                {
                    if (skin1.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("ptizetre original emplacement 1");
                        MessageBox.Show("this function is not yet available.");
                    }
                    else if (skin1.SelectedIndex.ToString() == "1")
                    {
                        MessageBox.Show("ptizetre skin1 emplacement 1");
                        MessageBox.Show("this function is not yet available.");
                    }
                    else if (skin1.SelectedIndex.ToString() == "2")
                    {
                        MessageBox.Show("ptizetre skin2 emplacement 1");
                        MessageBox.Show("this function is not yet available.");
                    }

                }

                else if (empl1.SelectedIndex.ToString() == "1")
                {
                    if (skin1.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("ptizetre original emplacement 2");
                        MessageBox.Show("this function is not yet available.");
                    }
                    else if (skin1.SelectedIndex.ToString() == "1")
                    {
                        MessageBox.Show("ptizetre skin1 emplacement 2");
                        MessageBox.Show("this function is not yet available.");
                    }
                    else if (skin1.SelectedIndex.ToString() == "2")
                    {
                        MessageBox.Show("ptizetre skin2 emplacement 2");
                        MessageBox.Show("this function is not yet available.");
                    }
                }

                else if (empl1.SelectedIndex.ToString() == "2")
                {
                    if (skin1.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("ptizetre original emplacement 3");
                        MessageBox.Show("this function is not yet available.");
                    }
                    else if (skin1.SelectedIndex.ToString() == "1")
                    {
                        MessageBox.Show("ptizetre skin1 emplacement 3");
                        MessageBox.Show("this function is not yet available.");
                    }
                    else if (skin1.SelectedIndex.ToString() == "2")
                    {
                        MessageBox.Show("ptizetre skin2 emplacement 3");
                        MessageBox.Show("this function is not yet available.");
                    }
                }

                else if (empl1.SelectedIndex.ToString() == "3")
                {
                    if (skin1.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("ptizetre original emplacement 4");
                        MessageBox.Show("this function is not yet available.");
                    }
                    else if (skin1.SelectedIndex.ToString() == "1")
                    {
                        MessageBox.Show("ptizetre skin1 emplacement 4");
                        MessageBox.Show("this function is not yet available.");
                    }
                    else if (skin1.SelectedIndex.ToString() == "2")
                    {
                        MessageBox.Show("ptizetre skin2 emplacement 4");
                        MessageBox.Show("this function is not yet available.");
                    }
                }

                else if (empl1.SelectedIndex.ToString() == "4")
                {
                    if (skin1.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("ptizetre original emplacement 5");
                        MessageBox.Show("this function is not yet available.");
                    }
                    else if (skin1.SelectedIndex.ToString() == "1")
                    {
                        MessageBox.Show("ptizetre skin1 emplacement 5");
                        MessageBox.Show("this function is not yet available.");
                    }
                    else if (skin1.SelectedIndex.ToString() == "2")
                    {
                        MessageBox.Show("ptizetre skin2 emplacement 5");
                        MessageBox.Show("this function is not yet available.");
                    }
                }
            }

            //choix tily
            if (Choixperso1.SelectedIndex.ToString() == "6")
            {

                if (skin1.SelectedIndex.ToString() == "0")
                {
                    if (empl1.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("tily original emplacement 1");
                        MessageBox.Show("this function is not yet available.");
                    }

                }
                else if (skin1.SelectedIndex.ToString() == "1")
                {
                    if (empl1.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("tily skin1 emplacement 1");
                        MessageBox.Show("this function is not yet available.");
                    }
                }
                else if (skin1.SelectedIndex.ToString() == "2")
                {
                    if (empl1.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("tily skin2 emplacement 1");
                        MessageBox.Show("this function is not yet available.");
                    }
                }
                else if (skin1.SelectedIndex.ToString() == "3")
                {
                    if (empl1.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("tily skin3 emplacement 1");
                        MessageBox.Show("this function is not yet available.");
                    }
                }
                else if (skin1.SelectedIndex.ToString() == "4")
                {
                    if (empl1.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("tily skin4 emplacement 1");
                        MessageBox.Show("this function is not yet available.");
                    }
                }

            }
        }

        private void btnValidskin2_Click(object sender, EventArgs e)
        {


            if (Choixperso2.SelectedIndex.ToString() == "0")
            {

                if (skin2.SelectedIndex.ToString() == "0")
                {
                    if (empl2.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("rayman original emplacement 1");
                    }

                }
                else if (skin2.SelectedIndex.ToString() == "1")
                {
                    if (empl2.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("rayman skin1 emplacement 1");
                    }
                }
                else if (skin2.SelectedIndex.ToString() == "2")
                {
                    if (empl2.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("rayman skin2 emplacement 1");
                    }
                }
                else if (skin2.SelectedIndex.ToString() == "3")
                {
                    if (empl2.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("rayman skin3 emplacement 1");
                    }
                }
                else if (skin2.SelectedIndex.ToString() == "4")
                {
                    if (empl2.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("rayman skin4 emplacement 1");
                    }
                }
            }

            //choix razor
            if (Choixperso2.SelectedIndex.ToString() == "1")
            {

                if (skin2.SelectedIndex.ToString() == "0")
                {
                    if (empl2.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("razor original emplacement 1");
                    }

                }
                else if (skin2.SelectedIndex.ToString() == "1")
                {
                    if (empl2.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("razor skin1 emplacement 1");
                    }
                }
                else if (skin2.SelectedIndex.ToString() == "2")
                {
                    if (empl2.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("razor skin2 emplacement 1");
                    }
                }
                else if (skin2.SelectedIndex.ToString() == "3")
                {
                    if (empl2.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("razor skin3 emplacement 1");
                    }
                }
                else if (skin2.SelectedIndex.ToString() == "4")
                {
                    if (empl2.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("razor skin4 emplacement 1");
                    }
                }
            }

            //choix razorwife
            if (Choixperso2.SelectedIndex.ToString() == "2")
            {

                if (skin2.SelectedIndex.ToString() == "0")
                {
                    if (empl2.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("razorwife original emplacement 1");
                    }

                }
                else if (skin2.SelectedIndex.ToString() == "1")
                {
                    if (empl2.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("razorwife skin1 emplacement 1");
                    }
                }
                else if (skin2.SelectedIndex.ToString() == "2")
                {
                    if (empl2.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("razorwife skin2 emplacement 1");
                    }
                }
                else if (skin2.SelectedIndex.ToString() == "3")
                {
                    if (empl2.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("razorwife skin3 emplacement 1");
                    }
                }

            }
            //choix globox
            if (Choixperso2.SelectedIndex.ToString() == "3")
            {

                if (empl2.SelectedIndex.ToString() == "0")
                {
                    if (skin2.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("globox original emplacement 1");
                    }
                    else if (skin2.SelectedIndex.ToString() == "1")
                    {
                        MessageBox.Show("globox skin1 emplacement 1");
                    }
                    else if (skin2.SelectedIndex.ToString() == "2")
                    {
                        MessageBox.Show("globox skin2 emplacement 1");
                    }
                    else if (skin2.SelectedIndex.ToString() == "3")
                    {
                        MessageBox.Show("globox skin3 emplacement 1");
                    }
                    else if (skin2.SelectedIndex.ToString() == "4")
                    {
                        MessageBox.Show("globox  skin4  emplacement 1");
                    }
                    else if (skin2.SelectedIndex.ToString() == "5")
                    {
                        MessageBox.Show("globox  skin5  emplacement 1");
                    }
                }

                else if (empl2.SelectedIndex.ToString() == "1")
                {
                    if (skin2.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("globox original emplacement 2");
                    }
                    else if (skin2.SelectedIndex.ToString() == "1")
                    {
                        MessageBox.Show("globox skin1 emplacement 2");
                    }
                    else if (skin2.SelectedIndex.ToString() == "2")
                    {
                        MessageBox.Show("globox skin2 emplacement 2");
                    }
                    else if (skin2.SelectedIndex.ToString() == "3")
                    {
                        MessageBox.Show("globox skin3 emplacement 2");
                    }
                    else if (skin2.SelectedIndex.ToString() == "4")
                    {
                        MessageBox.Show("globox  skin4  emplacement 2");
                    }
                    else if (skin2.SelectedIndex.ToString() == "5")
                    {
                        MessageBox.Show("globox  skin5  emplacement 2");
                    }
                }

                else if (empl2.SelectedIndex.ToString() == "2")
                {
                    if (skin2.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("globox original emplacement 3");
                    }
                    else if (skin2.SelectedIndex.ToString() == "1")
                    {
                        MessageBox.Show("globox skin1 emplacement 3");
                    }
                    else if (skin2.SelectedIndex.ToString() == "2")
                    {
                        MessageBox.Show("globox skin2 emplacement 3");
                    }
                    else if (skin2.SelectedIndex.ToString() == "3")
                    {
                        MessageBox.Show("globox skin3 emplacement 3");
                    }
                    else if (skin2.SelectedIndex.ToString() == "4")
                    {
                        MessageBox.Show("globox  skin4  emplacement 3");
                    }
                    else if (skin2.SelectedIndex.ToString() == "5")
                    {
                        MessageBox.Show("globox  skin5  emplacement 3");
                    }
                }

                else if (empl2.SelectedIndex.ToString() == "3")
                {
                    if (skin2.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("globox original emplacement 4");
                    }
                    else if (skin2.SelectedIndex.ToString() == "1")
                    {
                        MessageBox.Show("globox skin1 emplacement 4");
                    }
                    else if (skin2.SelectedIndex.ToString() == "2")
                    {
                        MessageBox.Show("globox skin2 emplacement 4");
                    }
                    else if (skin2.SelectedIndex.ToString() == "3")
                    {
                        MessageBox.Show("globox skin3 emplacement 4");
                    }
                    else if (skin2.SelectedIndex.ToString() == "4")
                    {
                        MessageBox.Show("globox  skin4  emplacement 4");
                    }
                    else if (skin2.SelectedIndex.ToString() == "5")
                    {
                        MessageBox.Show("globox  skin5  emplacement 4");
                    }
                }

                else if (empl2.SelectedIndex.ToString() == "4")
                {
                    if (skin2.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("globox original emplacement 5");
                    }
                    else if (skin2.SelectedIndex.ToString() == "1")
                    {
                        MessageBox.Show("globox skin1 emplacement 5");
                    }
                    else if (skin2.SelectedIndex.ToString() == "2")
                    {
                        MessageBox.Show("globox skin2 emplacement 5");
                    }
                    else if (skin2.SelectedIndex.ToString() == "3")
                    {
                        MessageBox.Show("globox skin3 emplacement 5");
                    }
                    else if (skin2.SelectedIndex.ToString() == "4")
                    {
                        MessageBox.Show("globox  skin4  emplacement 5");
                    }
                    else if (skin2.SelectedIndex.ToString() == "5")
                    {
                        MessageBox.Show("globox  skin5  emplacement 5");
                    }
                }



            }
            //choix huchman
            if (Choixperso2.SelectedIndex.ToString() == "4")
            {

                if (empl2.SelectedIndex.ToString() == "0")
                {
                    if (skin2.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("huchman original emplacement 1");
                    }
                    else if (skin2.SelectedIndex.ToString() == "1")
                    {
                        MessageBox.Show("huchman skin1 emplacement 1");
                    }
                    else if (skin2.SelectedIndex.ToString() == "2")
                    {
                        MessageBox.Show("huchman skin2 emplacement 1");
                    }

                }

                else if (empl2.SelectedIndex.ToString() == "1")
                {
                    if (skin2.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("huchman original emplacement 2");
                    }
                    else if (skin2.SelectedIndex.ToString() == "1")
                    {
                        MessageBox.Show("huchman skin1 emplacement 2");
                    }
                    else if (skin2.SelectedIndex.ToString() == "2")
                    {
                        MessageBox.Show("huchman skin2 emplacement 2");
                    }
                }

                else if (empl2.SelectedIndex.ToString() == "2")
                {
                    if (skin2.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("huchman original emplacement 3");
                    }
                    else if (skin2.SelectedIndex.ToString() == "1")
                    {
                        MessageBox.Show("huchman skin1 emplacement 3");
                    }
                    else if (skin2.SelectedIndex.ToString() == "2")
                    {
                        MessageBox.Show("huchman skin2 emplacement 3");
                    }
                }

                else if (empl2.SelectedIndex.ToString() == "3")
                {
                    if (skin2.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("huchman original emplacement 4");
                    }
                    else if (skin2.SelectedIndex.ToString() == "1")
                    {
                        MessageBox.Show("huchman skin1 emplacement 4");
                    }
                    else if (skin2.SelectedIndex.ToString() == "2")
                    {
                        MessageBox.Show("huchman skin2 emplacement 4");
                    }
                }

                else if (empl2.SelectedIndex.ToString() == "4")
                {
                    if (skin2.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("huchman original emplacement 5");
                    }
                    else if (skin2.SelectedIndex.ToString() == "1")
                    {
                        MessageBox.Show("huchman skin1 emplacement 5");
                    }
                    else if (skin2.SelectedIndex.ToString() == "2")
                    {
                        MessageBox.Show("huchman skin2 emplacement 5");
                    }
                }

            }
            //choix ptizetre
            if (Choixperso2.SelectedIndex.ToString() == "5")
            {

                if (empl2.SelectedIndex.ToString() == "0")
                {
                    if (skin2.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("ptizetre original emplacement 1");
                    }
                    else if (skin2.SelectedIndex.ToString() == "1")
                    {
                        MessageBox.Show("ptizetre skin1 emplacement 1");
                    }
                    else if (skin2.SelectedIndex.ToString() == "2")
                    {
                        MessageBox.Show("ptizetre skin2 emplacement 1");
                    }

                }

                else if (empl2.SelectedIndex.ToString() == "1")
                {
                    if (skin2.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("ptizetre original emplacement 2");
                    }
                    else if (skin2.SelectedIndex.ToString() == "1")
                    {
                        MessageBox.Show("ptizetre skin1 emplacement 2");
                    }
                    else if (skin2.SelectedIndex.ToString() == "2")
                    {
                        MessageBox.Show("ptizetre skin2 emplacement 2");
                    }
                }

                else if (empl2.SelectedIndex.ToString() == "2")
                {
                    if (skin2.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("ptizetre original emplacement 3");
                    }
                    else if (skin2.SelectedIndex.ToString() == "1")
                    {
                        MessageBox.Show("ptizetre skin1 emplacement 3");
                    }
                    else if (skin2.SelectedIndex.ToString() == "2")
                    {
                        MessageBox.Show("ptizetre skin2 emplacement 3");
                    }
                }

                else if (empl2.SelectedIndex.ToString() == "3")
                {
                    if (skin2.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("ptizetre original emplacement 4");
                    }
                    else if (skin2.SelectedIndex.ToString() == "1")
                    {
                        MessageBox.Show("ptizetre skin1 emplacement 4");
                    }
                    else if (skin2.SelectedIndex.ToString() == "2")
                    {
                        MessageBox.Show("ptizetre skin2 emplacement 4");
                    }
                }

                else if (empl2.SelectedIndex.ToString() == "4")
                {
                    if (skin2.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("ptizetre original emplacement 5");
                    }
                    else if (skin2.SelectedIndex.ToString() == "1")
                    {
                        MessageBox.Show("ptizetre skin1 emplacement 5");
                    }
                    else if (skin2.SelectedIndex.ToString() == "2")
                    {
                        MessageBox.Show("ptizetre skin2 emplacement 5");
                    }
                }
            }

            //choix tily
            if (Choixperso2.SelectedIndex.ToString() == "6")
            {

                if (skin2.SelectedIndex.ToString() == "0")
                {
                    if (empl2.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("tily original emplacement 1");
                    }

                }
                else if (skin2.SelectedIndex.ToString() == "1")
                {
                    if (empl2.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("tily skin2 emplacement 1");
                    }
                }
                else if (skin2.SelectedIndex.ToString() == "2")
                {
                    if (empl2.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("tily skin2 emplacement 1");
                    }
                }
                else if (skin2.SelectedIndex.ToString() == "3")
                {
                    if (empl2.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("tily skin3 emplacement 1");
                    }
                }
                else if (skin2.SelectedIndex.ToString() == "4")
                {
                    if (empl2.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("tily skin4 emplacement 1");
                    }
                }

            }


        }

        private void btnValidskin3_Click(object sender, EventArgs e)
        {
            if (Choixperso3.SelectedIndex.ToString() == "0")
            {

                if (skin3.SelectedIndex.ToString() == "0")
                {
                    if (empl3.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("rayman original emplacement 1");
                    }

                }
                else if (skin3.SelectedIndex.ToString() == "1")
                {
                    if (empl3.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("rayman skin3 emplacement 1");
                    }
                }
                else if (skin3.SelectedIndex.ToString() == "2")
                {
                    if (empl3.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("rayman skin2 emplacement 1");
                    }
                }
                else if (skin3.SelectedIndex.ToString() == "3")
                {
                    if (empl3.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("rayman skin3 emplacement 1");
                    }
                }
                else if (skin3.SelectedIndex.ToString() == "4")
                {
                    if (empl3.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("rayman skin4 emplacement 1");
                    }
                }
            }

            //choix razor
            if (Choixperso3.SelectedIndex.ToString() == "1")
            {

                if (skin3.SelectedIndex.ToString() == "0")
                {
                    if (empl3.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("razor original emplacement 1");
                    }

                }
                else if (skin3.SelectedIndex.ToString() == "1")
                {
                    if (empl3.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("razor skin3 emplacement 1");
                    }
                }
                else if (skin3.SelectedIndex.ToString() == "2")
                {
                    if (empl3.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("razor skin2 emplacement 1");
                    }
                }
                else if (skin3.SelectedIndex.ToString() == "3")
                {
                    if (empl3.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("razor skin3 emplacement 1");
                    }
                }
                else if (skin3.SelectedIndex.ToString() == "4")
                {
                    if (empl3.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("razor skin4 emplacement 1");
                    }
                }
            }

            //choix razorwife
            if (Choixperso3.SelectedIndex.ToString() == "2")
            {

                if (skin3.SelectedIndex.ToString() == "0")
                {
                    if (empl3.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("razorwife original emplacement 1");
                    }

                }
                else if (skin3.SelectedIndex.ToString() == "1")
                {
                    if (empl3.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("razorwife skin3 emplacement 1");
                    }
                }
                else if (skin3.SelectedIndex.ToString() == "2")
                {
                    if (empl3.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("razorwife skin2 emplacement 1");
                    }
                }
                else if (skin3.SelectedIndex.ToString() == "3")
                {
                    if (empl3.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("razorwife skin3 emplacement 1");
                    }
                }

            }
            //choix globox
            if (Choixperso3.SelectedIndex.ToString() == "3")
            {

                if (empl3.SelectedIndex.ToString() == "0")
                {
                    if (skin3.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("globox original emplacement 1");
                    }
                    else if (skin3.SelectedIndex.ToString() == "1")
                    {
                        MessageBox.Show("globox skin3 emplacement 1");
                    }
                    else if (skin3.SelectedIndex.ToString() == "2")
                    {
                        MessageBox.Show("globox skin2 emplacement 1");
                    }
                    else if (skin3.SelectedIndex.ToString() == "3")
                    {
                        MessageBox.Show("globox skin3 emplacement 1");
                    }
                    else if (skin3.SelectedIndex.ToString() == "4")
                    {
                        MessageBox.Show("globox  skin4  emplacement 1");
                    }
                    else if (skin3.SelectedIndex.ToString() == "5")
                    {
                        MessageBox.Show("globox  skin5  emplacement 1");
                    }
                }

                else if (empl3.SelectedIndex.ToString() == "1")
                {
                    if (skin3.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("globox original emplacement 2");
                    }
                    else if (skin3.SelectedIndex.ToString() == "1")
                    {
                        MessageBox.Show("globox skin3 emplacement 2");
                    }
                    else if (skin3.SelectedIndex.ToString() == "2")
                    {
                        MessageBox.Show("globox skin2 emplacement 2");
                    }
                    else if (skin3.SelectedIndex.ToString() == "3")
                    {
                        MessageBox.Show("globox skin3 emplacement 2");
                    }
                    else if (skin3.SelectedIndex.ToString() == "4")
                    {
                        MessageBox.Show("globox  skin4  emplacement 2");
                    }
                    else if (skin3.SelectedIndex.ToString() == "5")
                    {
                        MessageBox.Show("globox  skin5  emplacement 2");
                    }
                }

                else if (empl3.SelectedIndex.ToString() == "2")
                {
                    if (skin3.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("globox original emplacement 3");
                    }
                    else if (skin3.SelectedIndex.ToString() == "1")
                    {
                        MessageBox.Show("globox skin3 emplacement 3");
                    }
                    else if (skin3.SelectedIndex.ToString() == "2")
                    {
                        MessageBox.Show("globox skin2 emplacement 3");
                    }
                    else if (skin3.SelectedIndex.ToString() == "3")
                    {
                        MessageBox.Show("globox skin3 emplacement 3");
                    }
                    else if (skin3.SelectedIndex.ToString() == "4")
                    {
                        MessageBox.Show("globox  skin4  emplacement 3");
                    }
                    else if (skin3.SelectedIndex.ToString() == "5")
                    {
                        MessageBox.Show("globox  skin5  emplacement 3");
                    }
                }

                else if (empl3.SelectedIndex.ToString() == "3")
                {
                    if (skin3.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("globox original emplacement 4");
                    }
                    else if (skin3.SelectedIndex.ToString() == "1")
                    {
                        MessageBox.Show("globox skin3 emplacement 4");
                    }
                    else if (skin3.SelectedIndex.ToString() == "2")
                    {
                        MessageBox.Show("globox skin2 emplacement 4");
                    }
                    else if (skin3.SelectedIndex.ToString() == "3")
                    {
                        MessageBox.Show("globox skin3 emplacement 4");
                    }
                    else if (skin3.SelectedIndex.ToString() == "4")
                    {
                        MessageBox.Show("globox  skin4  emplacement 4");
                    }
                    else if (skin3.SelectedIndex.ToString() == "5")
                    {
                        MessageBox.Show("globox  skin5  emplacement 4");
                    }
                }

                else if (empl3.SelectedIndex.ToString() == "4")
                {
                    if (skin3.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("globox original emplacement 5");
                    }
                    else if (skin3.SelectedIndex.ToString() == "1")
                    {
                        MessageBox.Show("globox skin3 emplacement 5");
                    }
                    else if (skin3.SelectedIndex.ToString() == "2")
                    {
                        MessageBox.Show("globox skin2 emplacement 5");
                    }
                    else if (skin3.SelectedIndex.ToString() == "3")
                    {
                        MessageBox.Show("globox skin3 emplacement 5");
                    }
                    else if (skin3.SelectedIndex.ToString() == "4")
                    {
                        MessageBox.Show("globox  skin4  emplacement 5");
                    }
                    else if (skin3.SelectedIndex.ToString() == "5")
                    {
                        MessageBox.Show("globox  skin5  emplacement 5");
                    }
                }



            }
            //choix huchman
            if (Choixperso3.SelectedIndex.ToString() == "4")
            {

                if (empl3.SelectedIndex.ToString() == "0")
                {
                    if (skin3.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("huchman original emplacement 1");
                    }
                    else if (skin3.SelectedIndex.ToString() == "1")
                    {
                        MessageBox.Show("huchman skin3 emplacement 1");
                    }
                    else if (skin3.SelectedIndex.ToString() == "2")
                    {
                        MessageBox.Show("huchman skin2 emplacement 1");
                    }

                }

                else if (empl3.SelectedIndex.ToString() == "1")
                {
                    if (skin3.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("huchman original emplacement 2");
                    }
                    else if (skin3.SelectedIndex.ToString() == "1")
                    {
                        MessageBox.Show("huchman skin3 emplacement 2");
                    }
                    else if (skin3.SelectedIndex.ToString() == "2")
                    {
                        MessageBox.Show("huchman skin2 emplacement 2");
                    }
                }

                else if (empl3.SelectedIndex.ToString() == "2")
                {
                    if (skin3.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("huchman original emplacement 3");
                    }
                    else if (skin3.SelectedIndex.ToString() == "1")
                    {
                        MessageBox.Show("huchman skin3 emplacement 3");
                    }
                    else if (skin3.SelectedIndex.ToString() == "2")
                    {
                        MessageBox.Show("huchman skin2 emplacement 3");
                    }
                }

                else if (empl3.SelectedIndex.ToString() == "3")
                {
                    if (skin3.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("huchman original emplacement 4");
                    }
                    else if (skin3.SelectedIndex.ToString() == "1")
                    {
                        MessageBox.Show("huchman skin3 emplacement 4");
                    }
                    else if (skin3.SelectedIndex.ToString() == "2")
                    {
                        MessageBox.Show("huchman skin2 emplacement 4");
                    }
                }

                else if (empl3.SelectedIndex.ToString() == "4")
                {
                    if (skin3.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("huchman original emplacement 5");
                    }
                    else if (skin3.SelectedIndex.ToString() == "1")
                    {
                        MessageBox.Show("huchman skin3 emplacement 5");
                    }
                    else if (skin3.SelectedIndex.ToString() == "2")
                    {
                        MessageBox.Show("huchman skin2 emplacement 5");
                    }
                }

            }
            //choix ptizetre
            if (Choixperso3.SelectedIndex.ToString() == "5")
            {

                if (empl3.SelectedIndex.ToString() == "0")
                {
                    if (skin3.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("ptizetre original emplacement 1");
                    }
                    else if (skin3.SelectedIndex.ToString() == "1")
                    {
                        MessageBox.Show("ptizetre skin3 emplacement 1");
                    }
                    else if (skin3.SelectedIndex.ToString() == "2")
                    {
                        MessageBox.Show("ptizetre skin2 emplacement 1");
                    }

                }

                else if (empl3.SelectedIndex.ToString() == "1")
                {
                    if (skin3.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("ptizetre original emplacement 2");
                    }
                    else if (skin3.SelectedIndex.ToString() == "1")
                    {
                        MessageBox.Show("ptizetre skin3 emplacement 2");
                    }
                    else if (skin3.SelectedIndex.ToString() == "2")
                    {
                        MessageBox.Show("ptizetre skin2 emplacement 2");
                    }
                }

                else if (empl3.SelectedIndex.ToString() == "2")
                {
                    if (skin3.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("ptizetre original emplacement 3");
                    }
                    else if (skin3.SelectedIndex.ToString() == "1")
                    {
                        MessageBox.Show("ptizetre skin3 emplacement 3");
                    }
                    else if (skin3.SelectedIndex.ToString() == "2")
                    {
                        MessageBox.Show("ptizetre skin2 emplacement 3");
                    }
                }

                else if (empl3.SelectedIndex.ToString() == "3")
                {
                    if (skin3.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("ptizetre original emplacement 4");
                    }
                    else if (skin3.SelectedIndex.ToString() == "1")
                    {
                        MessageBox.Show("ptizetre skin3 emplacement 4");
                    }
                    else if (skin3.SelectedIndex.ToString() == "2")
                    {
                        MessageBox.Show("ptizetre skin2 emplacement 4");
                    }
                }

                else if (empl3.SelectedIndex.ToString() == "4")
                {
                    if (skin3.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("ptizetre original emplacement 5");
                    }
                    else if (skin3.SelectedIndex.ToString() == "1")
                    {
                        MessageBox.Show("ptizetre skin3 emplacement 5");
                    }
                    else if (skin3.SelectedIndex.ToString() == "2")
                    {
                        MessageBox.Show("ptizetre skin2 emplacement 5");
                    }
                }
            }

            //choix tily
            if (Choixperso3.SelectedIndex.ToString() == "6")
            {

                if (skin3.SelectedIndex.ToString() == "0")
                {
                    if (empl3.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("tily original emplacement 1");
                    }

                }
                else if (skin3.SelectedIndex.ToString() == "1")
                {
                    if (empl3.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("tily skin3 emplacement 1");
                    }
                }
                else if (skin3.SelectedIndex.ToString() == "2")
                {
                    if (empl3.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("tily skin2 emplacement 1");
                    }
                }
                else if (skin3.SelectedIndex.ToString() == "3")
                {
                    if (empl3.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("tily skin3 emplacement 1");
                    }
                }
                else if (skin3.SelectedIndex.ToString() == "4")
                {
                    if (empl3.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("tily skin4 emplacement 1");
                    }
                }

            }
        }

        private void btnValidskin4_Click(object sender, EventArgs e)
        {
            if (Choixperso4.SelectedIndex.ToString() == "0")
            {

                if (skin4.SelectedIndex.ToString() == "0")
                {
                    if (empl4.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("rayman original emplacement 1");
                    }

                }
                else if (skin4.SelectedIndex.ToString() == "1")
                {
                    if (empl4.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("rayman skin4 emplacement 1");
                    }
                }
                else if (skin4.SelectedIndex.ToString() == "2")
                {
                    if (empl4.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("rayman skin2 emplacement 1");
                    }
                }
                else if (skin4.SelectedIndex.ToString() == "3")
                {
                    if (empl4.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("rayman skin3 emplacement 1");
                    }
                }
                else if (skin4.SelectedIndex.ToString() == "4")
                {
                    if (empl4.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("rayman skin4 emplacement 1");
                    }
                }
            }

            //choix razor
            if (Choixperso4.SelectedIndex.ToString() == "1")
            {

                if (skin4.SelectedIndex.ToString() == "0")
                {
                    if (empl4.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("razor original emplacement 1");
                    }

                }
                else if (skin4.SelectedIndex.ToString() == "1")
                {
                    if (empl4.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("razor skin4 emplacement 1");
                    }
                }
                else if (skin4.SelectedIndex.ToString() == "2")
                {
                    if (empl4.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("razor skin2 emplacement 1");
                    }
                }
                else if (skin4.SelectedIndex.ToString() == "3")
                {
                    if (empl4.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("razor skin3 emplacement 1");
                    }
                }
                else if (skin4.SelectedIndex.ToString() == "4")
                {
                    if (empl4.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("razor skin4 emplacement 1");
                    }
                }
            }

            //choix razorwife
            if (Choixperso4.SelectedIndex.ToString() == "2")
            {

                if (skin4.SelectedIndex.ToString() == "0")
                {
                    if (empl4.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("razorwife original emplacement 1");
                    }

                }
                else if (skin4.SelectedIndex.ToString() == "1")
                {
                    if (empl4.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("razorwife skin4 emplacement 1");
                    }
                }
                else if (skin4.SelectedIndex.ToString() == "2")
                {
                    if (empl4.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("razorwife skin2 emplacement 1");
                    }
                }
                else if (skin4.SelectedIndex.ToString() == "3")
                {
                    if (empl4.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("razorwife skin3 emplacement 1");
                    }
                }

            }
            //choix globox
            if (Choixperso4.SelectedIndex.ToString() == "3")
            {

                if (empl4.SelectedIndex.ToString() == "0")
                {
                    if (skin4.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("globox original emplacement 1");
                    }
                    else if (skin4.SelectedIndex.ToString() == "1")
                    {
                        MessageBox.Show("globox skin4 emplacement 1");
                    }
                    else if (skin4.SelectedIndex.ToString() == "2")
                    {
                        MessageBox.Show("globox skin2 emplacement 1");
                    }
                    else if (skin4.SelectedIndex.ToString() == "3")
                    {
                        MessageBox.Show("globox skin3 emplacement 1");
                    }
                    else if (skin4.SelectedIndex.ToString() == "4")
                    {
                        MessageBox.Show("globox  skin4  emplacement 1");
                    }
                    else if (skin4.SelectedIndex.ToString() == "5")
                    {
                        MessageBox.Show("globox  skin5  emplacement 1");
                    }
                }

                else if (empl4.SelectedIndex.ToString() == "1")
                {
                    if (skin4.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("globox original emplacement 2");
                    }
                    else if (skin4.SelectedIndex.ToString() == "1")
                    {
                        MessageBox.Show("globox skin4 emplacement 2");
                    }
                    else if (skin4.SelectedIndex.ToString() == "2")
                    {
                        MessageBox.Show("globox skin2 emplacement 2");
                    }
                    else if (skin4.SelectedIndex.ToString() == "3")
                    {
                        MessageBox.Show("globox skin3 emplacement 2");
                    }
                    else if (skin4.SelectedIndex.ToString() == "4")
                    {
                        MessageBox.Show("globox  skin4  emplacement 2");
                    }
                    else if (skin4.SelectedIndex.ToString() == "5")
                    {
                        MessageBox.Show("globox  skin5  emplacement 2");
                    }
                }

                else if (empl4.SelectedIndex.ToString() == "2")
                {
                    if (skin4.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("globox original emplacement 3");
                    }
                    else if (skin4.SelectedIndex.ToString() == "1")
                    {
                        MessageBox.Show("globox skin4 emplacement 3");
                    }
                    else if (skin4.SelectedIndex.ToString() == "2")
                    {
                        MessageBox.Show("globox skin2 emplacement 3");
                    }
                    else if (skin4.SelectedIndex.ToString() == "3")
                    {
                        MessageBox.Show("globox skin3 emplacement 3");
                    }
                    else if (skin4.SelectedIndex.ToString() == "4")
                    {
                        MessageBox.Show("globox  skin4  emplacement 3");
                    }
                    else if (skin4.SelectedIndex.ToString() == "5")
                    {
                        MessageBox.Show("globox  skin5  emplacement 3");
                    }
                }

                else if (empl4.SelectedIndex.ToString() == "3")
                {
                    if (skin4.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("globox original emplacement 4");
                    }
                    else if (skin4.SelectedIndex.ToString() == "1")
                    {
                        MessageBox.Show("globox skin4 emplacement 4");
                    }
                    else if (skin4.SelectedIndex.ToString() == "2")
                    {
                        MessageBox.Show("globox skin2 emplacement 4");
                    }
                    else if (skin4.SelectedIndex.ToString() == "3")
                    {
                        MessageBox.Show("globox skin3 emplacement 4");
                    }
                    else if (skin4.SelectedIndex.ToString() == "4")
                    {
                        MessageBox.Show("globox  skin4  emplacement 4");
                    }
                    else if (skin4.SelectedIndex.ToString() == "5")
                    {
                        MessageBox.Show("globox  skin5  emplacement 4");
                    }
                }

                else if (empl4.SelectedIndex.ToString() == "4")
                {
                    if (skin4.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("globox original emplacement 5");
                    }
                    else if (skin4.SelectedIndex.ToString() == "1")
                    {
                        MessageBox.Show("globox skin4 emplacement 5");
                    }
                    else if (skin4.SelectedIndex.ToString() == "2")
                    {
                        MessageBox.Show("globox skin2 emplacement 5");
                    }
                    else if (skin4.SelectedIndex.ToString() == "3")
                    {
                        MessageBox.Show("globox skin3 emplacement 5");
                    }
                    else if (skin4.SelectedIndex.ToString() == "4")
                    {
                        MessageBox.Show("globox  skin4  emplacement 5");
                    }
                    else if (skin4.SelectedIndex.ToString() == "5")
                    {
                        MessageBox.Show("globox  skin5  emplacement 5");
                    }
                }



            }
            //choix huchman
            if (Choixperso4.SelectedIndex.ToString() == "4")
            {

                if (empl4.SelectedIndex.ToString() == "0")
                {
                    if (skin4.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("huchman original emplacement 1");
                    }
                    else if (skin4.SelectedIndex.ToString() == "1")
                    {
                        MessageBox.Show("huchman skin4 emplacement 1");
                    }
                    else if (skin4.SelectedIndex.ToString() == "2")
                    {
                        MessageBox.Show("huchman skin2 emplacement 1");
                    }

                }

                else if (empl4.SelectedIndex.ToString() == "1")
                {
                    if (skin4.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("huchman original emplacement 2");
                    }
                    else if (skin4.SelectedIndex.ToString() == "1")
                    {
                        MessageBox.Show("huchman skin4 emplacement 2");
                    }
                    else if (skin4.SelectedIndex.ToString() == "2")
                    {
                        MessageBox.Show("huchman skin2 emplacement 2");
                    }
                }

                else if (empl4.SelectedIndex.ToString() == "2")
                {
                    if (skin4.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("huchman original emplacement 3");
                    }
                    else if (skin4.SelectedIndex.ToString() == "1")
                    {
                        MessageBox.Show("huchman skin4 emplacement 3");
                    }
                    else if (skin4.SelectedIndex.ToString() == "2")
                    {
                        MessageBox.Show("huchman skin2 emplacement 3");
                    }
                }

                else if (empl4.SelectedIndex.ToString() == "3")
                {
                    if (skin4.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("huchman original emplacement 4");
                    }
                    else if (skin4.SelectedIndex.ToString() == "1")
                    {
                        MessageBox.Show("huchman skin4 emplacement 4");
                    }
                    else if (skin4.SelectedIndex.ToString() == "2")
                    {
                        MessageBox.Show("huchman skin2 emplacement 4");
                    }
                }

                else if (empl4.SelectedIndex.ToString() == "4")
                {
                    if (skin4.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("huchman original emplacement 5");
                    }
                    else if (skin4.SelectedIndex.ToString() == "1")
                    {
                        MessageBox.Show("huchman skin4 emplacement 5");
                    }
                    else if (skin4.SelectedIndex.ToString() == "2")
                    {
                        MessageBox.Show("huchman skin2 emplacement 5");
                    }
                }

            }
            //choix ptizetre
            if (Choixperso4.SelectedIndex.ToString() == "5")
            {

                if (empl4.SelectedIndex.ToString() == "0")
                {
                    if (skin4.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("ptizetre original emplacement 1");
                    }
                    else if (skin4.SelectedIndex.ToString() == "1")
                    {
                        MessageBox.Show("ptizetre skin4 emplacement 1");
                    }
                    else if (skin4.SelectedIndex.ToString() == "2")
                    {
                        MessageBox.Show("ptizetre skin2 emplacement 1");
                    }

                }

                else if (empl4.SelectedIndex.ToString() == "1")
                {
                    if (skin4.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("ptizetre original emplacement 2");
                    }
                    else if (skin4.SelectedIndex.ToString() == "1")
                    {
                        MessageBox.Show("ptizetre skin4 emplacement 2");
                    }
                    else if (skin4.SelectedIndex.ToString() == "2")
                    {
                        MessageBox.Show("ptizetre skin2 emplacement 2");
                    }
                }

                else if (empl4.SelectedIndex.ToString() == "2")
                {
                    if (skin4.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("ptizetre original emplacement 3");
                    }
                    else if (skin4.SelectedIndex.ToString() == "1")
                    {
                        MessageBox.Show("ptizetre skin4 emplacement 3");
                    }
                    else if (skin4.SelectedIndex.ToString() == "2")
                    {
                        MessageBox.Show("ptizetre skin2 emplacement 3");
                    }
                }

                else if (empl4.SelectedIndex.ToString() == "3")
                {
                    if (skin4.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("ptizetre original emplacement 4");
                    }
                    else if (skin4.SelectedIndex.ToString() == "1")
                    {
                        MessageBox.Show("ptizetre skin4 emplacement 4");
                    }
                    else if (skin4.SelectedIndex.ToString() == "2")
                    {
                        MessageBox.Show("ptizetre skin2 emplacement 4");
                    }
                }

                else if (empl4.SelectedIndex.ToString() == "4")
                {
                    if (skin4.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("ptizetre original emplacement 5");
                    }
                    else if (skin4.SelectedIndex.ToString() == "1")
                    {
                        MessageBox.Show("ptizetre skin4 emplacement 5");
                    }
                    else if (skin4.SelectedIndex.ToString() == "2")
                    {
                        MessageBox.Show("ptizetre skin2 emplacement 5");
                    }
                }
            }

            //choix tily
            if (Choixperso4.SelectedIndex.ToString() == "6")
            {

                if (skin4.SelectedIndex.ToString() == "0")
                {
                    if (empl4.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("tily original emplacement 1");
                    }

                }
                else if (skin4.SelectedIndex.ToString() == "1")
                {
                    if (empl4.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("tily skin4 emplacement 1");
                    }
                }
                else if (skin4.SelectedIndex.ToString() == "2")
                {
                    if (empl4.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("tily skin2 emplacement 1");
                    }
                }
                else if (skin4.SelectedIndex.ToString() == "3")
                {
                    if (empl4.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("tily skin3 emplacement 1");
                    }
                }
                else if (skin4.SelectedIndex.ToString() == "4")
                {
                    if (empl4.SelectedIndex.ToString() == "0")
                    {
                        MessageBox.Show("tily skin4 emplacement 1");
                    }
                }

            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/sQMXyNQA");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/sQMXyNQA");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/sQMXyNQA");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/sQMXyNQA");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/sQMXyNQA");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/channel/UCC7lq5N1RVgDsAiTo1kKEeg");
        }

        private async void webView21_Click_2(object sender, EventArgs e)

        {


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }



        private void webView22_Click(object sender, EventArgs e)
        {

        }



        public class Adapters
        {
            public System.Collections.Generic.List<String> net_adapters()
            {
                List<String> values = new List<String>();
                foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
                {

                    values.Add(nic.Name);
                }
                return values;
            }
        }


        private void button16_Click_1(object sender, EventArgs e)
        {
            

            File.WriteAllText(cheminfichier, curItem);
            File.WriteAllText(cheminfichier2, curItem);
            MessageBox.Show(curItem+Choixcard) ;

            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            curItem = comboBox1.SelectedItem.ToString();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            Process.Start(@"C:\ProgramData\Caphyon\Advanced Installer\{D5348DE8-1023-4C18-B0F4-83CB3CA62F52}\Rayman Arena The Definitive Edition Online.exe");
        }

        private void BtnNomReseau_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.BtnNomReseau.Text);
            MessageBox.Show(CopieNomReseau);
        }

        private void BtnMdpReseau_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.BtnMdpReseau.Text);
            MessageBox.Show(CopieMdpReseau);
        }
    }
}
