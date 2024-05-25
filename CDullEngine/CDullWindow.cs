namespace CDullEngine;

using OpenTK.Graphics.OpenGL4;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;
using OpenTK.Windowing.GraphicsLibraryFramework;

public class CDullWindow : GameWindow {
    public readonly string CDullEngineVersion = "1.0.0";
    public CDullProject cDullProject;

    public CDullWindow(int width, int height, string title, CDullProject cDullProject) : base(GameWindowSettings.Default, new NativeWindowSettings() { ClientSize = (width, height), Title = title }) {
        this.cDullProject = cDullProject;
    }

    protected override void OnUpdateFrame(FrameEventArgs args) {
        base.OnUpdateFrame(args);
        cDullProject.Update();
    }

    protected override void OnLoad() {
        base.OnLoad();
        cDullProject.Start();
    }
}
