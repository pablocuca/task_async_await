using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic
{
    public class Batata : Alimento
    {
        public Batata(short qtdeGramas)
        {
            base.QtdeGramas = qtdeGramas;
            base.Tempo = TempoPreparo.Batata;
        }
    }
}
