using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class CozinhaAsync
    {
        private IList<Alimento> _alimento = new List<Alimento>();
        public CozinhaAsync(IList<Alimento> alimento)
        {
            _alimento = alimento;
        }

        public async Task<int> Ligar()
        {
            return await Preparando();
        }

        private int Preparando()
        {
            int alimentoPronto = 0;
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            StringBuilder sb = sb = new StringBuilder();
            foreach (Alimento alimento in _alimento)
            {
                sb.AppendLine(String.Format("Preparando alimento {0} as {1}", alimento.Tempo.ToString(), DateTime.Now.ToLongDateString()));
                using (StreamWriter outfile = new StreamWriter(mydocpath + @"\CozinhaAsync.txt"))
                {
                    outfile.Write(sb.ToString());
                }

                alimento.Prepara();
                alimentoPronto++;
            }
            return alimentoPronto;
        }
    }
}
