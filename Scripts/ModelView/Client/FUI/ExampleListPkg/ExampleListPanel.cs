using ET.Client.ExampleListPkg;

namespace ET.Client
{
    [ComponentOf(typeof(FUIEntity))]
    [FUIPanel(PanelId.ExampleListPanel, "ExampleListPkg", "ExampleListPanel")]
    public class ExampleListPanel : Entity, IAwake, IShow
    {
        private FUI_ExampleListPanel _fuiExampleListPanel;

        public FUI_ExampleListPanel FUIExampleListPanel
        {
            get => _fuiExampleListPanel ??= (FUI_ExampleListPanel)this.GetParent<FUIEntity>().GComponent;
        }
    }
}