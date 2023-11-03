using System.ComponentModel.DataAnnotations;

namespace form.Models
{
    public class Form
    {
        [Required(ErrorMessage = "Prosze podaj Imie")]
        [MinLength(2, ErrorMessage = "Imie musi mieć przynajmniej 2 litery")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Prosze podaj Nazwisko")]
        [MinLength(2, ErrorMessage = "Nazwisko musi mieć przynajmniej 2 litery")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Prosze podaj Email")]
        [RegularExpression(".+\\@.+\\.[a-z]{2,3}", ErrorMessage = "Podaj poprawny email np. jan@interia.pl")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Prosze podaj haslo")]
        [RegularExpression("^(?=.*\\d)(?=.*[a-z])(?=.*[A-Z]).{8,}$", ErrorMessage = "Hasło musi zawierać przynajmniej jedna cyfra, jedna duża litera i jedna\r\nmała litera")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Powtórz hasło")]
        [Compare("Password", ErrorMessage = "Oba hasla muszą być takie same")]
        public string PasswordCheck { get; set; }

        [Phone(ErrorMessage = "Wprowadź poprawny numer telefonu")]
        public string Phone { get; set; }


        [Range(10, 80)]
        public int Age { get; set; }

        [Required(ErrorMessage = "Wybierz jedno z 5 dostępnych miast")]
        [EnumDataType(typeof(Cities), ErrorMessage = "Dostępne miasta to: Kraków, Warszawa, Gdańsk, Wrocław, Katowice")]
        public Cities City { get; set; }

        public enum Cities
        {
            Kraków,
            Warszawa,
            Gdańsk,
            Wrocław,
            Katowice
        }
    }
}
