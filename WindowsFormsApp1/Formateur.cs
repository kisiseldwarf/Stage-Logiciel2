namespace WindowsFormsApp1
{
    internal class Formateur
    {
        string fonction;
        string entreprise;
        string ville;
        string codePostal;
        string email;
        string téléphone;
        bool aCompetencesInformatique;
        string domaineCompetence;
        string prenom;
        string nom;

        public string Fonction { get => fonction; set => fonction = value; }
        public string Entreprise { get => entreprise; set => entreprise = value; }
        public string Ville { get => ville; set => ville = value; }
        public string CodePostal { get => codePostal; set => codePostal = value; }
        public string Email { get => email; set => email = value; }
        public string Téléphone { get => téléphone; set => téléphone = value; }
        public bool ACompetencesInformatique { get => aCompetencesInformatique; set => aCompetencesInformatique = value; }
        public string DomaineCompetence { get => domaineCompetence; set => domaineCompetence = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Nom { get => nom; set => nom = value; }
    }
}