namespace ET.Client
{
    [Event(SceneType.FUIExample)]
    public class AppStartInitFinish_CreateLoginUI: AEvent<Scene, AppStartInitFinish>
    {
        protected override async ETTask Run(Scene root, AppStartInitFinish args)
        {
            await root.GetComponent<FUIComponent>().ShowPanelAsync<LoginPanel>();
        }
    }
}