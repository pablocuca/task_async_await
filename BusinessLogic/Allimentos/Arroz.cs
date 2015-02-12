using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic
{
    public class Arroz : Alimento
    {
        public Arroz(short qtdeGramas)
        {
            base.QtdeGramas = qtdeGramas;
            base.Tempo = TempoPreparo.Arroz;
        }
    }
}
