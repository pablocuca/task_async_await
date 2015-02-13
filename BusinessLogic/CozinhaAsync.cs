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
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            StringBuilder sb = sb = new StringBuilder();
            foreach (Alimento alimento in _alimento)
            {
                sb.AppendLine(String.Format("Preparando alimento {0} as {1} {2}", alimento.Tempo.ToString(), DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString()));
                Console.WriteLine("Preparando alimento {0}", alimento.Tempo.ToString());
                await alimento.PreparaAsync();
            }
            using (StreamWriter outfile = new StreamWriter(mydocpath + @"\CozinhaAsync.txt"))
            {
                await outfile.WriteLineAsync(sb.ToString());
            }

            return _alimento.Count(); ;
        }
    }
}
