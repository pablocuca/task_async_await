using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic
{
    public class Feijao : Alimento
    {
        public Feijao(short qtdeGramas)
        {
            base.QtdeGramas = qtdeGramas;
            base.Tempo = TempoPreparo.Feijao;
        }
    }
}
