using FairyGUI;

namespace ET.Client
{
    [EntitySystemOf(typeof(ExampleListPanel))]
    [FriendOf(typeof(ExampleListPanel))]
    public static partial class ExampleListPanelSystem
    {
        [EntitySystem]
        private static void Awake(this ExampleListPanel self)
        {
            self.FUIExampleListPanel.BackBtn.AddListner(self.OnBackBtn);
        }

        [EntitySystem]
        private static void Show(this ExampleListPanel self)
        {
            for (int i = 1; i <= 1; i++)
            {
                GButton Button = (GButton)self.FUIExampleListPanel.List.AddItemFromPool();
                Button.text = $"例子{i}";
                Button.AddListner(self.OnButton, i);
            }
        }

        private static void OnButton(this ExampleListPanel self, int i)
        {
            FUIComponent fuiCom = self.Scene().GetComponent<FUIComponent>();
            switch (i)
            {
                case 1:
                {
                    fuiCom.ShowPanelAsync<Example1Panel>().NoContext();
                    break;
                }
            }
        }

        private static void OnBackBtn(this ExampleListPanel self)
        {
            self.Scene().GetComponent<FUIComponent>().ClosePanel(self);
        }
    }
}