using IDEA.Logistyka.Walidatory;
using System.Text;

namespace IDEA.Logistyka.Magazyny.Walidatory
{
    public class MagazynValidator
    {
        public string NowyMagazynWalidator(string nrTelefonu, string powierzchniaRobocza)
        {
            var stringBuilder = new StringBuilder();
            int i = 0;

            if (nrTelefonu.StringToIntParser())
                stringBuilder.AppendLine($"{++i}. Podany numer telefonu ma nieprawidłowy format");

            if (nrTelefonu.StringLengthValidatorEqual(9))
                stringBuilder.AppendLine($"{++i}. Długość numeru telefonu musi składać się z 9 cyfr");

            if(powierzchniaRobocza.StringToIntParser())
                stringBuilder.AppendLine($"{++i}. Podana powierzchna robocza ma nieprawidłowy format");

            return stringBuilder.ToString();
        }
    }
}
