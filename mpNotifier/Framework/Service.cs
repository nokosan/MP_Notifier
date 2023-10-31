using System;
using System.Collections.Generic;
using System.Text;
using Dalamud.Game;
using Dalamud.Game.ClientState;
using Dalamud.Game.ClientState.JobGauge;
using Dalamud.Game.Gui;
using Dalamud.IoC;

namespace mpNotifier
{
    public class Service
    {
        [PluginService] public static ChatGui ChatGui { get; private set; }
        [PluginService] public static ClientState ClientState { get; private set; }
        [PluginService] public static Framework Framework { get; private set; }
        [PluginService] public static JobGauges JobGauges { get; private set; }
    }
}
