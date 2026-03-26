# Desafio Pratico - Conceitos Basicos em C#

Este projeto contem a resolucao dos exercicios praticos do modulo, implementados em um aplicativo de console com menu interativo.

## Estrutura

- Solucao: `Praticando Conceitos C#.sln`
- Projeto: `C#/C#.csproj`
- Codigo principal: `C#/Program.cs`

## Requisitos

- .NET 8 SDK instalado

## Como executar

1. Abra um terminal na pasta do projeto `C#/`.
2. Execute:

```bash
dotnet run
```

3. Escolha uma opcao no menu para testar cada exercicio.

## Exercicios implementados

1. Boas-vindas personalizada com nome digitado pelo usuario.
2. Concatenacao de nome e sobrenome para exibir nome completo.
3. Operacoes com dois valores `double`:
   - Soma
   - Subtracao
   - Multiplicacao
   - Divisao (com validacao para divisao por zero)
   - Media
4. Contagem de caracteres de palavra/frase:
   - Total com espacos
   - Total sem espacos
5. Validacao de placa brasileira antiga (padrao ate 2018):
   - 3 letras + 4 numeros (exemplo: `ABC1234`)
6. Exibicao da data atual em formatos diferentes:
   - Formato completo
   - Apenas data (`dd/MM/yyyy`)
   - Apenas hora (`HH:mm:ss`)
   - Data com mes por extenso

## Compilacao

Para validar compilacao:

```bash
dotnet build
```

## Observacao

O projeto foi ajustado para aplicativo de console (`OutputType: Exe`) para suportar interacao via `Console.ReadLine()`.
