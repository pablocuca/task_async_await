﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace BusinessLogic
{
    public class CozinhaSync
    {
        private IList<Alimento> _alimento = new List<Alimento>();
        public CozinhaSync(IList<Alimento> alimento)
        {
            _alimento = alimento;
        }

        public int Ligar()
        {
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            StringBuilder sb = sb = new StringBuilder();
            foreach (Alimento alimento in _alimento)
            {
                sb.AppendLine(String.Format("Preparando alimento {0} as {1} {2}", alimento.Tempo.ToString(), DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString()));
                Console.WriteLine("Preparando alimento {0}", alimento.Tempo.ToString());
                alimento.Prepara();
            }
            using (StreamWriter outfile = new StreamWriter(mydocpath + @"\CozinhaSync.txt"))
            {
                outfile.WriteLine(sb.ToString());
            }

            return _alimento.Count();
        }
    }
}
