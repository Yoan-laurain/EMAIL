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
    public partial class Form1 : Form
    {
        int val = 0;                            //Déclaration d'un entier "val" à 0
        string [] filePath = new string[20];    //Déclaration d'un tableau "filePath" à 20 lignes
        int nb = 0;                            //Déclaration d'un entier"nb" à 
        public Form1()
        {
            InitializeComponent();
        }
        private void btnEnvoiMail_Click(object sender, EventArgs e)
        {
            SmtpClient clientSmtp = new SmtpClient(cbx1.Text);      //Définit le serveur pour envoyer    
            MailMessage monMessage = new MailMessage();             //Création d'un email
            monMessage.Body = rtx1.Text;                            //Envoie Bonjour en corps d'email
            monMessage.Subject = Convert.ToString(tbx5.Text);       //Définit l'objet du mail
            if (filePath != null)                                   //Si le tableau n'est pas vide
            {
                int i = 0;
                while (filePath[i]!=null)                           //Pour chaque éléments trouvé
                {                   
                    Attachment data = new Attachment(filePath[i]);  //Déclaration d'une nouvelle piece jointe
                    monMessage.Attachments.Add(data);               //Ajout
                    i++;
                }
            }
                try
                {
                    new MailAddress(tbx1.Text);                                     //Essai l'adresse email du champ Destinataire
                    MailAddress destinataire = new MailAddress(tbx1.Text);          //Déclare un adresse email "destinataire" qui^prend la valeur de tbx1
                    monMessage.CC.Add(destinataire);                                //Ajoute un destinataire
                }
                catch
                {
                    MessageBox.Show("Echec : Email Destinataire incorrecte");   //message d'erreur
                    tbx1.Text = null;                                           //reset le contenu
                    return;                                                     //Sortie
                }            
            if (tbx2.Text != "")                                                     //Si le champs du 2eme destinataire n'est pas vide
            {
                try
                {
                    new MailAddress(tbx2.Text);                                      //Essai l'adresse email du champ Destinataire2
                    MailAddress destinataire2 = new MailAddress(tbx2.Text);          //Déclare un adresse email "destinataire2" qui^prend la valeur de tbx2
                    monMessage.CC.Add(destinataire2);                                //Ajoute un 2ème destinataire 
                }
                catch
                {
                    MessageBox.Show("Echec : Email du deuxieme est Destinataire incorrecte");   //message d'erreur
                    tbx2.Text = null;                                                           //reset le contenu
                    return;                                                                     //Sortie
                }
            }
            if (tbx3.Text != "")                                                    //Si le champ du 3ème destinataire n'est pas vie' 
            {
                try
                {
                    new MailAddress(tbx3.Text);                                     //Essai l'adresse email du champ Destinataire3
                    MailAddress destinataire3 = new MailAddress(tbx3.Text);         //Déclare un adresse email "destinataire3" qui^prend la valeur de tbx2
                    monMessage.Bcc.Add(destinataire3);                              //Ajoute le 3ème destinataire en copie cachée
                }                  
                catch
                {
                    MessageBox.Show("Echec : Email du deuxieme est Destinataire incorrecte");   //message d'erreur
                    tbx2.Text = null;                                                          //reset le contenu
                    return;                                                                   //Sortie
                }
            }           
            try
            {
                new MailAddress(tbx4.Text);                                     //essai l'adresse email du champ Expéditeur
                MailAddress expediteur = new MailAddress(tbx4.Text);            //Déclare un adresse email "Expéditeur" qui^prend la valeur de tbx1
                monMessage.From = expediteur;                                   //Le champ Expéditeur(du mail) est completer avec le contenue de la tbx1 
            }
            catch
            {
                MessageBox.Show("Echec : Email Expéditeur incorrecte"); //Message d'erreur
                tbx4.Text = null;                                       //reset le contenu
                return;                                                 //Sortie
            }                      
            try
            {
                clientSmtp.Send(monMessage);                               //Essaye d'envoyer le mail
                MessageBox.Show("Le message a été envoyé");                //Message réussite
            }
            catch (Exception ex)
            {
                MessageBox.Show("Echec : " + ex.Message);                   //Message échec
            }
            if(filePath !=null)                                             //Si filePath[i] n'est pas vide
            {
                for(int i=0;i<filePath.Length && filePath[i]!= null;i++)         //Parcours le fichier
                {
                    Attachment data = new Attachment(filePath[i]);               //Crée un piece jointe qui prend la valeur de la ligne du fichier
                    monMessage.Attachments.Add(data);                            //Ajoute la piece jointe au corps du mail
                }
            }
            nb = 0;
        }
        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();                                                    //Ferme le programme
        }

        private void btnAnnul_Click(object sender, EventArgs e)
        {
            tbx1.Text = null;                                                //Reset tous les champs
            tbx2.Text = null;                                                //
            tbx3.Text = null;                                                //
            tbx4.Text = null;                                                //
            tbx5.Text = null;                                                //
            tbx6.Text = null;                                                //
            rtx1.Text = null;                                                //
            rtx1.Text = "Entrez votre message ici";                          //
            nb = 0;
            filePath=null;
        }
        private void btnServ_Click(object sender, EventArgs e)
        {            
            serveur Ajout = new serveur();                                  //Déclaration
            Ajout.Owner = this;                                             //Prise de possesion
            Ajout.ShowDialog();                                             //Ouvertue de la form "ajout"
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {         
            string[] serveur;                                       //Crée un tableau nommé "serveur"
            if (File.Exists(@"\serveur.txt"))                       //Si le fichier existe
            {}
            else                                                   //Sinon
            {
                StreamWriter monSW = new StreamWriter(@"\serveur.txt"); //Déclare d'un nouveau StreamWriter pour le fichier
                monSW.WriteLine("smtp.orange.fr");                     //Ecriture d'un ligne dans le fichier
                monSW.WriteLine("smtp.sfr.fr");                        //
                monSW.WriteLine("smtp.free.fr");                       //
                monSW.WriteLine("smtp.bouygtel.fr");                  //
                monSW.WriteLine("envoi.ac-bordeaux.fr");               //
                monSW.Close();                                        //Fermeture du StreamWriter
                monSW.Dispose();                                      //Néttoyage du StreamWriter              
            }
            serveur = File.ReadAllLines(@"\serveur.txt");            //Le tableau "serveur" est rempli avec le contenu du fichier     
            rtx1.AppendText("Ecrivez votre message ici");            //Affichage de message dans la richtextbox
        }         
        private void btnA4_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog(); // Crée un boite de dialogue
            bool var = false;                                 //Déclaration d'un booléen "var" à faux
            if (fileDialog.ShowDialog() == DialogResult.OK)  //Si le nom du fichier a passer les diagnostics
            {
                for (int i=0;i < filePath.Length && var !=true;i++)  //Pacours le tableau
                {
                    if (filePath[i]==null)                          //Si il y a un espace libre
                    {
                        filePath[i] = fileDialog.FileName;          //Ecriture
                        var = true;                                 //var passe de false à true
                        MessageBox.Show("Piece jointe ajouté!");    //Affichage pour l'utilisateur
                    }
                }               
            }
            string test = tbx6.Text;                                     //Déclaration d'une variable "test" qui prend le contenue de tbx6
            for(int i =0;i<filePath.Length && filePath[i]!=null;i++)     //Parcours le tableau
            {
                tbx6.Text = null;                                       //reset la tbx6
                tbx6.Text = test+filePath[i]+";";                      //tbx6 prend la valeur du nom du fichier
            }
            fileDialog.Dispose();                                     //Nettoie   
        }
        private void btnCont_Click(object sender, EventArgs e)
        {
            Contact contact = new Contact();                    //Déclaration
            contact.ShowDialog();                               //Affiche la form "contact"
        }

        private void btnSel1_Click(object sender, EventArgs e)
        {
            val = 1;                                            
           
            Destinataire destinataire= new Destinataire();     //Déclaration
            destinataire.Owner = this;                        //Prise de possession
            destinataire.ShowDialog();                       //Affiche la form "destinataire"
            if (tbx1.Text!="")                               //Si le champ "destinataire" est completer
            {
                btnSel1.Enabled = false;                   //Désactive le boutton selectionner
            }
           
        }
        private void btnSel2_Click(object sender, EventArgs e)
        {
            val = 2;
            Destinataire destinataire = new Destinataire(); //déclaration 
            destinataire.Owner = this;                     //Prise de possesion
            destinataire.ShowDialog();                     //Affiche la form "destinataire"
            if (tbx2.Text != "")                           //Si le champ "destinataire2" est completer
            {
                btnSel2.Enabled = false;                   //Désactive le boutton selectionner
            }
        }
        private void btnSel3_Click(object sender, EventArgs e)
        {
            val = 3;                                           
            Destinataire destinataire = new Destinataire();    //Déclaration 
            destinataire.Owner = this;                         //Prise de possession
            destinataire.ShowDialog();                         //Affiche la form "destinataire"
            if (tbx3.Text != "")                               //Si le champ "destinataire2" est completer
            {
                btnSel3.Enabled = false;                       //Desactive le bouton selectionner
            }
        }
        private void tbx1_TextChanged(object sender, EventArgs e)
        {
            if (tbx1.Text=="")                        //Si le champs du 1er destinataire est vide
            {
                btnSel1.Enabled = true;             //Active le bouton "btnSel1"
            }          
        }
        public Int32 getVal()
        {
            return val;                              //Renvoie la valeur de val
        }
        private void tbx2_TextChanged(object sender, EventArgs e)
        {
            if (tbx2.Text == "")                   //Si le champs du 2ème destinataire est vide
            {
                btnSel2.Enabled = true;           //Active le bouton "btnSel2"
            }
        }
        private void tbx3_TextChanged(object sender, EventArgs e)
        {
            if (tbx3.Text == "")                       //Si le champs du 3ème destinataire est vide
            {
                btnSel3.Enabled = true;                 //Active le bouton "btnSel3"
            }
        }
        private void cbx1_Click(object sender, EventArgs e)
        {
            cbx1.Items.Clear();                                              //Nettoyage du combobox
            string[] serveur = File.ReadAllLines(@"\serveur.txt");           //Le tableau "serveur" est rempli avec le contenu du fichier 
            for (int i = 0; i < serveur.Length; i++)                        //Boucle
            {
                cbx1.Items.Add(serveur[i]);                                //Remplie le cbx
            }
        }
        private void rtx1_Click(object sender, EventArgs e)
        {           
            if (nb==0)                   //Netoyage du rich text box
            {                           //
                rtx1.Clear();           //
            }                           //
            nb++;
        }
    }
}


