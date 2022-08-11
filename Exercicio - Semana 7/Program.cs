using Exercicio.Models;
using Exercicio.Objetos;
using System;
using System.Collections.Generic;
using System.Net.Mail;
using Exercicio.EnviaEmail;
using Exercicio.Cadastro_Animal;
using Exercicio.Repositorio;

namespace Exercicio
{
    /// <summary>
    /// Inicialização do programa
    /// </summary>

    public class Program
    {

        /// <summary>
        /// Método main, ponto de inicialização da aplicação
        /// </summary>
        /// <param name="args">Argumentos informados pela console</param>
        static void Main(string[] args)
        {
            var animalService = new AdicionaAnimal();
            var cachorroService = new CachorroRepository();
            var gatoService = new GatoRepository();
            //Adição do cachorro
            Cachorro cachorro = new Cachorro
            {
                Identificacao = 1,
                Nome = "Rex",
                Raca = "Tomba lata",
                Idade = 2,
                CPF = 99999999,
                Email = "edu@gmail.com",
                Endereco = "Rua do Cobre, 768",
                NomeDoDono = "Edu"
            };
            CachorroRepository.ListaCachorros.Add(cachorro);


            Console.WriteLine("Digite o número de cachorros que deseja cadastrar:");
            int nCachorro = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < nCachorro; i++)
            {
                cachorro.AtribuiCachorro(cachorro);
                var msg1 = animalService.AdicionarCachorro(cachorro);

                if (msg1)
                {
                    Console.WriteLine($"O cadastro do cachorro {cachorro.Nome} foi realizado com sucesso!");
                    //var msgFinalCachorro = EmailCachorro.EnviaEmailCachorro(cachorro);
                    //Console.WriteLine(msgFinalCachorro);
                    //cont++;
                }
            }

            // Adição do gato
            Gato gato = new Gato
            {
                Identificacao = 1,
                Nome = "Miau",
                Raca = "Siames",
                Idade = 5,
                CPF = 88888888,
                Email = "carlos@gmail.com",
                Endereco = "Rua da Prata, 55",
                NomeDoDono = "Carlos"
            };
            GatoRepository.ListaGatos.Add(gato);

            Console.WriteLine("Digite o número de gatos que deseja cadastrar:");
            int nGatos = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < nGatos; i++)
            {
                gato.AtribuiGato(gato);
                var msg2 = animalService.AdicionarGato(gato);
                if (msg2)
                {
                    Console.WriteLine($"O cadastro do gato {gato.Nome} foi realizado com sucesso!");
                }
            }
            

            
            foreach (var item in CachorroRepository.ListaCachorros)
            {
                Console.WriteLine($"nome do cachorro é: {item.Nome}\nnome do dono é: {item.NomeDoDono}\no Id do cachorro é :{cachorro.Identificacao}\n");
            }
            foreach (var item in GatoRepository.ListaGatos)
            {
                Console.WriteLine($"nome do gato é: {item.Nome}\nnome do dono é: {item.NomeDoDono}\no Id do gato é : {gato.Identificacao}\n");
            }
        }
    }
}
