using IDEA.Logistyka.Walidatory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDEA.Logistyka.Validators
{
    public class SekcjaValidator
    {
        public static string NewSekcjaValidator(string insertedPowierzchniaRobocza, double avaliablePowierzchniaRobocza)
        {
            var stringBuilder = new StringBuilder();
            int i = 0;

            if (insertedPowierzchniaRobocza.StringToDoubleParser())
            {
                stringBuilder.AppendLine($"{++i}. Podana powierzchnia robocza ma nieprawidłowy format");
                return stringBuilder.ToString();
            }

            var doubleinsertedPowierzchniaRobocza = double.Parse(insertedPowierzchniaRobocza);

            if (doubleinsertedPowierzchniaRobocza.IsGreatherThan(avaliablePowierzchniaRobocza))
                stringBuilder.AppendLine($"{++i}. Powierzchnia sekcji jest wikększa od ilości dostępnego miejsca w magazynie");

            return stringBuilder.ToString();
        }
    }
}
