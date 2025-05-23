#if TOOLS
using Godot;

namespace F00F.Init;

[Tool]
internal partial class Plugin : EditorPlugin
{
    public sealed override void _EnterTree()
    {
        SyncSharp.Execute();
        SyncSharp.Activate();
    }

    public sealed override void _ExitTree()
        => SyncSharp.Deactivate();
}
#endif
