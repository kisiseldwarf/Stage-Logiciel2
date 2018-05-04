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
    public partial class createProfil : Form
    {
        List<Control> controlsList;
        Evaluation evaluation;
        public createProfil(Main parent, Evaluation evaluation)
        {
            InitializeComponent();
            this.evaluation = evaluation;
            controlsList = new List<Control>();
            //Pour créer des controls
            controlsList.Add(numericUpDown1);
            controlsList.Add(label1);
        }
        private int createGroupControls() //Crée l'ensemble de controls pour une regle en dessous des derniers controls de regles à avoir été crée
        {
            int previous = controlsList.Count - 1; //Il en faut toujours au moins un
            Label label = new Label();
            NumericUpDown pourc = new NumericUpDown();
            Point labelLoc = label.Location;
            Point pourcLoc = label.Location;
            Point previousLabelLoc = controlsList[previous].Location; //On reçoit toujours le label

            labelLoc = previousLabelLoc;
            pourcLoc = previousLabelLoc;
            labelLoc.Y += 40;
            pourcLoc.X += 130;
            pourcLoc.Y += 40;

            label.Location = labelLoc;
            pourc.Location = pourcLoc;
            int previousNumberName = Int32.Parse(controlsList[previous].Name.Substring(15));
            previousNumberName++;

            label.Name = "rulesLetterText" + previousNumberName;
            pourc.Name = "rulesIntText" + previousNumberName;

            panel1.Controls.Add(label);
            panel1.Controls.Add(pourc);

            controlsList.Add(pourc);
            controlsList.Add(label);

            return previousNumberName;
        }

    }
}
