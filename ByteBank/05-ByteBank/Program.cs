﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente gabriela = new Cliente();

            gabriela.nome = "Gabriela";
            gabriela.profissao = "Desenvolvedora C#";
            gabriela.cpf = "123.456.789-00";

            ContaCorrente conta = new ContaCorrente();

            conta.titular = gabriela;
            conta.saldo = 500;
            conta.agencia = 563;
            conta.numero = 12345;

            Console.WriteLine(gabriela.nome);
            Console.WriteLine(conta.titular.nome);

            conta.titular.nome = "Gabriela Costa";

            Console.WriteLine(gabriela.nome);
            Console.WriteLine(conta.titular.nome);

            Console.ReadLine();
        }
    }
}
