using CounterStrikeSharp.API;
using CounterStrikeSharp.API.Core;
using CounterStrikeSharp.API.Core.Attributes;
using CounterStrikeSharp.API.Modules.Entities;
using CounterStrikeSharp.API.Modules.Utils;
using Microsoft.Extensions.Localization;
using static DeathSoundPlugin.DeathSoundPlugin;
namespace DeathSoundPlugin
{
    [MinimumApiVersion(80)]
    public class DeathSoundPlugin : BasePlugin, IPluginConfig<DeathSoundPluginConfig>
    {
        public override string ModuleName => "DeathSoundPlugin";
        public override string ModuleVersion => "[EarlyBeta]";
        public override string ModuleAuthor => "hlymcn";
        public override string ModuleDescription => "Play a custom sound when a player dies.";
        public required DeathSoundPluginConfig Config { get; set; }
        public readonly IStringLocalizer<DeathSoundPlugin> _localizer;
        public DeathSoundPlugin(IStringLocalizer<DeathSoundPlugin> localizer)
        {
            _localizer = localizer;
        }

        public override void Load(bool hotReload)
        {
            RegisterEventHandler<EventPlayerDeath>(OnPlayerDeath);
        }
        private HookResult OnPlayerDeath(EventPlayerDeath @event, GameEventInfo info)
        {
            var player = @event.Userid;
            if (player == null || !player.IsValid || player.IsBot)
                return HookResult.Continue;
            var sound = Config.DeathSounds[Random.Shared.NextDistinct(Config.DeathSounds.Count)];
            {
                player.ExecuteClientCommand($"play \"{sound}\"");
            }
            var teamColor = player?.Team switch
            {
                CsTeam.CounterTerrorist => ChatColors.Blue,
                CsTeam.Terrorist => ChatColors.Red,
                _ => ChatColors.White
            };
            var playerName = player?.PlayerName ?? "Console";
            Server.PrintToChatAll($"{this._localizer["lang.chatall.death", playerName, teamColor]}");
                return HookResult.Continue;
        }
        public void OnConfigParsed(DeathSoundPluginConfig config)
        {
            if (config.DeathSounds.Count == 0)
            {
                Server.PrintToConsole("音源文件未设置!");
            }
            else
            {
                Server.PrintToConsole($"载入 {config.DeathSounds.Count} 个音源文件!");
            }

            Config = config;
        }
        public class DeathSoundPluginConfig : BasePluginConfig
        {
            public List<string> DeathSounds { get; set; } = [];
        }
    }
}
