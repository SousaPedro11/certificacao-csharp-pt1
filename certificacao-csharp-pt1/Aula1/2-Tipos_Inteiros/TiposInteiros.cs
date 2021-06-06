using System;

namespace certificacao_csharp_pt1.Aula1
{
    public class TiposInteiros : IAulaItem
    {
        public void Executar()
        {
            char resposta = '5'; //System.Char

            byte nivelDeAzul = 0xFF; // = 255 em decimal

            // nivelDeAzul = -3;

            short passageiroVoo = 230; // System.Int16
            passageiroVoo = -7;
            
            int idade = 15; // System.Int32

            // idade = 15.5;

            long populacaoDoBrasil = 207_660_929; // +/- 207 milhoes - System.Int64

            sbyte nivelDeBrilho = -127; //System.Sbyte

            ushort passageirosNavio = 230; //System.UInt16

            uint estoque = 1500; //Inteiro positivo - System.UInt16

            ulong populacaoDoMundo = 7_000_000_000; //Inteiro longo positivo - System.UInt64
            
            Console.WriteLine($"resposta: {resposta}");
            Console.WriteLine($"nivelDeAzul: {nivelDeAzul}");
            Console.WriteLine($"passageiroVoo: {passageiroVoo}");
            Console.WriteLine($"idade: {idade}");
            Console.WriteLine($"populacaoDoBrasil: {populacaoDoBrasil}");
            Console.WriteLine($"nivelDeBrilho: {nivelDeBrilho}");
            Console.WriteLine($"passageirosNavio: {passageirosNavio}");
            Console.WriteLine($"estoque: {estoque}");
            Console.WriteLine($"populacaoDoMundo: {populacaoDoMundo}");
        }
    }
}