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
    public partial class ModifNota : Form
    {
        float[] notation;
        Main parent;
        public ModifNota(Main parent)
        {
            InitializeComponent();
            notation = new float[3];
            this.parent = parent;
            notation[0] = parent.evaluations[0].Categories[0].Questions[0].Notation[0];
            notation[1] = parent.evaluations[0].Categories[0].Questions[0].Notation[1];
            notation[2] = parent.evaluations[0].Categories[0].Questions[0].Notation[2];

            note1.DecimalPlaces = 2;
            note2.DecimalPlaces = 2;
            note3.DecimalPlaces = 2;

            parent.Enabled = false;

            loadData();

        }

        /// <summary>
        /// Initialise la form
        /// </summary>
        private void loadData() //Initialiser la form
        {
            
            note1.Value = (decimal)notation[0];
            note2.Value = (decimal)notation[1];
            note3.Value = (decimal)notation[2];

        }

        /// <summary>
        /// Sauve les données de la mémoire tampon dans la mémoire principale de la Form parent
        /// </summary>
        private void saveData()
        {
            notation[0] = (float)note1.Value;
            notation[1] = (float)note2.Value;
            notation[2] = (float)note3.Value;
            foreach (var eval in parent.evaluations)
            {
                foreach (var cat in eval.Categories)
                {
                    if(cat.Questions.Count > 0 && cat.Subcategories.Count > 0)
                    {
                        foreach (var que in cat.Questions)
                        {
                            que.Notation[0] = notation[0];
                            que.Notation[1] = notation[1];
                            que.Notation[2] = notation[2];
                        }
                        foreach (var subcat in cat.Subcategories)
                        {
                            foreach (var quesubca in subcat.Questions)
                            {
                                quesubca.Notation[0] = notation[0];
                                quesubca.Notation[1] = notation[1];
                                quesubca.Notation[2] = notation[2];
                            }
                        }
                    }
                    else
                    {
                        if(cat.Questions.Count > 0)
                        {
                            foreach (var que in cat.Questions)
                            {
                                que.Notation[0] = notation[0];
                                que.Notation[1] = notation[1];
                                que.Notation[2] = notation[2];
                            }
                        }
                        if(cat.Subcategories.Count > 0)
                        {
                            foreach (var subcat in cat.Subcategories)
                            {
                                foreach (var quesubca in subcat.Questions)
                                {
                                    quesubca.Notation[0] = notation[0];
                                    quesubca.Notation[1] = notation[1];
                                    quesubca.Notation[2] = notation[2];
                                }
                            }
                        }
                    }

                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            saveData();
            parent.affichagePreview();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ModifNota_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Enabled = true;
        }
    }
}
