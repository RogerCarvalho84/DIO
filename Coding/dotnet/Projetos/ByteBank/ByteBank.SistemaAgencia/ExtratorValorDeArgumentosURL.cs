﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class ExtratorValorDeArgumentosURL
    {
        private readonly string _argumentos;
        public string URL { get; }
        public ExtratorValorDeArgumentosURL(string url)
        {

            
            if(string.IsNullOrEmpty(url))
            {
                throw new ArgumentNullException("O argumento não pode ser nulo ou vazio.",nameof(url));
            }

            int indiceInterrogação = url.IndexOf('?');
            _argumentos = url.Substring(indiceInterrogação + 1);

        }

        public string GetValor(string nomeDoParametro)
        {
            nomeDoParametro = nomeDoParametro.ToUpper();
            string argumentoEmCaixaAlta = _argumentos.ToUpper();

            string termo = nomeDoParametro + "=";
            int indiceTermo = argumentoEmCaixaAlta.IndexOf(termo);

            string resultado = _argumentos.Substring(indiceTermo + termo.Length);
            int indiceEComercial = resultado.IndexOf('&');

            if (indiceEComercial == -1)
            {
                return resultado;
            }
                

            return resultado.Remove(indiceEComercial);

        }

    }
}
