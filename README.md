# Desafio Pratico - Conceitos Basicos em C#

Aplicacao de console com menu interativo para praticar conceitos basicos da linguagem C#.

## Objetivo

Consolidar fundamentos de entrada e saida de dados, manipulacao de strings, operacoes numericas, validacao com regex e formatacao de data/hora.

## Estrutura do projeto

- Solucao: `Praticando Conceitos C#.sln`
- Projeto principal: `C#/C#.csproj`
- Codigo-fonte: `C#/Program.cs`

## Requisitos

- .NET 8 SDK

## Execucao

### Opcao 1 (recomendada): executar pela raiz do repositorio

Na raiz do repositorio (onde esta o arquivo `.sln`), rode:

```bash
dotnet run --project "./C#/C#.csproj"
```

### Opcao 2: executar dentro da pasta do projeto

```bash
cd "./C#"
dotnet run
```

## Funcionalidades implementadas

1. Boas-vindas personalizada com nome informado pelo usuario.
2. Concatenacao de nome e sobrenome para exibicao do nome completo.
3. Operacoes com dois valores `double`:
   - Soma
   - Subtracao
   - Multiplicacao
   - Divisao (com tratamento para divisao por zero)
   - Media
4. Contagem de caracteres em palavra/frase:
   - Total com espacos
   - Total sem espacos
5. Validacao de placa brasileira no padrao antigo (ate 2018):
   - 3 letras e 4 numeros (exemplo: `ABC1234`)
6. Exibicao da data/hora atual em formatos diferentes:
   - Formato completo
   - Apenas data (`dd/MM/yyyy`)
   - Apenas hora (`HH:mm:ss`)
   - Data com mes por extenso

## Compilacao

Para validar a compilacao do projeto:

```bash
dotnet build "./C#/C#.csproj"
```

## Solucao de problemas

Se aparecer a mensagem abaixo:

`Nao foi possivel localizar um projeto para executar...`

isso indica que o comando foi executado fora da pasta esperada. Use uma destas alternativas:

```bash
dotnet run --project "./C#/C#.csproj"
```

ou

```bash
cd "./C#"
dotnet run
```

## Observacao tecnica

O projeto esta configurado como aplicativo de console (`OutputType: Exe`) para permitir interacao com `Console.ReadLine()`.
