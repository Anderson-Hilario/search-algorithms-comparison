# Comparação de Algoritmos de Busca

Este repositório tem como objetivo comparar o desempenho de diferentes algoritmos de busca aplicados a vetores (arrays) em diferentes cenários, com foco na análise do **tempo de execução**.

## 📌 Algoritmos implementados

- 🔍 Busca Linear
- 🔎 Busca Binária

## ⚙️ Tecnologias

- Linguagem: **C#**
- IDE: **Visual Studio 2022**
- Ferramenta de medição de tempo: `Stopwatch` da biblioteca `System.Diagnostics`

## 🧪 Cenários de teste

- Vetores com diferentes tamanhos (ex: 1.000, 10.000, 100.000 elementos)
- Elemento buscado no:
  - Início do vetor
  - Meio do vetor
  - Final do vetor
  - Elemento inexistente

## 📈 Resultados esperados

Através dos testes, espera-se observar que:

- A **busca linear** tem desempenho constante em vetores não ordenados, mas tempo crescente proporcional ao tamanho do vetor.
- A **busca binária** apresenta desempenho superior em vetores ordenados, com tempo logarítmico (O(log n)).

## 🚀 Como executar

1. Clone o repositório:
   ```bash
   git clone https://github.com/seu-usuario/nome-do-repositorio.git
