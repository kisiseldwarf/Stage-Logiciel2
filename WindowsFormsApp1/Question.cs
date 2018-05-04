using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Question
    {
        string enonce;
        string reponse;
        float coef;
        float[] notation;

        public Question(string ques)
        {
            Enonce = ques;
            coef = 1;
            //La notation par défaut
            Notation = new float[3];
            Notation[0] = 5;
            Notation[1] = 12;
            Notation[2] = 18;
        }

        public string Enonce { get => enonce; set => enonce = value; }
        public string Reponse { get => reponse; set => reponse = value; }
        public float Coef { get => coef; set => coef = value; }

        /// <summary>
        /// Fonction : Calcul de la note d'une Question
        /// Parametres : Aucun
        /// </summary>
        public float Note
        {
            get
            {
                //En fonction de la réponse (qui est une chaîne de caractère), on attribue une note
                switch (reponse)
                {
                    case "Peu satisfaisant":
                        return Notation[0];
                    case "Satisfaisant":
                        return Notation[1];
                    case "Très satisfaisant":
                        return Notation[2];
                }
                //Si on ne trouve aucun string correspondant, alors on retourne 0
                return 0;
            }
        }

        public float[] Notation { get => notation; set => notation = value; }
    }
}
