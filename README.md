### 使用方式：
ET Book 里的运行指南里提到了 statesync 和 lockstep 两个 Demo 包的安装方式，xetdemo 包的安装方式和它们是一样的。
1. 按照运行指南操作，在 Unity 的 PackageManager 里添加包时不添加 statesync 或 lockstep 的地址，添加 xetdemo 的地址：cn.etetet.xetdemo
2. 下载完成之后运行 Unity 菜单，ET -> XET -> Init

注意事项：
1. ET.Init/Resources/GlobalConfig.asset 的 SceneName 需要设置为 XETDemo
2. xetdemo 和 statesync/lockstep 不能共存，可以删除掉 statesync/lockstep 或重新拉取一个新的 ET 项目，再添加 cn.etetet.xetdemo

### 如何导出 FairyGUI 代码
1. 在 FairyGUI 里，发布 UI 的 bytes 文件和图集文件到 /YourProjectPath/Packages/cn.etetet.xetdemo/Bundles/FUI 里，xetdemo 里已经包含了这些文件。
2. 运行Unity菜单 ET -> XET -> FairyGUI 代码导出，会打开 FUICodeSpawnEditor
3. 点击 “选择 FairyGUI 项目根目录” 按钮，选择路径，比如：/YourProjectPath/Packages/cn.etetet.xetdemo/FGUIProject~
4. 点击 “选择导出到哪个包里” 按钮，选择路径，比如：/YourProjectPath/Packages/cn.etetet.xetdemo
5. 可以在 “选择要导出的包名” 后面的列表里，选择“全部导出”或者单独导出某个界面的代码
6. 如果没有在列表里找到发布的界面，可以点击刷新按钮

### 注意
XET.FUI 使用的是修改版的 FairyGUI SDK: https://github.com/SunHowe/FairyGUI-Dynamic, 如果想用原版需自行替换。