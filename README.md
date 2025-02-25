# DeathSoundPlugin for Counter-Strike 2

## Overview

**DeathSoundPlugin** is a custom plugin for Counter-Strike 2 servers, designed to enhance the gameplay experience by playing a custom sound whenever a player dies. This plugin adds a unique auditory element to the game, making it more immersive and engaging for players. Additionally, it provides server administrators with the flexibility to customize the death sounds and manage player interactions through chat messages.

## Key Features

- **Custom Death Sounds:** Automatically play a random sound from a predefined list when a player dies.
- **Configurable Sound List:** Administrators can easily customize the list of death sounds via a configuration file.
- **Localized Chat Messages:** The plugin supports localized chat messages, allowing for multilingual server communication.
- **Team-Based Chat Colors:** Display chat messages with team-specific colors (e.g., blue for Counter-Terrorists, red for Terrorists).
- **Event-Driven:** The plugin triggers sounds based on the `EventPlayerDeath` event, ensuring seamless integration with the game's mechanics.

## Identifiers

- **ModuleName:** DeathSoundPlugin  
- **ModuleVersion:** [EarlyBeta]  
- **ModuleAuthor:** hlymcn  
- **ModuleDescription:** Play a custom sound when a player dies

## Usage

To utilize the DeathSoundPlugin, follow these steps:

1. **Installation:** Acquire the plugin from the [GitHub repository](https://github.com/hlymcn/DeathSoundPlugin) and place it in your server's plugin directory.
2. **Configuration:** Customize the plugin by editing the `DeathSoundPluginConfig` file to add or modify death sounds.
3. **Activation:** Upon activation, the plugin will automatically play a random death sound whenever a player dies and display a localized chat message.

## Requirements

- CounterStrikeSharp: [CounterStrikeSharp](https://github.com/roflmuffin/CounterStrikeSharp)  
- MetaMod: [MetaMod](https://www.metamodsource.net/downloads.php?branch=dev)

## Installation

1. Clone the repository or download the latest release from [GitHub](https://github.com/hlymcn/DeathSoundPlugin).
2. Copy the plugin files to `...\addons\counterstrikesharp\plugins\DeathSoundPlugin`.
3. Edit the configuration file `...\addons\counterstrikesharp\configs\plugins\DeathSoundPlugin\DeathSoundPluginConfig.json` to set up your death sounds.
4. Ensure your server meets the API version requirements and adjust settings as necessary.

## Contribution and Support

We encourage community contributions. For suggestions or to report issues, please submit a pull request or open an issue on the [GitHub repository](https://github.com/hlymcn/DeathSoundPlugin). Your input is crucial for the ongoing development of the plugin.

## License

This project is licensed under the MIT License - see the LICENSE file for details.

## Conclusion

The DeathSoundPlugin is a fun and engaging addition to Counter-Strike 2 servers, adding a unique auditory element to the game. Its easy setup and customizable features make it an excellent choice for server administrators looking to enhance their players' experience and create a more immersive environment.
