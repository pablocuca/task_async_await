using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication
{
    public partial class Form1 : Form
    {
        string mydocpath = null;
        StringBuilder sb = null;
        string elapsedTime = String.Empty;
        TimeSpan ts = TimeSpan.Zero;
        Stopwatch stopWatch = null;
        int qtdeAlimentoProntos = short.MinValue;
        IList<Alimento> alimentos = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            lblTempo.Text = String.Empty;
            bloqueiaBotoes(true);
            #region Inciando preparo do prato com cozinha Sync
            CozinhaSync cozinhaSync = new CozinhaSync(alimentos);
            stopWatch = new Stopwatch();
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
            lblTempo.Text = sb.ToString();

            using (StreamWriter outfile = File.AppendText(mydocpath + @"\CozinhaSync.txt"))
            {
                outfile.WriteLine(sb.ToString());
            }
            bloqueiaBotoes(false);
            #endregion
        }

        private async void btnAsync_Click(object sender, EventArgs e)
        {
            lblTempo.Text = String.Empty;
            bloqueiaBotoes(true);
            #region Inciando preparo do prato com cozinha Async
            CozinhaAsync cozinhaAsync = new CozinhaAsync(alimentos);
            stopWatch = new Stopwatch();
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
            lblTempo.Text = sb.ToString();

            using (StreamWriter outfile = File.AppendText(mydocpath + @"\CozinhaAsync.txt"))
            {
                await outfile.WriteLineAsync(sb.ToString());
            }
            bloqueiaBotoes(false);
            #endregion
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            alimentos = new List<Alimento>();
            // passando como parametro na construcao do alimento o 
            // valor em gramas da quantidade do alimento
            alimentos.Add(new Arroz(20));
            alimentos.Add(new Feijao(15));
            alimentos.Add(new Batata(5));
        }

        private void bloqueiaBotoes(bool valor)
        {
            btnAsync.Enabled = !valor;
            btnSync.Enabled = !valor;
        }
    }
}
