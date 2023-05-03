using IDEA.Logistyka.Walidatory;
using System.Collections.Generic;
using System.Text;

namespace IDEA.Logistyka.Validators
{
    public class DodajDoTypuZasobuValidator
    {
        public static string Validate(IEnumerable<string> currentTypZasobu, string newTypZasobu)
        {
            var stringBuilder = new StringBuilder();

            int i = 0;

            if (currentTypZasobu.ContainsItem(newTypZasobu))
                stringBuilder.AppendLine($"{++i}. Wprowadzony typ zasobu zawiera się już w bazie.");

            return stringBuilder.ToString();
        }
    }
}
