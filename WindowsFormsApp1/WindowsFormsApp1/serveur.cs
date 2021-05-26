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
    public partial class serveur : Form
    {
        public serveur()
        {
            InitializeComponent();
        }
        private void Ajout_Load(object sender, EventArgs e)
        {
            string[] serveur = File.ReadAllLines(@"\serveur.txt");       //Déclartion d'un tableau nomée "serveur" remplie par le fichier serveur
            dgv1.RowCount = serveur.Length;                              //Le dgv a un nb de lignes équivalent aux nb de lignes du tableau "serveur"
            dgv1.ColumnCount = 1;                                        //Le dgv a 1 colonne
            dgv1.Columns[0].HeaderText = "Serveurs";                     //La colonne a pour nom "Serveurs"
            for (int i = 0; i < serveur.Length; i++)                     //Parcours le tableau
            {
                dgv1.Rows[i].Cells[0].Value = serveur[i];                //Rempli les lignes du dgv avec les lignes du tableau "serveur"     
            }
            dgv1.RowHeadersVisible = false;                              //Cache la colonne d'entete du dgv
        }
        private void btnTer_Click(object sender, EventArgs e)
        {            
            this.Close();                                               //Fermeture
        }
        private void btnSup_Click(object sender, EventArgs e)
        {
            try                                                                                //Essaie
            {
                if (dgv1.RowCount - 1 == 0)                                                    //Si le dgv n'a plus de ligne
                {
                    MessageBox.Show("Vous ne pouvez pas supprimmer tous les serveurs");        //Message d'erreur
                    return;                                                                    //Sortie
                }
            }
            catch
            {}
            foreach (DataGridViewCell oneCell in dgv1.SelectedCells)           //Pour chaqu'une des cellule du dgv
            {
                if (oneCell.Selected)                                          //Si une cellule est selectionnner
                {
                    string temp = Convert.ToString(oneCell.Value);            //Déclaration d'une variable temp qui prend la valeur de la cellule
                    dgv1.Rows.RemoveAt(oneCell.RowIndex);                     //Suppression de la cellule
                    string[] fichier = File.ReadAllLines(@"\serveur.txt");   //Déclaration d'un tableau "fichier" qui prend en valeur les lignes du fichier
                    for (int i = 0; i < fichier.Length; i++)                 //Parcours le tableau "fichier"
                    {
                        if (temp == fichier[i])                              //Si le mot de la cellule est trouvé dans le fichier
                        {
                            List<String> lines = File.ReadAllLines(@"\serveur.txt").ToList(); //Déclaration d'une variable lines qui prend en valeur les lignes du fichier et qui les met en liste
                            lines.RemoveAt(i);                                                //Efface le mot si il est trouvé
                            File.WriteAllLines(@"\serveur.txt", lines.ToArray());             //Réecrie les lignes du fichier sans la ligne du mot trouvé
                        }
                    }
                    (this.Owner as Form1).Controls["cbx1"].Text = "";                   //Nettoyage du combobox
                    string[] fichier2 = File.ReadAllLines(@"\serveur.txt");             //Déclaration d'un tableau "fichier2" qui prend le contenue du fichier
                    for (int i = 0; i < fichier2.Length; i++)                           //Parcours le fichier
                    {
                        (this.Owner as Form1).Controls["cbx1"].Text= fichier2[i];        //Complete le cbx1
                    }
                }
            }
        }
        private void btnAj_Click(object sender, EventArgs e)
        {
            bool vide = true;                                 //Déclaration
            for (int i = 0; i < dgv1.RowCount; i++)           //Parcours le datagridview
            {
                if (tbx1.Text == Convert.ToString(dgv1.Rows[i].Cells[0].Value)) //Comparaison de mots
                {
                    MessageBox.Show("Serveur déjà enregistrer");               //Message d'erreur
                    tbx1.Text = null;                                          //reset
                    vide = true;                                              //Modification de booléen
                    break;                                                     //Sortie
                }
            }
            if (tbx1.Text != "")                                            //Si le champs destinataire n'est pas vide
            {
                dgv1.Rows.Add(tbx1.Text);                                   //Ajout d'un ligne
                File.AppendAllText(@"\serveur.txt", tbx1.Text);            //Ajoute le contenue du champ destinataire au fichier en sautant une ligne
                tbx1.Text = null;                                         //reset le contenu
            }                      
            else                                                          //Sinon
            {
                if (vide == false)                                     //Si il n'y a pas de doublon
                {
                    MessageBox.Show("Entrez une  valeur dans le champ");  //Message d'erreur
                    return;                                               //Sortie
                }
            }           
        }
    }    
}
