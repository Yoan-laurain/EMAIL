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

namespace WindowsFormsApp1
{
    public partial class Destinataire : Form
    {
        string temp;                                          //Déclaration
        public Destinataire()
        {
            InitializeComponent();
        }  
        private void Destinataire_Load(object sender, EventArgs e)
        {
            if (File.Exists(@"\Contact.txt "))                     //Si le fichier existe
            { }
            else                                                   //Sinon
            {
                StreamWriter monSW = new StreamWriter(@"\Contact.txt "); //Déclare d'un nouveau StreamWriter pour le fichier
                monSW.WriteLine("ghost.33190@gmail.com");                 //Ecriture d'un ligne dans le fichier
                monSW.Close();                                           //Fermeture du StreamWriter
                monSW.Dispose();                                         //Néttoyage du StreamWriter                
            }
            string[] Contacts;                                            //Déclaration d'un tableau contact
            Contacts = File.ReadAllLines(@"\Contact.txt ");               //Remple le tbleau contact avec le contenue du fichier contact
            dgv1.RowCount = Contacts.Length;                              //Le dgv a un nb de lignes équivalent aux nb de lignes du tableau "serveur"
            dgv1.ColumnCount = 1;                                        //Le dgv a 1 colonne
            dgv1.RowHeadersVisible = false;                              //Cache la colonne d'entete du dgv
            dgv1.Columns[0].HeaderText = "Contacts";                     //Le nom de la colonne est "contacts"

            for (int i = 0; i < Contacts.Length; i++)                   //Parcours le tableau "Contact"
            {
                dgv1.Rows[i].Cells[0].Value = Contacts[i];             //Remplie le dgv
            }           
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            int val = (this.Owner as Form1).getVal();                //Declaration d'une variable "val" qui prend le contenue d'une fonction
            if(val==1)                                               //Si
            {
                if (temp != (this.Owner as Form1).Controls["tbx1"].Text && temp != (this.Owner as Form1).Controls["tbx2"].Text && temp != (this.Owner as Form1).Controls["tbx3"].Text) //Si l'email est différent des autres utilisé
                {
                    (this.Owner as Form1).Controls["tbx1"].Text += temp; //Remplie le le champ destinataire avec le contact selctionner
                }
                else                                                    //Sinon
                {
                    MessageBox.Show("Email déja utilisé");             //Message d'erreur
                }
            }
            if(val==2)                                                //Si
            {
                if (temp != (this.Owner as Form1).Controls["tbx1"].Text && temp != (this.Owner as Form1).Controls["tbx2"].Text && temp != (this.Owner as Form1).Controls["tbx3"].Text)//Si l'email est différent des autres utilisé
                {
                    (this.Owner as Form1).Controls["tbx2"].Text += temp; //Remplie le champ du 2ème destinataire avec le contact selctionner
                }
                else
                {
                    MessageBox.Show("Email déja utilisé");             //Message d'erreur
                }
            }
            if(val==3)                                                //Si
            {
                if (temp != (this.Owner as Form1).Controls["tbx1"].Text && temp != (this.Owner as Form1 ).Controls["tbx2"].Text && temp != (this.Owner as Form1).Controls["tbx3"].Text)//Si l'email est différent des autres utilisé
                {
                    (this.Owner as Form1).Controls["tbx3"].Text += temp; //Remplie le tbx3 avec le contact selctionner
                }
                else
                {
                    MessageBox.Show("Email déja utilisé");               //Message d'erreur
                }
            }
            val = 0;                                                    //Reset
            this.Close();                                              //Fermeture
        } 
       public void btn1_Click(object sender, EventArgs e)
       {            
            foreach (DataGridViewCell oneCell in dgv1.SelectedCells)           //Pour chaqu'une des cellule du dgv
            {
                if (oneCell.Selected )                                         //Si une cellule est selectionnner
                {
                     temp = Convert.ToString(oneCell.Value);                  //Déclaration d'une variable temp qui prend la valeur de la cellule                         
                }
            }                                  
       }
    }
}
