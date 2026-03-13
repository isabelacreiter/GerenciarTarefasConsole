# 📝 Gerenciador de Tarefas em Console (C#)

Aplicação desenvolvida em C# como teste técnico para gerenciamento de tarefas via terminal (Console).

O sistema permite criar, visualizar, editar, remover e controlar o status de tarefas de forma simples e eficiente, utilizando Programação Orientada a Objetos e manipulação de coleções com LINQ.

---

## 🚀 Funcionalidades

✔ Adicionar nova tarefa  
✔ Listar tarefas cadastradas  
✔ Editar título e descrição  
✔ Remover tarefa  
✔ Marcar / desmarcar como concluída  
✔ Filtrar tarefas por status (pendentes, concluídas ou todas)  

---

## 🧠 Conceitos aplicados

- Programação Orientada a Objetos (POO)
- Encapsulamento e separação de responsabilidades
- List<T> para armazenamento em memória
- LINQ para consultas e filtros
- Estrutura em camadas simples (Model + Gerenciador + Interface Console)

---

## 🏗️ Estrutura do Projeto

GerenciarTarefasConsole
│
├── Program.cs → Interface e menu do sistema
├── Tarefa.cs → Modelo de dados da tarefa
└── GerenciadorDeTarefas.cs → Regras de negócio e manipulação da lista

---

## 📋 Exemplo de uso

===== GERENCIADOR DE TAREFAS =====
1 - Adicionar
2 - Listar
3 - Editar
4 - Remover
5 - Marcar/Desmarcar Concluída
6 - Filtrar
0 - Sair

---

## 📅 Informações das tarefas

Cada tarefa contém:

- ID único
- Título
- Descrição
- Data de criação
- Status (Pendente ou Concluída)

---

## 📌 Observações

- Os dados são mantidos apenas em memória durante a execução.
- Ao fechar o programa, as tarefas não são persistidas.
- O projeto foi estruturado para fácil expansão futura (persistência em arquivo, banco de dados, interface gráfica, etc.).
