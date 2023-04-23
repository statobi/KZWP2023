using IDEA.Logistyka.Modele;
using IDEA.Logistyka.Walidatory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDEA.Logistyka.Magazyny.Walidatory
{
    public class MagazynWalidator
    {
        public string NowyMagazynWalidator(NowyMagazyn magazyn)
        {
            var stringBuilder = new StringBuilder();

            if (magazyn.NrTelefonu.ToString().StringToIntParser())
                stringBuilder.Append("Podana wartość numeru telefonu ma nieprawidłowy format");

            if (magazyn.NrTelefonu.ToString().WalidatorDlugosciZnakow(9))
                stringBuilder.Append("Długość numeru telefonu nie może przekraczać 9 cyfr");

            if(magazyn.PowierzchniaRobocza.ToString().StringToIntParser())
                stringBuilder.Append("Podana wartość powierzchni roboczej magazynu ma nieprawidłowy format");

            return stringBuilder.ToString();
        }
    }
}
