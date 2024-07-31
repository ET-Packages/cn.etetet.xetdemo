namespace ET.Client
{
    [EntitySystemOf(typeof(APanel))]
    [FriendOf(typeof(APanel))]
    public static partial class APanelSystem
    {
        [EntitySystem]
        private static void Awake(this APanel self)
        {
            self.FUIAPanel.AddListner(self.OnClick);
        }

        [EntitySystem]
        private static void Show(this APanel self, string arg1)
        {
            Log.Info($"{arg1}");
        }

        [EntitySystem]
        private static void Show(this APanel self, int arg1, int arg2, string arg3, string arg4, string arg5)
        {
            Log.Info($"{arg1}, {arg2}, {arg3}, {arg4}, {arg5}");
        }

        private static void OnClick(this APanel self)
        {
            self.Scene().GetComponent<FUIComponent>().ClosePanel(self);
        }
    }
}