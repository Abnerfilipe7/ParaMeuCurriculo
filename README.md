# Verificador de Temperatura

## O que foi utilizado
- **Linguagem**: C#
- **Ambiente**: .NET Core ou qualquer IDE que suporte C# (como Visual Studio ou Visual Studio Code)

## Etapas Implementadas
1. **Entrada do Usuário**: O programa solicita que o usuário insira uma temperatura em graus Celsius.
2. **Validação de Entrada**: Utiliza `double.TryParse` para garantir que a entrada do usuário seja um número válido.
3. **Classificação da Temperatura**:
   - Se a temperatura for menor que 15°C, imprime "Está frio."
   - Se a temperatura estiver entre 15°C e 25°C, imprime "Está agradável."
   - Se a temperatura for maior que 25°C, imprime "Está quente."

## Backlog
- [ ] Adicionar suporte para outras unidades de temperatura (como Fahrenheit).
- [ ] Implementar uma interface gráfica para melhorar a interação com o usuário.
- [ ] Incluir testes automatizados para validar a lógica de classificação.
- [ ] Melhorar a validação de entrada para lidar com valores extremos e não numéricos.

## Conclusão
Este projeto é um exemplo simples de como coletar e processar dados de entrada do usuário em C#. O código demonstra conceitos básicos de controle de fluxo, como condicionais, e manipulação de entradas. Futuras melhorias podem incluir suporte a diferentes unidades de medida e uma interface mais amigável.
