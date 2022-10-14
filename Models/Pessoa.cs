using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemploExplorando.Models
{
    public class Pessoa
    {
        public Pessoa(string nome, int idade)
        {
            this.Nome = nome;
            Idade = idade;
        }

        //Validação de propriedade
        //criar um  para armazenar o valor
        private string _nome;
        //Assim, o valor vai ser armazenado aqui agora
        
        public string Nome 
        { 
            get
            {
                return _nome.ToUpper();
                //Isso que fiz é encapsulamento
            }

            set
            {
                if(value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                /*isso aqui em cima é uma exceção, ela vai parar
                 *o meu código e esperar alguem tratar ela, caso não 
                 *seja tratado irá encerrar o programa.
                 *Assim, caso tratado ele vai voltar e não vai continuar na linha de baixo
                */
                _nome = value;
            } 
        }


        //Agora propriedade de somente leitura
        public string Sobrenome { get; set; }
        //essa propriedade aqui em baixo é somente de leitura ela serve para juntar  o nome e sobrenome
        //Deixar muito mais fácil minha vida
        public string NomeCompleto 
        { 
            get => $"{Nome} {Sobrenome.ToUpper()}"; 
        }



        //Agora minha fez de tentar fazer uma validação
        //Primeiro o campo
        private int _idade; // é bom declarar esse campo lá em cima junto com o outro, mas como está apredendo fazer aqui
        //agora tratar o get e set
        public int Idade 
        { 

            //O sinal "=>" quer dizer que vai retornar, é como um return.
            //Porém, apenas utilizar quando meu código tiver uma única linha
            get => _idade;

            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("O valor não pode ser menor que zero");
                }
                //agora colocar para armazenar o valor no campo
                _idade = value;
                //agora tratar o get
            }
        }        
        public void Apresentar()
        {
            Console.WriteLine($"{NomeCompleto}");
            Console.WriteLine($"Idade: {Idade}");
        }
    }

}