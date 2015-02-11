using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic
{
    public interface IAlimento
    {
        /// <summary>
        /// Quantidade do alimento em gramas
        /// </summary>
        float QtdeGramas
        {
            get;
            set;
        }
        /// <summary>
        /// Prepara o alimento de acordo com a quantidade informada em gramas
        /// </summary>
        void Preparar();
    }
}
