using System;

namespace certificacao_csharp_pt1.Aula1
{
    public class TipodDeValor : IAulaItem
    {
        public void Executar()
        {
            // int idade = 30;
            // Console.WriteLine(idade);
            //
            // int copiaIdade = idade;
            // Console.WriteLine($"Idade: {idade}");
            // Console.WriteLine($"Cópia Idade: {copiaIdade}");
            //
            // int? idade2 = null;
            // Console.WriteLine($"Idade: {idade}");
            // Console.WriteLine($"Cópia Idade: {copiaIdade}");
            var idade = 30;

            var copiaIdade = idade;

            Console.WriteLine($"idade: {idade}");
            Console.WriteLine($"copiaIdade: {copiaIdade}");

            idade = 23;

            Console.WriteLine($"idade: {idade}");
            Console.WriteLine($"copiaIdade: {copiaIdade}");
        }
    }
}