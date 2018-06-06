using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Categorie
    {
        string name;
        float coef;
        List<Question> questions;
        List<Categorie> subcategories;

        public Categorie(string name)
        {
            this.name = name;
            questions = new List<Question>();
            Subcategories = new List<Categorie>();
            coef = 1;
        }

        public Categorie(Categorie cat)
        {
            questions = new List<Question>();
            Subcategories = new List<Categorie>();
            name = cat.Name;
            coef = cat.Coef;
            foreach (var item in cat.questions)
            {
                Question quesBuffer = new Question(item.Enonce);
                quesBuffer.Coef = item.Coef;
                quesBuffer.Notation = item.Notation;
                quesBuffer.Reponse = item.Reponse;
                questions.Add(quesBuffer);
            }
            foreach (var item in cat.subcategories)
            {
                Categorie catBuffer = new Categorie(item);
                subcategories.Add(catBuffer);
            }
        }

        /// <summary>
        /// Fonction : Calcul de Moyenne d'une catégorie  ;
        /// Parametres : Aucun ;
        /// </summary>
        public float Moyenne
        {
            get
            {

                float addNote = 0;
                float addCoef = 0;
                //Si la catégorie a des questions et des sous-catégories
                if(Questions.Count > 0 && Subcategories.Count > 0)
                {
                    //Moyenne d'une catégorie avec le coefficient de chaque question
                    foreach (var item in Questions)
                    {
                        addNote += item.Note * item.Coef;
                        addCoef += item.Coef;
                    }
                    //Moyenne d'une catégorie avec le coefficient de chaque sous-catégories
                    foreach (var item in Subcategories)
                    {
                        addNote += item.Moyenne * item.Coef;
                        addCoef += item.Coef;
                    }
                    if (addCoef != 0)
                        return addNote / addCoef;
                    else
                        return 0;
                }
                else
                {
                    //Si la catégorie n'a que des catégories
                    if (Subcategories.Count > 0)
                    {
                        //Moyenne d'une catégorie avec le coefficient de chaque sous-catégories
                        foreach (var item in Subcategories)
                        {
                            addNote += item.Moyenne * item.Coef;
                            addCoef += item.Coef;
                        }
                        if (addCoef != 0)
                            return addNote / addCoef;
                        else
                            return 0;
                    }
                    //Si la catégorie n'a que des questions
                    if (Questions.Count > 0)
                    {
                        //Moyenne d'une catégorie avec le coefficient de chaque question
                        foreach (var item in Questions)
                        {
                            addNote += item.Note * item.Coef;
                            addCoef += item.Coef;
                        }
                        if (addCoef != 0)
                            return addNote / addCoef;
                        else
                            return 0;
                    }
                }
                //Si on ne rentre dans aucune catégorie, on renvoie 0
                return 0;

            }
        }

        //Propriétés...
        public string Name { get => name; set => name = value; }
        public float Coef { get => coef; set => coef = value; }
        public List<Question> Questions { get => questions; set => questions = value; }
        internal List<Categorie> Subcategories { get => subcategories; set => subcategories = value; }
    }
}
