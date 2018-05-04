using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Evaluation
    {
        //Données de la classe

        string date;
        string heure;

        Formateur format;

        Etudiant etud;

        string dureeStage;
        string debutEtFin;
        string difficulteStage;

        List<Categorie> categories;

        string satisfactionGlobale;

        string observation;
        string repriseEtudiant;

        /// <summary>
        /// Constructeur de la classe
        /// </summary>
        public Evaluation()
        {
            //On crée toutes les données a vide.
            etud = new Etudiant();
            format = new Formateur();
            categories = new List<Categorie>();
            //Sauf les questions. Chaque Evaluation à le même nombre finies de questions. Ici, nous initialisons juste les questions avec leur énoncé.
            //On met ensuite leur réponse à vide.
            //On ajoute les catégories en dur présentes de base dans les fichiers excel
            categories.Add(new Categorie("Le savoir-vivre du stagiaire"));
            categories.Add(new Categorie("Le savoir être professionnel"));
            //Puis on remplit les catégories des questions leurs étant propre, ici le savoir vivre du stagiaire
            categories[0].Questions.Add(new Question("Etre ponctuel et assidu"));
            categories[0].Questions.Add(new Question("Faire preuve de courtoisie "));
            categories[0].Questions.Add(new Question("Respecter du réglement de l'entreprise (code vestimentaire, sécurité, confidentialité ect...)"));
            //Idem pour la deuxième catégorie, sauf qu'ici on remplit aussi la catégorie de sous-catégories
            categories[1].Subcategories.Add(new Categorie("Activité et engagement au travail"));
            categories[1].Subcategories[0].Questions.Add(new Question("Comprendre et exécuter les tâches demandées"));
            categories[1].Subcategories[0].Questions.Add(new Question("Planifier et organiser son travail efficacement"));
            categories[1].Subcategories[0].Questions.Add(new Question("Anticiper le travail et faire preuve d'initiative"));
            categories[1].Subcategories[0].Questions.Add(new Question("Faire preuve d'autonomie dans la réalisation des tâches demandées"));
            categories[1].Subcategories[0].Questions.Add(new Question("Démontrer son intérêt et sa motivation"));
            categories[1].Subcategories[0].Questions.Add(new Question("Travailler efficacement sous les ordres d'un superviseur ou en équipe"));

            categories[1].Subcategories.Add(new Categorie("Esprit d'analyse"));
            categories[1].Subcategories[1].Questions.Add(new Question("S'adapter à la problématique"));
            categories[1].Subcategories[1].Questions.Add(new Question("Analyser les problèmes potentiels"));
            categories[1].Subcategories[1].Questions.Add(new Question("Trouver des solutions pertinentes aux problèmes rencontrés"));
            categories[1].Subcategories[1].Questions.Add(new Question("Demander de l'aide lorsque la situation l'exige"));

            categories[1].Subcategories.Add(new Categorie("Esprit de synthèse et communication"));
            categories[1].Subcategories[2].Questions.Add(new Question("Communiquer clairement (reporting oral et/ou écrit) sur son travail"));
            categories[1].Subcategories[2].Questions.Add(new Question("Prendre en considération les critiques constructives et apporter les correctifs demandés"));


            //On met chaque réponse à vide
            for (int i = 0; i < categories.Count; i++)
            {
                if(categories[i].Questions.Count > 0)
                {
                    for (int j = 0; j < categories[i].Questions.Count; j++)
                    {
                        categories[i].Questions[j].Reponse = "";
                    }
                }
                if(categories[i].Subcategories.Count > 0)
                {
                    for (int j = 0; j < categories[i].Subcategories.Count; j++)
                    {
                        for (int k = 0; k < categories[i].Subcategories[j].Questions.Count; k++)
                        {
                            categories[i].Subcategories[j].Questions[k].Reponse = "";
                        }
                    }
                }
            }
            dureeStage = "";
            debutEtFin = "";
            satisfactionGlobale = "";
            observation = "";
            repriseEtudiant = "";
            date = "";
            heure ="";
        }

        //Propriétés
        public string Date { get => date; set => date = value; }
        public string Heure { get => heure; set => heure = value; }
        public string DureeStage { get => dureeStage; set => dureeStage = value; }
        public string DebutEtFin { get => debutEtFin; set => debutEtFin = value; }
        public string SatisfactionGlobale { get => satisfactionGlobale; set => satisfactionGlobale = value; }
        public string Observation { get => observation; set => observation = value; }
        public string RepriseEtudiant { get => repriseEtudiant; set => repriseEtudiant = value; }

        /// <summary>
        /// Fonction : Calcul de Moyenne de l'évaluation
        /// Parametres : Aucun
        /// </summary>
        public float Moyenne
        {
            get
            {
                float moy = 0;
                float nb = 0;
                //Moyenne d'une catégorie avec le coefficient de chaque question
                foreach (var cat in categories)
                {
                    moy += cat.Moyenne * cat.Coef;
                    nb += cat.Coef;
                }
                if (nb != 0)
                    return moy / nb;
                else
                    return 0;
            }
        }

        public string DifficulteStage { get => difficulteStage; set => difficulteStage = value; }
        internal Formateur Format { get => format; set => format = value; }
        internal Etudiant Etud { get => etud; set => etud = value; }
        internal List<Categorie> Categories { get => categories; set => categories = value; }
    }
}
