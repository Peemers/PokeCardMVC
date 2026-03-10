# PokeCardMvc

PokeCardMvc est une application web construite avec **ASP.NET Core MVC** qui permet aux utilisateurs de parcourir une liste de Pokémon et de consulter leurs détails en s'appuyant sur l'API externe **PokeAPI**.

## 🚀 Fonctionnalités

* **Affichage de la liste :** Présentation d'une collection de Pokémon récupérée depuis l'API.
* **Détails individuels :** Consultation des caractéristiques spécifiques de chaque Pokémon (Stats, Types, etc.).
* **Interface Responsive :** Utilisation de Bootstrap pour un affichage adapté sur tous les écrans.

## 🛠️ Stack Technique

* **Framework :** .NET 10.0.
* **Architecture :** Modèle-Vue-Contrôleur (MVC).
* **Langage :** C#.
* **Frontend :** Razor Views, HTML5, CSS3, JavaScript (jQuery & Bootstrap).
* **Source de données :** [PokeAPI](https://pokeapi.co/).

## 📂 Structure du Projet

* **Controllers/**
    * `PokeController.cs` : Gère la logique de navigation entre la liste et les vues de détails.
* **Models/**
    * `Pokemon.cs` : Modèle de données principal pour un Pokémon.
    * `PokeApiDtos.cs` : Objets de transfert de données (DTO) pour la désérialisation des réponses JSON de PokeAPI.
* **Views/**
    * `Poke/Index.cshtml` : Vue affichant la liste complète.
    * `Poke/Details.cshtml` : Vue affichant les informations détaillées d'un Pokémon spécifique.
* **wwwroot/** : Contient les fichiers statiques (CSS, JS, Bibliothèques).

## ⚙️ Configuration et Installation

### Prérequis
* [.NET 10 SDK](https://dotnet.microsoft.com/download)

### Étapes d'installation
1.  **Cloner le dépôt :**
    ```bash
    git clone [https://github.com/votre-utilisateur/PokeCardMvc.git](https://github.com/votre-utilisateur/PokeCardMvc.git)
    cd PokeCardMvc
    ```

2.  **Restaurer les dépendances :**
    ```bash
    dotnet restore
    ```

3.  **Exécuter l'application :**
    ```bash
    dotnet run --project PokeCardMvc/PokeCardMvc.csproj
    ```
    L'application sera disponible par défaut sur `https://localhost:5001` ou `http://localhost:5000`.

## 📖 Utilisation

* Accédez à la page d'accueil pour voir la liste des Pokémon chargés depuis l'API.
* Cliquez sur un Pokémon pour voir ses détails (capacités, statistiques, et images).

## 📝 Licence
Ce projet est sous licence MIT - voir le fichier [LICENSE](wwwroot/lib/bootstrap/LICENSE) pour plus de détails.
