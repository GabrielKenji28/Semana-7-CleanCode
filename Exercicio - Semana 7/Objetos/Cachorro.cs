using Exercicio.Objetos;
using Exercicio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio.Models
{
    public class Cachorro : Animal
    {
        


        //public Cachorro(int identificacao,string nome , int idade,string raca, string nomeDoDono, string email , int cpf , string endereco)
        //{
        //    Identificacao = identificacao;
        //    Nome = nome;
        //    Idade = idade;
        //    Raca = raca;
        //    NomeDoDono = nomeDoDono;
        //    Email = email;
        //    CPF = cpf;
        //    Endereco = endereco;
        //}

        ///// Método para adicionar um cachorro
        /// </summary>
        /// <param name="cachorro">Cachorro</param>
        /// <returns>Caso o cachorro seja inserido, retorna true</returns>
        

        public Cachorro AtribuiCachorro(Cachorro cachorro )
        {
            var cont = CachorroRepository.ListaCachorros.Count();
            cachorro.Identificacao = cont + 1;
            Console.WriteLine("Digite o nome do cachorro:");
            cachorro.Nome =  Console.ReadLine();
            Console.WriteLine("Digite a idade do cachorro:");
            cachorro.Idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a raça do cachorro:");
            cachorro.Raca = Console.ReadLine();
            Console.WriteLine("Digite o nome do dono do cachorro:");
            cachorro.NomeDoDono = Console.ReadLine();
            Console.WriteLine("Digite o email do dono do cachorro:");
            cachorro.Email = Console.ReadLine();
            Console.WriteLine("Digite o CPF do dono do cachorro:");
            cachorro.CPF = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o endereço do dono do cachorro:");
            cachorro.Endereco = Console.ReadLine();
            
            return cachorro;
        }

        public bool ValidaCachorro(Cachorro cachorro)
        {

            if (cachorro.Nome == string.Empty || cachorro.Idade == 0 || cachorro.Raca == string.Empty)
            {
                Console.WriteLine("Informe os dados do cachorro");
                return false;
            }
            




            else if (cachorro.NomeDoDono == string.Empty || cachorro.Email == string.Empty || cachorro.CPF == 0 || cachorro.Endereco == string.Empty)
            {
                Console.WriteLine("Informe os dados do dono");
                return false;
            }
                

            else
            {
                Console.WriteLine("Cachorro cadastrado com sucesso");
                return true;
            }
        }
    }
}
