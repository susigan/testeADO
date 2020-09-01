using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Times
    {
        [Display(Name = "id")]
        public int timeId { get; set; }

        [Required(ErrorMessage = " informe o nome do time")]
        public string Time { get; set; }

        [Required(ErrorMessage = " informe o Estado do time")]
        public string Estado { get; set; }


        [Required(ErrorMessage = " informe a cor do time")]
        public string Cores { get; set; }
    }
}