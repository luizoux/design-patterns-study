# Estudo de padrões de projeto
Meu projeto de estudos de Padrões de Projeto.

Este projeto tem como base o curso:
[Aprenda Padrões de Projetos GoF e Princípios de Programação SOLID em explicações práticas com exemplos reais em C#](https://www.udemy.com/course/curso-design-patterns-csharp/?couponCode=2021PM25)



## O que são "Design Patterns"?
São arquiteturas e padrões já pensadas para certos tipos de problemas. Cada padrão de código para um problema específico.

> *“Se você se guiar por trás dos principios dos padrões de projetos, você saberá se e quando aplicá-los”*
> 

## SOLID

SOLID não é um design pattern, é um princípio de programação (5 princípios). Criado pelo Uncle Bob, é um acrônimo para 5 princípios.

### [S] Single Responsability Principle

> *“Nunca deve haver mais de um otivo para uma classe mudar”*
> 

Com a ideia do Princípio de Responsabilidade Única, as classes podem ter vários métodos, mas devem ter a mesma responsabilidade, tem que ter um objetivo principal. Usar a orientação em objetos e separar as ações.

### [O] Open/Closed Principle

> *Alterar códigos existentes é perigoso.*
> 

Uma entidade, podendo ser uma classe, um módulo ou uma função, deve ser fechado para modificação e eaberta para extenção. 

*Fechado* - pode extender a entidade para trabalhar com herança, subclasses, etc, mas não pode alterar o que você já impletou e que outras classes do sistema utiliza desse recurso.

**Aplicar o principio** **→** por meio de heranças ou por meio de interfaces. Ou, até mesmo, aplicando padrões de projeto como o *Factory* ou o *Strategy*.

### [L] Liskov Substitution Principle

O princípio fala, resumidamente e com um exemplo, que uma classe derivada pode ser substituível por sua classe base sem quebrar o código. Trabalhar dirigido a interface, de maneira que caso seja preciso de uma substituição, o código não irá quebrar.

### [I] Interface Segregation Principle

Identificar nas interfaces qual delas estão claras. Com esse princípio, os clientes não devem ser forçados a depender de métodos que eles não utilizam. Podem também se aplicar a classes abstradas.

Esse princípio pode ajudar a aplicar outros principios, como por exemplo uma interface mais enxuta pode ser substituida por outra, como o principio de Liskov.

### [D] Dependency Inverson Principle

Princípio da Inversão de Dependência. Um módulo de alto nível não pode depender de uma modulo de baixo nível. 

Os módulos de alto nivel são onde estão as regras de negócio. 

![Untitled](design-patterns-study/doc/image1.png)

![Untitled](design-patterns-study/doc/image2.png)

Os módulos de baixo nível são as tarefas realizadas pela aplicação, a parte interna. São os que determinam como será feita essas regras.

## Design Patterns: A origem

Características de um padrão:

- Encapsulamento
- Generalidade
- Equilíbrio
- Abstração
- Abertura
- Combinatório

Segundo Christofer, um padrão descreve um problema que ocorre inumeras vezes em determinado contexto e nesse padrão descreve a solução desse problema.

# 🦾 Contribuição ou 🐞 Issues
Fiz esse repositório apenas com o intuito de compartilhar os meus estudos do dia a dia na programação. Se você tem alguma sugestão ou melhoria, sinta-se livre para abrir uma Issue ou entrar em contato comigo! Vou ficar muito feliz em receber seu pull request. 🥰

# 📃 Licença
Escrito com 💙 por Luiza Marinho.

Este tutorial está sob licença MIT License.
