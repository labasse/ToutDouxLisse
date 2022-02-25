using System.ComponentModel.DataAnnotations;

namespace ToutDouxMetier
{
    public enum Statut
    {
        Particulier, 
        Independant, 
        Entreprise
    }

    public class Utilisateur
    {
        public Guid Id { get; } = Guid.NewGuid();

        [StringLength(50, MinimumLength = 1, ErrorMessage = "Le {0} doit avoir une longueur minimale de {2} caractère et ne pas excéder {1} caractères" )]
        public string Nom { get; set; }

        [StringLength(50, MinimumLength = 1)]
        public string Prenom { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime? DateDeNaissance { get; set; }
        
        [Required]
        [RegularExpression("[-_A-Za-z0-9]{5,50}",ErrorMessage ="Le login doit contenir des chiffres, des lettres et - ou _")]
        public string Login { get; set; }
        
        [Required]
        [RegularExpression("[-#!_A-Za-z0-9]{5,50}", ErrorMessage = "Le mot de passe de 5 à 50 caractères peut contenir des chiffres, des lettres, -, _, # ou !")]
        public string MotDePasse { get; set; }

        [Required, Compare(nameof(MotDePasse))]
        public string ConfirmationMotDePasse { get; set; }

        [Required, EmailAddress(ErrorMessage = "L'adresse est incorrecte")]
        public string Email { get; set; }
        
        [Required]
        public bool ConsentementProspect { get; set; } = false;
        
        [Required]
        public Statut Statut { get; set; }
    }
}
