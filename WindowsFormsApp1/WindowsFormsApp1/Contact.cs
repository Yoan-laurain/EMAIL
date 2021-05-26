using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Contact : Form
    {
        public Contact()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            if (File.Exists(@"\Contact.txt "))                      //Si le fichier contact existe
            {}
            else                                                    //Sinon
            {
                StreamWriter monSW = new StreamWriter(@"\Contact.txt "); //Déclare d'un nouveau StreamWriter pour le fichier
                monSW.WriteLine("ghost.33190@gmail.com");                //Ecriture d'un ligne dans le fichier
                monSW.Close();                                           //Fermeture du StreamWriter
                monSW.Dispose();                                         //Néttoyage du StreamWriter                
            }
            string[] Contacts;                                          //déclaration d'un tableau contacts
            Contacts = File.ReadAllLines(@"\Contact.txt ");             //Complete le tableau contacts avec le contenue du fichier contact
            dgv1.RowCount = Contacts.Length;                            //Le dgv a un nb de lignes équivalent aux nb de lignes du tableau "serveur"
            dgv1.ColumnCount = 1;                                       //Le dgv a 1 colonne
            dgv1.RowHeadersVisible = false;                             //Cache la colonne d'entete du dgv
            dgv1.Columns[0].HeaderText = "Contacts";                    //La coloone a pour nom contacts

            for (int i = 0; i < Contacts.Length; i++)                   //Parcours le tableau
            {
                dgv1.Rows[i].Cells[0].Value = Contacts[i];              //Complete le dgv1
            }           
        }
        private void btnTer_Click(object sender, EventArgs e)
        {
            this.Close();                                              //Fermeture
        }
        private void btnAj_Click(object sender, EventArgs e)
        {
            bool vide = true;                                       //Déclaration
            try
            {
                new MailAddress(tbx1.Text);                             //essai l'adresse email du champ Expéditeur
            }
            catch
            {
                MessageBox.Show("Echec : Format Email incorrecte");     //Message d'erreur
                tbx1.Text = null;                                       //reset le contenu
                return;                                                 //Sortie
            }
            
            for (int i=0;i<dgv1.RowCount;i++)                                     //Parcours le datagridview
            {
                if (tbx1.Text==Convert.ToString(dgv1.Rows[i].Cells[0].Value))     //Comparaison de mots
                {
                    MessageBox.Show("Email déjà enregistrer");                   //Message d'erreur
                    tbx1.Text = null;                                           //Reset
                    vide= true;                                             //Modification du booléen
                    break;                                                      //Sortie
                }               
            }
            if (tbx1.Text!="")                                            //Si le champs destinataire n'est pas vide                                               
            {
                dgv1.Rows.Add(tbx1.Text);                                //Ajout d'un ligne
                File.AppendAllText(@"\Contact.txt ", tbx1.Text);        //Ajoute le contenue du champ destinataire au fichier en sautant une ligne
                tbx1.Text = null;                                       //Reset
            } 
            else                                                       //Sinon
            {
                if (vide == false)                                                  //Si le champs est vide
                {
                    MessageBox.Show("Entrez une  valeur dans le champ");            //Message d'erreur
                    return;                                                         //Sortie
                }
            }
        }
        private void btnSup_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell oneCell in dgv1.SelectedCells)      //Parcours toutes les cellules du datagridview
            {
                string temp = Convert.ToString(oneCell.Value);            //Déclaration d'une variable temp qui prend la valeur de la cellule
                string[] fichier = File.ReadAllLines(@"\Contact.txt ");   //Déclaration d'un tableau "fichier" qui prend en valeur les lignes du fichier
                for (int i = 0; i < fichier.Length; i++)                  //Pacour le tableau
                {
                    if (temp == fichier[i])                               //Si le mot de la cellule est trouvé dans le fichier
                    {
                        List<String> lines = File.ReadAllLines(@"\Contact.txt ").ToList(); //Déclaration d'une variable lines qui prend en valeur les lignes du fichier et qui les met en liste
                        lines.RemoveAt(i);                                                //Efface le mot si il est trouvé
                        File.WriteAllLines(@"\Contact.txt ", lines.ToArray());            //Réecrie les lignes du fichier sans la ligne du mot trouvé
                    }
                }
                if (oneCell.Selected)                                         //Si la cellule est selectionner
                {
                   dgv1.Rows.RemoveAt(oneCell.RowIndex);                     //Suppression de la cellule
                }
            }
        }
    }
}
