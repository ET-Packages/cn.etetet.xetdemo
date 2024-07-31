namespace ET.Client
{
    [EntitySystemOf(typeof(Example1Panel))]
    [FriendOf(typeof(Example1Panel))]
    public static partial class Example1PanelSystem
    {
        [EntitySystem]
        private static void Awake(this Example1Panel self)
        {
            self.FUIExample1Panel.BackBtn.AddListner(self.OnBackBtn);
            self.FUIExample1Panel.Btn1.AddListner(self.OnBtn1);
            self.FUIExample1Panel.Btn2.AddListner(self.OnBtn2);
        }

        [EntitySystem]
        private static void Show(this Example1Panel self)
        {
            Log.Info("Example1PanelSystem.Show()");
        }

        private static void OnBackBtn(this Example1Panel self)
        {
            self.Scene().GetComponent<FUIComponent>().ClosePanel(self);
        }

        private static void OnBtn1(this Example1Panel self)
        {
            self.Scene().GetComponent<FUIComponent>().ShowPanelAsync<APanel, string>("arg1").NoContext();
        }

        private static void OnBtn2(this Example1Panel self)
        {
            self.Scene().GetComponent<FUIComponent>().ShowPanelAsync<APanel, int, int, string, string, string>(1, 2, "C", "D", "E").NoContext();
        }
    }
}