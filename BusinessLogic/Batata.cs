﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic
{
    public class Batata : IAlimento
    {
        public Batata()
        {
            throw new System.NotImplementedException();
        }
    
        public float QtdeGramas
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        private float _qtdeGramas
        {
            set { throw new NotImplementedException(); }
        }

        public void Preparar()
        {
            throw new NotImplementedException();
        }
    }
}