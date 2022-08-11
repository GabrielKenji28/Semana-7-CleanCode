using Exercicio.Models;
using Exercicio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio.Objetos
{
    public class Gato : Animal
    {
        public Gato AtribuiGato(Gato gato)
        {
            var cont = GatoRepository.ListaGatos.Count();
            gato.Identificacao = cont;
            Console.WriteLine("Digite o nome do gato:");
            gato.Nome = Console.ReadLine();
            Console.WriteLine("Digite a idade do gato:");
            gato.Idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a raça do gato:");
            gato.Raca = Console.ReadLine();
            Console.WriteLine("Digite o nome do dono do gato:");
            gato.NomeDoDono = Console.ReadLine();
            Console.WriteLine("Digite o email do dono do gato:");
            gato.Email = Console.ReadLine();
            Console.WriteLine("Digite o CPF do dono do gato:");
            gato.CPF = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o endereço do dono do gato:");
            gato.Endereco = Console.ReadLine();
            return gato;
        }
        public string ValidaGato(Gato gato)
        {

              if (gato.Nome == string.Empty || gato.Idade == 0 || gato.Raca == string.Empty)
                  return "É obrigatório informar os dados do gato.";
        
              else if (gato.NomeDoDono == string.Empty || gato.Email == string.Empty || gato.CPF == 0 || gato.Endereco == string.Empty)
                  return "É obrigatório informar os dados do dono do animal.";

            else
            {
                return "Gato cadastrado com sucesso!";
            }
        }
    }

}
