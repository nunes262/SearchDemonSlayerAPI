# SearchDemonSlayerAPI

Aplicação **Blazor WebAssembly (.NET 10)** que consome a [Demon Slayer API](https://www.demonslayer-api.com/documentation) para listar e buscar personagens do universo Demon Slayer.

## Funcionalidades

- Listagem paginada dos personagens (`GET /api/v1/characters?page=N`)
- Busca de personagens por nome (`GET /api/v1/characters?name=...`)
- Exibição de **nome**, **idade**, **raça**, **citação** e **imagem** de cada personagem

## Estrutura

```
Models/
  Character.cs            # Modelo do personagem
  CharacterResponse.cs    # Resposta paginada da API
Services/
  DemonSlayerService.cs   # Consumo da API via HttpClient
Pages/
  Home.razor              # Tela de listagem e busca
```

## Como executar

Pré-requisito: [.NET SDK 10](https://dotnet.microsoft.com/download)

```bash
dotnet run
```

Acesse o endereço exibido no terminal (ex.: `http://localhost:5xxx`).
