using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            IniciandoCozinha();
        }

        static async void IniciandoCozinha()
        {
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            StringBuilder sb = null;
            string elapsedTime = String.Empty;
            TimeSpan ts = TimeSpan.Zero;
            Stopwatch stopWatch = new Stopwatch();
            int qtdeAlimentoProntos = short.MinValue;

            IList<Alimento> alimentos = new List<Alimento>();
            // passando como parametro na construcao do alimento o 
            // valor em gramas da quantidade do alimento
            alimentos.Add(new Arroz(200));
            alimentos.Add(new Feijao(150));
            alimentos.Add(new Batata(50));

            #region Inciando preparo do prato com cozinha Async
            CozinhaAsync cozinhaAsync = new CozinhaAsync(alimentos);

            // Iniciando Classe Stopwatch para medir o tempo que o prato demora para ficar pronto
            stopWatch.Start();

            qtdeAlimentoProntos = await cozinhaAsync.Ligar();

            stopWatch.Stop();
            ts = stopWatch.Elapsed;
            elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);

            sb = new StringBuilder();
            sb.AppendLine(String.Format("Prato Pronto em {0} com {1} alimento(s) feito pela cozinha Async", elapsedTime, qtdeAlimentoProntos));

            using (StreamWriter outfile = new StreamWriter(mydocpath + @"\CozinhaAsync.txt"))
            {
                outfile.Write(sb.ToString());
            }

            #endregion

            #region Inciando preparo do prato com cozinha Sync
            CozinhaSync cozinhaSync = new CozinhaSync(alimentos);

            // Iniciando Classe Stopwatch para medir o tempo que o prato demora para ficar pronto
            stopWatch.Start();

            qtdeAlimentoProntos = cozinhaSync.Ligar();

            stopWatch.Stop();
            ts = stopWatch.Elapsed;
            elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);

            sb = new StringBuilder();
            sb.AppendLine(String.Format("Prato Pronto em {0} com {1} alimento(s) feito pela cozinha Sync", elapsedTime, qtdeAlimentoProntos));

            using (StreamWriter outfile = new StreamWriter(mydocpath + @"\CozinhaSync.txt"))
            {
                outfile.Write(sb.ToString());
            }

            #endregion
        }
    }
}
