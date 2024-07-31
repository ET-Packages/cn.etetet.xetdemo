using ET.Client.Example1Pkg;

namespace ET.Client
{
    [ComponentOf(typeof(FUIEntity))]
    [FUIPanel(PanelId.APanel, "Example1Pkg", "APanel")]
    public class APanel : Entity, IAwake, IShow<string>, IShow<int, int, string, string, string>
    {
        private FUI_APanel _fuiAPanel;

        public FUI_APanel FUIAPanel
        {
            get => _fuiAPanel ??= (FUI_APanel)this.GetParent<FUIEntity>().GComponent;
        }
    }
}