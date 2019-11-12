using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Gepie.Data
{
    public class DecoupageGeographique : Entite
    {
        public int Id { get; set; }
        [Required(ErrorMessage="Veuillez saisir le libellé!")]
        [DisplayName("Libellé")]
        public string Libelle { get; set; }
        public string Code { get; set; }
    }
}