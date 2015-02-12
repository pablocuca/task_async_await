using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic
{
    public class Carne : Alimento
    {
        public Carne(short qtdeGramas)
        {
            base.QtdeGramas = qtdeGramas;
            base.Tempo = TempoPreparo.Carne;
        }
    }
}
