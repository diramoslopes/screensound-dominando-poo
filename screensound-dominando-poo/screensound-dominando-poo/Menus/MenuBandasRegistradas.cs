using screensound.Modelos;
using screensound_dominando_poo.Menus;

internal class MenuBandasRegistradas : Menu
{
    internal void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        {
            Console.Clear();
            ExibirTituloDaOpcao("Exibindo todas as bandas registradas na nossa aplicação");

            foreach (string banda in bandasRegistradas.Keys)
            {
                Console.WriteLine($"Banda: {banda}");
            }

            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}