using System;

namespace certificacao_csharp_pt1.Aula1.Tipos_valor
{
    public class TipodDeValor : IAulaItem
    {   
        public void Executar()
        {
            int idade;
            idade = 30;
            Console.WriteLine(idade);
        }
    }
}