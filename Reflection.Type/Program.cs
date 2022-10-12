using Reflection.Type.House;
using System.Reflection;

namespace Reflection.Type;

internal class Program
{
    static void Main(string[] args)
    {
        int variable = 0;
        Console.WriteLine(variable.GetType());
        // Retorno = System.Int32

        Pessoa pessoa = new Pessoa()
        {
            Identifier = Guid.NewGuid(),
            Name = "Reflection"
        };
        Console.WriteLine(pessoa.GetType());
        // Retorno = Reflection.Type.Program+Pessoa

        Casa casa = new Casa()
        {
            Identifier = Guid.NewGuid(),
            Telha = "Telha",
            Estrutura = "Tijolo"
        };
        Console.WriteLine(casa.GetType().AssemblyQualifiedName);
        // Retorno = Reflection.Type.House.Casa, Reflection.Type, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null | GetType() é responsável por obter a instância do objeto

        var pessoa2 = new Pessoa()
        {
            Identifier = Guid.NewGuid(),
            Name = "Otávio"
        };
        Console.WriteLine(pessoa2.GetType().AssemblyQualifiedName);
    }

    public class Pessoa
    {   
        public Guid Identifier { get; set; }
        public string Name { get; set; }
    }
}