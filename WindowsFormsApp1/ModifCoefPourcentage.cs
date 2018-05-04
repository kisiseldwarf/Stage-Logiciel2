using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ModifCoefPourcentage : Form
    {
        List<Categorie> categories; //donnée principale
        List<Control> controlsList; //Pour créer les contrôles dynamiquement
        Main parent;
        float coefTotal;
        //HasLoaded permet de savoir si la form se trouve dans un état cohérent, afin de ne pas 
        //Appeller certains évenements si la form n'a pas finie de s'initialiser.
        bool hasLoaded = false;

        /// <summary>
        /// Constructeur de la Form où sont initialisé toutes les données, et appellé toutes les fonctions devant être appellé afin de garantir un état cohérent à l'affichage de la form.
        /// </summary>
        /// <param name="parent"></param>
        public ModifCoefPourcentage(Main parent)
        {
            InitializeComponent();
            categories = new List<Categorie>();
            this.parent = parent;
            parent.Enabled = false;
            //Pour utiliser la fonction createGroupControls
            controlsList = new List<Control>();
            controlsList.Add(labelText1);
            controlsList.Add(coefNum1);
            panel1.AutoScroll = true;
            coefTotal = 0;
            loadData();

            Control[] buffer;
            buffer = Controls.Find("labelText1", true);
            buffer[0].Font = new Font("Arial", 8, FontStyle.Bold);
            buffer[0].Text = categories[0].Name;
            buffer = Controls.Find("coefNum1", true);
            categories[0].Coef = categories[0].Coef / coefTotal * 100;
            buffer[0].Text = categories[0].Coef.ToString();
            NumericUpDown npCat = (NumericUpDown)buffer[0];
            npCat.DecimalPlaces = 2;

            for (int i = 1; i < categories.Count; i++)
            {
                showCat(categories[i], 0);
            }
            hasLoaded = true;
        }

        /// <summary>
        /// Fonction affichant une catégorie dans la richBoxText (son énoncé et son coefficient), ainsi que ses questions et ses sous-catégories. 
        /// </summary>
        /// <param name="cat">Catégorie à afficher</param>
        private void showCat(Categorie cat, int subLevel)
        {
            Control[] buffer;
            int id = createGroupControls();

            buffer = Controls.Find("labelText" + id, true);
            buffer[0].Font = new Font("Arial", 8, FontStyle.Bold);
            for (int i = 0; i < subLevel; i++)
            {
                buffer[0].Text += "- ";
            }
            buffer[0].Text += cat.Name;

            buffer = Controls.Find("coefNum" + id, true);
            cat.Coef = cat.Coef / coefTotal * 100;
            buffer[0].Text = cat.Coef.ToString();

            NumericUpDown npCat = (NumericUpDown)buffer[0];
            npCat.DecimalPlaces = 2;
        }

        /// <summary>
        /// Fonction chargeant les données principales (les catégories) de la form Main dans la mémoire tampon de la form actuelle.
        /// </summary>
        private void loadData()
        {
            foreach (var cat in parent.evaluations[0].Categories)
            {
                Categorie catBuffer = new Categorie(cat);
                categories.Add(catBuffer);
                coefTotal += cat.Coef;
            }
        }

        /// <summary>
        /// Fonction : Crée un group de controls windows form en fonction du placement de controls crée antérieurement;
        /// Parametres : Aucun;
        /// </summary>
        /// <returns>L'ID des controls crée (chaque controls à son id à la fin de son nom)</returns>
        private int createGroupControls() //Crée l'ensemble de controls pour une regle en dessous des derniers controls de regles à avoir été crée
        {
            //Initialisation et déclaration des nouveaux controls
            int previous = controlsList.Count - 1; //Il en faut toujours au moins un
            Label labelText = new Label();
            NumericUpDown coefNum = new NumericUpDown();
            Point labelLoc = labelText.Location;
            Point coefLoc = coefNum.Location;

            Point previousNote3Loc = controlsList[previous].Location; //On reçoit toujours la note3

            //Modification de la location des controls crée
            labelLoc = previousNote3Loc;
            coefLoc = previousNote3Loc;

            labelLoc.Y += 40;
            labelLoc.X -= 550;
            coefLoc.X += 0;
            coefLoc.Y += 40;

            labelText.Location = labelLoc;
            coefNum.Location = coefLoc;
            labelText.Size = new Size(450, 13);

            //Ajout du nom (pour la cohérence de la création)
            int previousControlID = Int32.Parse(controlsList[previous].Name.Substring(7));
            previousControlID++;

            labelText.Name = "labelText" + previousControlID;
            coefNum.Name = "coefNum" + previousControlID;

            //Ajout des controls crée au panel (pour la scrollbar)
            panel1.Controls.Add(labelText);
            panel1.Controls.Add(coefNum);

            //Ajout à la liste (pour la perennité de la fonction)
            controlsList.Add(labelText);
            controlsList.Add(coefNum);

            coefNum.ValueChanged += new EventHandler(coefNum1_ValueChanged);

            return previousControlID;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void validateBut_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < parent.evaluations.Count; i++)
            {
                saveData(categories, parent.evaluations[i].Categories);
            }

            ModifCoef mc = new ModifCoef(parent);
            mc.Show(parent);

            Close();
        }

        /// <summary>
        /// Fonction permettant la copie des données de source dans dest. source doit être de la même organisation de données que dest.
        /// </summary>
        /// <param name="source">La liste de catégorie officiant comme les données à copier</param>
        /// <param name="dest">La liste de catégories recevant ces données</param>
        private void saveData(List<Categorie> source, List<Categorie> dest)
        {
            for (int i = 0; i < source.Count; i++)
            {
                dest[i].Coef = source[i].Coef / 10;
            }
        }

        /// <summary>
        /// Fonction prenant en charge l'evenement appui sur le bouton annuler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelBut_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Fonction prenant en charge l'evenement fermeture de la form;
        /// /!\ La signature de la fonction est un standard visual studio.
        /// </summary>
        /// <param name="sender">Objet appellant la fonction</param>
        /// <param name="e">Parametres et informations supplémentaires de l'evenement</param>
        private void ModifCoef_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Enabled = true;
            parent.affichagePreview();
        }

        /// <summary>
        /// Fonction qui modifie les données en mémoire tampon et les remplacent par celles rentrées dans la form actuelle.
        /// </summary>
        /// <param name="categories">Une liste de catégorie où remplacer nos données</param>
        /// <param name="sender">Control ayant appellé la fonction évenementielle ayant elle-même appellé cette fonction</param>
        private void refreshData(List<Categorie> categories, object sender)
        {
            NumericUpDown np = (NumericUpDown)sender;
            int id = Int32.Parse(np.Name.Substring(7));
            Control[] buffer = Controls.Find("labelText" + id, true);
            if (categories.Find(x => x.Name == buffer[0].Text) != null)
            {
                categories[categories.FindIndex(x => x.Name == buffer[0].Text)].Coef = (float)np.Value;
            }
        }
        private void coefNum1_ValueChanged(object sender, EventArgs e)
        {
            if (hasLoaded)
                refreshData(categories, sender);
        }
    }
}
