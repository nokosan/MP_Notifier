using Dalamud.Game.Command;
using Dalamud.Interface.Windowing;
using Dalamud.IoC;
using Dalamud.Plugin;

namespace mpNotifier
{
    public class Plugin: IDalamudPlugin
    {
        public string Name => "MP Notifier";
        private CommandManager commandManager { get; init; }
        private MpWindow mpWindow { get; init; }
        private WindowSystem windowSystem = new("mpNotifier");
        public Plugin(
            [RequiredVersion("1.0")] DalamudPluginInterface dalamud,
            [RequiredVersion("1.0")] CommandManager commandManager
            )
        {
            this.commandManager = commandManager;
            mpWindow = new MpWindow();
            this.windowSystem.AddWindow(mpWindow);
            commandManager.AddHandler("/mpnh", new CommandInfo(OnCommand) { HelpMessage = "show mp notifier help" });
            dalamud.Create<Service>();
            dalamud.UiBuilder.Draw += DrawUI;
        }

        private void OnCommand(string cmd,string args)
        {
            Service.ChatGui.Print("this is a help msg");
            this.mpWindow.IsOpen = true;
        }
        public void Dispose()
        {
            this.windowSystem.RemoveAllWindows();
            commandManager.RemoveHandler("/mpnh");
        }
        private void DrawUI()
        {
            this.windowSystem.Draw();
        }
    }
}
