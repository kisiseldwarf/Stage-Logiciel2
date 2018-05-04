using ExcelDataReader;
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
    public partial class Main : Form
    {
        public List<Evaluation> evaluations; //La donnée principale, contenant toutes les évaluations.

        /// <summary>
        /// Constructeur de la Form
        /// </summary>
        /*
         * /!\ La signature de la fonction est standard au c sharp, je ne l'ai pas choisi.
         * DESCRIPTION : 
         *   Cette fonction est le constructeur de la Form Main. Elle est donc la première fonction appellée.
         *   InitializeComponent(),la fonction appellée, est une fonction de visual studio qui est standard et qui est présente automatiquement
         *   dans tous les constructeurs de Form. Elle permet de bien faire le lien entre les variables script et les Controls leur étant lié.
         *   
         *   Comme c'est le constructeur, on vérifie bien que nos variables sont dans un état cohérent après son appel. 
         *   Donc, nous instancions notre liste d'évaluations. Celui ci ne sera donc jamais égal à null, mais aura, si il n'y a aucun fichier de chargé,
         *   un nombre d'éléments égal à 0.
         */

        public Main()
        {
            InitializeComponent();

            evaluations = new List<Evaluation>();
            //List jamais null,tester sur Count
            affichage();
        }

        /// <summary>
        /// Lit un fichier excel et renvoie ses données sous la forme d'une liste d'évaluations.
        /// </summary>
        /// <param name="path">Chemin du fichier Excel</param>
        /// <returns>Une liste d'évaluations</returns>

        /* PARAM : 
         * path : Chemin vers le fichier Excel
         * RETOURNE :
         * Une liste d'évaluation contenant toutes les données du sondage contenue dans le fichier excel.
         */

        private List<Evaluation> lireExcel(string path)
        {
            //On ouvre le fichier au chemin path et on lui associe un objet ExcelReader permettant de lire un fichier de type Excel
            var stream = File.Open(path, FileMode.Open, FileAccess.Read);
            var excelReader = ExcelReaderFactory.CreateReader(stream);

            //On crée une mémoire tampon qui nous servira à stocker les données lues et qu'on renverra à la fin
            List<Evaluation> res = new List<Evaluation>();

            excelReader.Read(); //On passe directement à la deuxieme ligne : La première ligne est inutile

            while (excelReader.Read()) //Tant qu'on peux lire : On parcours toutes les lignes
            {
                //Si on lit une nouvelle ligne, cela veut dire qu'il y'a une nouvelle évaluation
                Evaluation eval = new Evaluation(); 
                //On parcours toutes les colonnes de la ligne
                for (int i = 0; i < excelReader.FieldCount; i++)
                {
                    //Puis, en fonction de l'index de la colonne, on insère sa donnée dans une case spécifique d'évaluation.
                    switch (i)
                    {
                        case 0:
                            eval.Date = excelReader.GetString(i);
                            break;
                        case 1:
                            eval.Heure = excelReader.GetString(i);
                            break;
                        case 2:
                            eval.Etud.Prenom = excelReader.GetString(i);
                            break;
                        case 3:
                            eval.Etud.Nom = excelReader.GetString(i);
                            break;
                        case 4:
                            eval.Etud.Formation = excelReader.GetString(i);
                            break;
                        case 5:
                            eval.DureeStage = excelReader.GetString(i);
                            break;
                        case 6:
                            eval.DebutEtFin = excelReader.GetString(i);
                            break;
                        case 7:
                            eval.Format.Prenom = excelReader.GetString(i);
                            break;
                        case 8:
                            eval.Format.Nom = excelReader.GetString(i);
                            break;
                        case 9:
                            eval.Format.Fonction = excelReader.GetString(i);
                            break;
                        case 10:
                            eval.Format.Entreprise = excelReader.GetString(i);
                            break;
                        case 11:
                            eval.Format.Ville = excelReader.GetString(i);
                            break;
                        case 12:
                            eval.Format.CodePostal = excelReader.GetDouble(i).ToString();
                            break;
                        case 13:
                            eval.Format.Email = excelReader.GetString(i);
                            break;
                        case 14:
                            Type type = excelReader.GetValue(i).GetType(); //On teste le type pour savoir si c'est un string ou un double
                            if (type == typeof(double))
                                eval.Format.Téléphone = excelReader.GetDouble(i).ToString();
                            else
                                eval.Format.Téléphone = excelReader.GetString(i);
                            break;
                        case 15:
                            if (excelReader.GetString(i) == "oui")
                                eval.Format.ACompetencesInformatique = true;
                            else
                                eval.Format.ACompetencesInformatique = false;
                            break;
                        case 16:
                            eval.Format.DomaineCompetence = excelReader.GetString(i); 
                            break;
                        case 17:
                            eval.DifficulteStage = excelReader.GetString(i);
                            break;
                        case 32:
                            eval.SatisfactionGlobale = excelReader.GetString(i);
                            break;
                        case 33:
                            eval.Observation = excelReader.GetString(i);
                            break;
                        case 34:
                            eval.SatisfactionGlobale = excelReader.GetString(i);
                            break;
                        case 35:
                            eval.RepriseEtudiant = excelReader.GetString(i);
                            break;
                        default:
                            break;
                    }

                    //On n'utilise plus le switch à partir de l'index 17 car
                    //Jusqu'a l'index 31, les données sont du même type (type Question).

                    //Ici, on remplie la première catégorie
                    if(i > 17 && i <= 20) 
                    {
                        eval.Categories[0].Questions[i - 18].Reponse = excelReader.GetString(i);
                    }

                    //Ici, on remplit la deuxième catégorie
                    ////Première sous-catégorie
                    if(i >= 21 && i <= 26)
                    {
                        eval.Categories[1].Subcategories[0].Questions[i - 21].Reponse = excelReader.GetString(i);  
                    }
                    ////Deuxieme sous-catégorie
                    if (i >= 27 && i <= 30)
                    {
                        eval.Categories[1].Subcategories[1].Questions[i - 27].Reponse = excelReader.GetString(i);
                    }             
                    ////Troisième sous-catégorie
                    if (i >= 31 && i <= 32)
                    {
                        eval.Categories[1].Subcategories[2].Questions[i - 31].Reponse = excelReader.GetString(i);
                    }
                }
                res.Add(eval); //Ajout de l'évaluation chargée
            }
            excelReader.Close(); //On n'oublie pas de fermer le fichier afin de permettre à un autre logiciel d'y acceder une fois notre chargement effectué.
            return res; //On retourne la liste d'évaluation chargée.
        }


        /// <summary>
        /// Fonction evenementielle gérant le changement de texte dans la TextBox "Source"
        /// </summary>
        /// <param name="sender">Objet appellant l'evenement</param>
        /// <param name="e">Format de données contenant plusieurs infirmations concernant l'evenement déclenché</param>
        
        /* PARAM : object sender : Objet appellant l'evenement
        *         EventArgs e : format de données contenant plusieurs informations concernant l'evenement déclenché
        * /!\ La signature de la fonction est standard au c sharp, je ne l'ai pas choisi.
        * DESCRIPTION : 
        *   Cette fonction gère l'évenenement de changement de texte dans le control TextBox "Source".
        *   A chaque changement de texte, donc à chaque changement de source (car il n'est possible de modifier le texte qu'avec le bouton "browse"),
        *   je remplace les données présente dans la list évaluation par les données présente dans le nouveau fichier excel selectionné.
        *   Puis, je rafraichis l'affichage.
        */

        private void source_TextChanged(object sender, EventArgs e)
        {
            evaluations = lireExcel(source.Text);
            affichagePreview();
            affichage();
        }

        /// <summary>
        /// Fonction evenementielle gérant l'appui sur le bouton "Browse"
        /// </summary>
        /// <param name="sender">Objet appellant l'evenement</param>
        /// <param name="e">Format de données contenant plusieurs infirmations concernant l'evenement déclenché</param>

        /* PARAM : object sender : Objet appellant l'evenement
        *         EventArgs e : format de données contenant plusieurs informations concernant l'evenement déclenché
        * /!\ La signature de la fonction est standard au c sharp, je ne l'ai pas choisi.
        * DESCRIPTION : 
        *   Fonction evenementielle gérant l'appui sur le bouton "Browse".
        *   //TODO
        */

        private void browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Importer un fichier source";
            dialog.Filter = "Fichier Excel (.xlsx)|*.xlsx"; 
            DialogResult res;
            res = dialog.ShowDialog();
            if (res == DialogResult.OK)
                source.Text = dialog.FileName.Replace("/", "//");
        }

        /// <summary>
        /// Affichage de la preview
        /// </summary>

        /*
        * DESCRIPTION : 
        *  Cette procédure ne fait qu'afficher les données chargées contenues dans evaluations.
        *  Si on veut modifier l'affichage, on doit modifier cette procédure.
        */
        public void affichagePreview()
        {
            filePreview.Clear();
            for (int i = 0; i < evaluations.Count; i++)
            {
                filePreview.Text += evaluations[i].Moyenne + "  :   " + evaluations[i].Observation+  "\n";
                filePreview.Text += "\n";
            }
        }

        private void affichage()
        {
            if(source.Text == "")
            {
                modifyButton.Enabled = false;
                modifyCoef.Enabled = false;
            }
            else
            {
                modifyButton.Enabled = true;
                modifyCoef.Enabled = true;
            }
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            ModifNota mn = new ModifNota(this);
            mn.Show(this);
        }

        private void createProfil_Click(object sender, EventArgs e)
        {
            ModifCoefPourcentage mc = new ModifCoefPourcentage(this);
            mc.Show(this);
        }

        /// <summary>
        /// Fonction permettant d'exporter en CSV les données contenues dans évaluations
        /// </summary>
        /// <param name="path">chemin du fichier </param>
        private void exportCSV(string path)
        {

        }
    }
}
