﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }

        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        
        public Funcionario(double salario, string cpf)
        {
            Console.WriteLine("Construtor de funcionário");
            CPF = cpf;
            Salario = salario;
            TotalDeFuncionarios++;
        }


        public abstract double GetBonificacao();

        public abstract void AumentarSalario();
     


    }
}
