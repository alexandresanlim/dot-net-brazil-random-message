# DotNet.BrazilRandomMessage

[![Nuget](https://img.shields.io/nuget/dt/BrazilRandomMessage)](https://www.nuget.org/packages/BrazilRandomMessage)
[![Nuget](https://img.shields.io/nuget/v/BrazilRandomMessage)](https://www.nuget.org/packages/BrazilRandomMessage)

Impressione os usuários da sua aplicação, retornando de maneira muito facil uma mensagem aleatória para brasileiros, usando como parâmetro a data atual.

É de muita importância quando a sua aplicação "conversa" com o usuário, de forma que faça-o ficar impressionado e sentir-se exclusivo.

Com esse projeto esta missão será extremamente facil.

## Como usar
 - Instale [este pacote](https://www.nuget.org/packages/BrazilRandomMessage/1.0.0) via nuget ou linha de comando:<br/>
`Install-Package BrazilRandomMessage`

- Pegar uma mensagem randômica <br/>
```csharp
var randomMessage = DotNet.BrazilRandomMessage.Messages.GetOne()
```

A mensagem retornada você pode colocar por exemplo no topo da sua aplicação ou na página de configurações do usuário.

## O que pode retornar?

A mensagem retornada usa como parâmetro a data atual, veja as possibilidades:

| Tipo  |  Mensagens  |
| ------------------- | ------------------- |
|  **Boas vindas** |  "Seja muito bem vindo."<br/> "É muito bom te ver novamente."<br/> "O que está procurando hoje?"<br/> "Como vão as coisas?"<br/> "Como vai você?" |
|  **Final de semana** |  "Final de semana chegouuuuu! 🎶" <br/>"Iae, o que vai fazer neste FDS?" <br/>"Balada ou Netflix, o q tem pra hj?" |
|  Sexta-Feira | Em **Final de Semana** ou: <br/>  "#Sextou? ;)"<br/> "Hoje é sexta feiraaaaa o/ |
|  Domingo | Em **Boas vindas** ou: <br/>  "Tenha um ótimo domingo! ;)" <br/> "Hoje é domingo, dia de parque?" |
|  Segunda-Feira | Em **Boas vindas** ou: <br/>   "Ótimo começo de semana!" <br/>"Ótima segunda-feira!" |
|  Feriados | Em **Boas vindas** ou conforme um feriado: <br/> **Ano Novo** <br/> "Feliz ano novo! 🎉"<br/> "Que esse ano seja repleto de felicidade para você!" <br/> "Que esse ano seus sonhos se relizem! ;)" <br/> "Que esse ano seja repleto de luz e paz para você!" <br/> **Tiradentes** <br/>  "Hj é dia de Tiradentes um grande lider da Inconfidência Mineira" <br/> **Dia do trabalho** <br/> "Hj é dia do trabalho, parabéns a tds trabalhadores! 👷‍" <br/> **Indepêndencia** <br/> "7 de setembro, Indepência ou morte! ⚔" <br/> "Hj é um marco na nossa história, Indepêndencia do Brasil!" <br/> **NS Aparecida** <br/> "Hj é dia de Nossa Senhora Aparecida 🙏" <br/> "12 de outubro ao 12:00 hrs foi encontrado a nossa padroeira 🙏" <br/> "Feliz dia das crianças. " <br/> **Finados** <br/> "Dia de finados, que esteja em paz aqueles que se foram 🙏" <br/> **Proclamação da República** <br/> "Hoje é dia da Proclamação da República" <br/> **Natal** <br/> "É pavê ou pa comê? 🤦‍♂️" <br/> "Ho ho ho Feliz natal! 🎄" <br/> "Comemoremos o aniversário de cristo 🙏" <br/> **Pascoa** <br/> "Hj é o dia da ressureição de Jesus Cristo" <br/> "Feliz Páscoa! 🐰" <br/> **Sexta-feira santa** <br/> "Hj é o dia da Paixão de Cristo 🙏" <br/> **Carnaval** <br/> "Feliz carnaval!" <br/> "Feliz carnaval, comemore com moderação :)" <br/> **Corpus Christ** <br/> "Tomai e comei, isto é o meu corpo. Mateus 26:26" |

## Customizações:
- Você pode querer remover algum tipo de mensagem, para isso basta que:

Remover mensagens de feriados:
```csharp
DotNet.BrazilRandomMessage.Messages.NotIncludeHoliday();
````
Remover mensagens de sexta-feira:
```csharp
DotNet.BrazilRandomMessage.Messages.NotIncludeFriday();
````
Remover mensagens de final de semana:
```csharp
DotNet.BrazilRandomMessage.Messages.NotIncludeWeekend();
````
Remover mensagens de domingo:
```csharp
DotNet.BrazilRandomMessage.Messages.NotIncludeSunday();
````

## Mais
- Contribuições são bem vindas ;)

[![forthebadge](https://forthebadge.com/images/badges/built-with-love.svg)](https://forthebadge.com)
