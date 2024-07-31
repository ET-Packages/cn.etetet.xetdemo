namespace ET.Client
{
    [EntitySystemOf(typeof(LoginPanel))]
    [FriendOf(typeof(LoginPanel))]
    public static partial class LoginPanelSystem
    {
        [EntitySystem]
        private static void Awake(this LoginPanel self)
        {
            self.FUILoginPanel.LoginBtn.AddListner(self.OnLoginBtn);
        }

        private static void OnLoginBtn(this LoginPanel self)
        {
            var fuiCom = self.Scene().GetComponent<FUIComponent>();
            fuiCom.HideAndShowPanelStackAsync<LoginPanel, ExampleListPanel>().NoContext();
        }
    }
}