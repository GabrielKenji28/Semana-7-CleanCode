using Exercicio.Models;
using Exercicio.Objetos;
using Exercicio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio.Cadastro_Animal
{
    public class AdicionaAnimal
    {
        CachorroRepository cachorroRepository = new CachorroRepository();
        GatoRepository gatoRepository = new GatoRepository();
        public bool AdicionarGato(Gato gato)
        {
            gato.ValidaGato(gato);
            // Adição do gato
            try
            {
                GatoRepository.ListaGatos.Add(gato);
                return true;
            }
            catch (Exception)
            {
                return false;
            }



        }
        
        public bool AdicionarCachorro(Cachorro cachorro)
        {
            try
            {
                var valido = cachorro.ValidaCachorro(cachorro);
               
                if (valido)
                {
                    CachorroRepository.ListaCachorros.Add(cachorro);
                    Console.WriteLine("Cachorro cadastrado com sucesso")
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
                
            }
            
            

        }

        



    }
}

