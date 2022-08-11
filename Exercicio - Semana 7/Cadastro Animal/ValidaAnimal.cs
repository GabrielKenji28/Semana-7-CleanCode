using Exercicio.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio.Cadastro_Animal
{
    public class ValidaAnimal 
    {
        public bool ValidarAnimal(Animal animal)
        {
            if (animal.Nome == string.Empty || animal.Idade == 0 || animal.Raca == string.Empty)
                return false;

            else if (animal.NomeDoDono == string.Empty || animal.Email == string.Empty || animal.CPF == 0 || animal.Endereco == string.Empty)
                return false;

            else
            {
                return true;
            }
        }
    }
}
