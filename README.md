
# Gerenciador de Tarefas

Esse é um CRUD para um gerenciador de tarefas online onde é possível adicionar atividades, retornar todas as atividades, retornar uma atividade específica, editar e deletar uma atividade específica.


## Documentação da API

#### Cadastra uma nova tarefa

```http
  POST /api/tasks
```
Entrada:
| Parâmetro   | Tipo       | Descrição                           |
| :---------- | :--------- | :---------------------------------- |
| `name` | `string` | **Obrigatório**. O título da tarefa |
| `description` | `string` | **Obrigatório**. A descrição da tarefa |
| `priority` | `int` | **Obrigatório**. A prioridade da tarefa (Baixa = 0, Média = 1, Alta = 2) |
| `dueDate` | `DateTime` | **Obrigatório**. A data limite para realização da tarefa |
| `status` | `int` | **Obrigatório**. O status da tarefa (Não iniciada = 0, Em progresso = 1, Completa = 2, Pausada = 3, Cancelada = 4,) |

#### Atualiza uma tarefa

```http
  PUT /api/tasks/${id}
```
Entrada:
| Parâmetro   | Tipo       | Descrição                           |
| :---------- | :--------- | :---------------------------------- |
| `name` | `string` | **Obrigatório**. O título da tarefa |
| `description` | `string` | **Obrigatório**. A descrição da tarefa |
| `priority` | `int` | **Obrigatório**. A prioridade da tarefa (Baixa = 0, Média = 1, Alta = 2) |
| `dueDate` | `DateTime` | **Obrigatório**. A data limite para realização da tarefa |
| `status` | `int` | **Obrigatório**. O status da tarefa (Não iniciada = 0, Em progresso = 1, Completa = 2, Pausada = 3, Cancelada = 4,) |

#### Retorna todas as tarefas

```http
  GET /api/tasks
```
Saída:
| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `id`      | `int` | O ID da tarefa |
| `title`      | `string` | O título da tarefa |
| `status`      | `int` | O status da tarefa (Não iniciada = 0, Em progresso = 1, Completa = 2, Pausada = 3, Cancelada = 4,) |

#### Retorna uma tarefa

```http
  GET /api/tasks/${id}
```
Saída:
| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `id`      | `int` | O ID da tarefa |
| `name` | `string` | O título da tarefa |
| `description` | `string` | A descrição da tarefa |
| `priority` | `int` | A prioridade da tarefa (Baixa = 0, Média = 1, Alta = 2) |
| `dueDate` | `DateTime` | A data limite para realização da tarefa |
| `status` | `int` | O status da tarefa (Não iniciada = 0, Em progresso = 1, Completa = 2, Pausada = 3, Cancelada = 4,) |

#### Deleta uma tarefa

```http
  DELETE /api/tasks/${id}
```


## Stack utilizada

**Back-end:** C# e .NET 8.0

