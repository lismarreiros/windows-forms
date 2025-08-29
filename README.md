# Cadastro e Filtro de Pessoas (Windows Forms)

Este é um projeto em C# com Windows Forms, a aplicação permite cadastrar pessoas informando **idade** e **sexo**, com validação dos campos e filtro dinâmico por sexo.

##  Funcionalidades

- Cadastro de pessoas com idade e sexo ("M" ou "F")
- Validação de campos obrigatórios e dados corretos
- Exibição dos registros em uma tabela (`ListView`)
- Filtro dinâmico por sexo usando checkboxes (M e F)
- Reset automático dos campos após inserção

## Tecnologias utilizadas

- C#  
- .NET 8 
- Windows Forms  

## Observações

- O campo **sexo** aceita apenas "M" ou "F".
- A filtragem é opcional e pode ser ativada/desativada a qualquer momento.

## Estrutura do Projeto

```
├── Form1.cs # Código principal da interface e lógica do formulário
├── Form1.Designer.cs # Definição dos componentes do formulário
├── Pessoa.cs # Classe que representa uma pessoa
├── Program.cs # Ponto de entrada do app
├── DesafioFocare1.csproj # Arquivo de projeto
└── Form1.resx # Recursos visuais do formulário
```

