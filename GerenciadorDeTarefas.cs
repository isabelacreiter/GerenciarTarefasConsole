using GerenciarTarefasConsole;
using System;
using System.Collections.Generic;
using System.Linq;

public class GerenciadorDeTarefas
{
    private List<Tarefa> tarefas = new List<Tarefa>();
    private int proximoId = 1;

    public void Adicionar(string titulo, string descricao)
    {
        tarefas.Add(new Tarefa
        {
            Id = proximoId++,
            Titulo = titulo,
            Descricao = descricao
        });
    }

    public List<Tarefa> Listar() => tarefas;

    public void Editar(int id, string titulo, string descricao)
    {
        var tarefa = tarefas.FirstOrDefault(t => t.Id == id);
        if (tarefa != null)
        {
            tarefa.Titulo = titulo;
            tarefa.Descricao = descricao;
        }
    }

    public void Remover(int id)
    {
        tarefas.RemoveAll(t => t.Id == id);
    }

    public void AlternarConclusao(int id)
    {
        var tarefa = tarefas.FirstOrDefault(t => t.Id == id);
        if (tarefa != null)
            tarefa.Concluida = !tarefa.Concluida;
    }

    public List<Tarefa> Filtrar(bool? concluidas)
    {
        if (concluidas == null)
            return tarefas;

        return tarefas.Where(t => t.Concluida == concluidas).ToList();
    }
}