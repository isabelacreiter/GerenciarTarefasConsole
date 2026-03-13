using GerenciarTarefasConsole;

var ger = new GerenciadorDeTarefas();

while (true)
{
    Console.Clear();

    Console.WriteLine("===== GERENCIADOR DE TAREFAS =====");
    Console.WriteLine("1 - Adicionar");
    Console.WriteLine("2 - Listar");
    Console.WriteLine("3 - Editar");
    Console.WriteLine("4 - Remover");
    Console.WriteLine("5 - Marcar/Desmarcar Concluída");
    Console.WriteLine("6 - Filtrar");
    Console.WriteLine("0 - Sair");

    var op = Console.ReadLine();

    switch (op)
    {
        case "1":
            Console.Write("Título: ");
            var t = Console.ReadLine();

            Console.Write("Descrição: ");
            var d = Console.ReadLine();

            ger.Adicionar(t, d);
            break;

        case "2":
            foreach (var tarefa in ger.Listar())
                Mostrar(tarefa);
            break;

        case "3":
            Console.Write("ID da tarefa: ");
            int idEdit = int.Parse(Console.ReadLine());

            Console.Write("Novo título: ");
            t = Console.ReadLine();

            Console.Write("Nova descrição: ");
            d = Console.ReadLine();

            ger.Editar(idEdit, t, d);
            break;

        case "4":
            Console.Write("ID da tarefa: ");
            ger.Remover(int.Parse(Console.ReadLine()));
            break;

        case "5":
            Console.Write("ID da tarefa: ");
            ger.AlternarConclusao(int.Parse(Console.ReadLine()));
            break;

        case "6":
            Console.WriteLine("1 - Pendentes");
            Console.WriteLine("2 - Concluídas");
            Console.WriteLine("3 - Todas");

            var f = Console.ReadLine();

            bool? filtro = f switch
            {
                "1" => false,
                "2" => true,
                _ => null
            };

            foreach (var tarefa in ger.Filtrar(filtro))
                Mostrar(tarefa);
            break;

        case "0":
            return;
    }

    Console.WriteLine("\nPressione qualquer tecla...");
    Console.ReadKey();
}

static void Mostrar(Tarefa t)
{
    Console.WriteLine($"{t.Id} - [{(t.Concluida ? "Concluída" : "Pendente")}] {t.Titulo}");
    Console.WriteLine($"Descrição: {t.Descricao}");
    Console.WriteLine($"Criada em: {t.DataCriacao}\n");
}