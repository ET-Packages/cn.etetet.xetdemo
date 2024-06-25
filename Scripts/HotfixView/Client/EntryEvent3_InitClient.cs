
namespace ET.Client
{
    [Event(SceneType.XETDemo)]
    public class EntryEvent3_InitClient1: AEvent<Scene, EntryEvent3>
    {
        protected override async ETTask Run(Scene root, EntryEvent3 args)
        {
            root.AddComponent<GlobalComponent>();
            root.AddComponent<ResourcesLoaderComponent>();
            
            root.AddComponent<FUIAssetComponent, bool>(false);
            root.AddComponent<FUIComponent>();
            
            await EventSystem.Instance.PublishAsync(root, new AppStartInitFinish());
        }
    }
}