using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public abstract class Alimento
    {
        private short _qtdeGramas { get; set; }
        private TempoPreparo _tempo { get; set; }

        protected short QtdeGramas
        {
            get { return _qtdeGramas; } 
            set { _qtdeGramas = value; }
        }

        internal TempoPreparo Tempo 
        {
            get { return _tempo; }
            set { _tempo = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        internal int Prepara()
        {
            int tempo = (Int32)(_qtdeGramas * (short)_tempo);
            //Thread.Sleep((Int32)(_qtdeGramas * (short)_tempo));
            for (decimal i = 0; i < tempo; i++)
            {
                Console.WriteLine(String.Format("Execucao {0} %",Math.Round(i/tempo*100,2)));
            }
            return tempo;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        internal async Task<int> PreparaAsync()
        {            
            return await Task.Run(() => Prepara());
        }
    }        
}
