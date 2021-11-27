﻿using Dalamud.Game.ClientState;
using Dalamud.Game.ClientState.Conditions;
using Dalamud.Game.ClientState.Party;
using Dalamud.Interface.Windowing;
using Dalamud.Game.Command;
using Dalamud.Game.Gui;
using Dalamud.IoC;
using Dalamud.Plugin;
using Dalamud.Game.ClientState.Objects;
using Dalamud.Data;

namespace NoTankYou
{
    public class Service {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

    [PluginService] public static DalamudPluginInterface PluginInterface { get; private set; }
    [PluginService] public static ChatGui Chat { get; private set; }
    [PluginService] public static ClientState ClientState { get; private set; }
    [PluginService] public static PartyList PartyList { get; private set; }
    [PluginService] public static CommandManager Commands { get; private set; }
    [PluginService] public static Condition Condition { get; private set; }
    [PluginService] public static ObjectTable ObjectTable { get; private set; }
    [PluginService] public static DataManager DataManager { get; private set; }
                    public static TerritoryManager TerritoryManager { get; set; }
                    public static WindowSystem WindowSystem { get; set; } = new WindowSystem("NoTankYou");
                    public static Configuration Configuration { get; set; }

#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    }
}