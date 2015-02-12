using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic
{
    public class Peixe : Alimento
    {
        public Peixe(short qtdeGramas)
        {
            base.QtdeGramas = qtdeGramas;
            base.Tempo = TempoPreparo.Peixe;
        }
    }
}
