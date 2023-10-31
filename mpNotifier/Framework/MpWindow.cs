using Dalamud.Interface.Windowing;
using FFXIVClientStructs.FFXIV.Client.Game.Character;
using ImGuiNET;
using System;
using System.Numerics;
using Dalamud.Game.ClientState.JobGauge.Types;
using FFXIVClientStructs.FFXIV.Client.Game;
using Lumina.Excel.GeneratedSheets;
using static Lumina.Data.Parsing.Layer.LayerCommon;

namespace mpNotifier
{
    public class MpWindow: Window, IDisposable
    {
        private BLMGauge bLMGauge;
        private readonly unsafe ActionManager* _actionManager;
        private int flag { get; set; }
        public unsafe MpWindow() : base("MP Notifier") {
            _actionManager = ActionManager.Instance();
            this.SizeConstraints = new WindowSizeConstraints
            {
                MinimumSize = new Vector2(375, 330),
                MaximumSize = new Vector2(float.MaxValue, float.MaxValue)
            };
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public override unsafe void Draw()
        {
            ImGui.Spacing();
            var bLMGauge = Service.JobGauges.Get<BLMGauge>();
            // 天语倒计数
            var _ElementTimeRemaining = bLMGauge.ElementTimeRemaining;
            // 通晓倒计时
            var _EnochianTimer = bLMGauge.EnochianTimer;
            // 是否在冰状态
            var _InUmbralIce = bLMGauge.InUmbralIce;
            // 灵极冰层数
            var _UmbralIceStacks = bLMGauge.UmbralIceStacks;
            ImGui.Text($"{_EnochianTimer} and {_ElementTimeRemaining}");
            // 角色信息
            Character* character = (Character*)Service.ClientState.LocalPlayer.Address;
            BattleChara* battleChara = (BattleChara*)Service.ClientState.LocalPlayer.Address;
            // ImGui.Text($"{Character.CharacterModes.Normal}");
            // Character.CastInfo castInfo = battleChara->SpellCastInfo;
            //var cast_actionID = castInfo.ActionID;
            var cd = _actionManager->GetRecastGroupDetail(57);
            ImGui.Text($"{cd->Total},{cd->Elapsed}.{cd->ActionID}");
            ImGui.Text($"{_actionManager->GetActionStatus(ActionType.Spell, 152)}");
            ImGui.Text($"{_actionManager->GetRecastTime(ActionType.Spell, 152)}"); //复唱时间(GCD)
            ImGui.Text($"{Service.ClientState.LocalPlayer.TotalCastTime}"); //当前施法的咏唱时间(GCD)
            ImGui.Text($"{ActionManager.GetAdjustedCastTime(ActionType.Spell, 152, 1, null)}"); //152的施法时间
            // 计算当前蓝量,计算天语秒数, (天语-绝望秒数)/火4秒数 (当前蓝量-800)/1600
            // (当前蓝量-800)/1600 > (天语-绝望秒数)/火4秒数 是否要补一个火3
            var currentMp = Service.ClientState.LocalPlayer.CurrentMp;
            if (ImGui.Button("Click Me"))
            {
                // Handle button click...
            }
        }

    }
}
