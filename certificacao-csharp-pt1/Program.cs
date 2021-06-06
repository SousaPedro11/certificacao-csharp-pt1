using System;
using System.Collections.Generic;
using certificacao_csharp_pt1.Aula1;
using certificacao_csharp_pt1.Aula1.Enums;
using Decimal = certificacao_csharp_pt1.Aula1.Decimal;

namespace certificacao_csharp_pt1
{
    internal class Program
    {
        private static IList<MenuItem> _menuItems;

        private static void Main(string[] args)
        {
            _menuItems = GetMenuItems();

            while (true)
            {
                ImprimeMenuItems(_menuItems);
                var opcao = Console.ReadLine();

                int.TryParse(opcao, out var valorOpcao);

                if (valorOpcao == 0) break;

                if (valorOpcao > _menuItems.Count) break;

                Executar(valorOpcao);
                Console.ReadKey();
            }
        }

        private static void Executar(int valorOpcao)
        {
            IAulaItem itemSelecionado;
            var menuItem = _menuItems[valorOpcao - 1];
            var tipoClasse = menuItem.TipoClasse;
            itemSelecionado = (IAulaItem) Activator.CreateInstance(tipoClasse);

            Console.WriteLine();
            var titulo = $"EXECUTANDO: {menuItem.Titulo}";
            Console.WriteLine(titulo);
            Console.WriteLine(new string('=', titulo.Length));

            itemSelecionado?.Executar();
            Console.WriteLine();
            Console.WriteLine("Tecle algo para continuar...");
        }

        private static void ImprimeMenuItems(IList<MenuItem> menuItems)
        {
            var i = 1;
            Console.WriteLine("SELECIONE UMA OPÇÂO");
            Console.WriteLine("===================");
            Console.WriteLine("0 - Sair");

            foreach (var menuItem in menuItems) Console.WriteLine(i++ + " - " + menuItem.Titulo);
        }

        private static IList<MenuItem> GetMenuItems()
        {
            return new List<MenuItem>
            {
                new("Tipos de Valor", typeof(TipodDeValor)),
                new MenuItem("Tipos Inteiros", typeof(TiposInteiros)),
                new MenuItem("Ponto Flututante", typeof(PontoFlutuante)),
                new MenuItem("Decimal", typeof(Decimal)),
                new MenuItem("Booleanos", typeof(Booleanos)),
                new MenuItem("Estruturas", typeof(Estruturas)),
                new MenuItem("Enumeracoes", typeof(Enumeracoes))
            };
        }
    }

    internal class MenuItem
    {
        public MenuItem(string titulo, Type tipoClasse)
        {
            Titulo = titulo;
            TipoClasse = tipoClasse;
        }

        public string Titulo { get; set; }
        public Type TipoClasse { get; set; }
    }
}