using ET.Client.Example1Pkg;

namespace ET.Client
{
    [ComponentOf(typeof(FUIEntity))]
    [FUIPanel(PanelId.Example1Panel, "Example1Pkg", "Example1Panel")]
    public class Example1Panel : Entity, IAwake, IShow
    {
        private FUI_Example1Panel _fuiExample1Panel;

        public FUI_Example1Panel FUIExample1Panel
        {
            get => _fuiExample1Panel ??= (FUI_Example1Panel)this.GetParent<FUIEntity>().GComponent;
        }
    }
}