using IDEA.Logistyka.Walidatory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDEA.Logistyka.Validators
{
    public class DodajPoIlosciValidator
    {
        public static string Validate(string enteredIlosc, int maxIlosc)
        {
            var stringBuilder = new StringBuilder();

            int i = 0;

            if (enteredIlosc.StringToIntParser())
            {
                stringBuilder.AppendLine($"{++i}. Wprowadzona wartość ma nieprawidłowy format.");
                return stringBuilder.ToString();
            }

            var parsed = int.Parse(enteredIlosc);

            if (parsed.IsGreatherThan(maxIlosc))
                stringBuilder.AppendLine($"{++i}. Wprowadzona wartość nie może być większa od {maxIlosc}");

            if (parsed.IsLesserThan(0))
                stringBuilder.AppendLine($"{++i}. Wprowadzona wartość musi być dodatnia");

            return stringBuilder.ToString();
        }
    }
}
