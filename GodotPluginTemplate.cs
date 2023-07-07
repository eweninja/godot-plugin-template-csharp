#if TOOLS
using Godot;

// Custom plugin main file

[Tool]
public partial class GodotPluginTemplate : EditorPlugin
{
  
  // Initialize the plugin here:
  public override void _EnterTree() {
    // Register custom node with name, parent type, script and icon:
    var script = GD.Load<Script>("res://addons/godot-plugin-template-csharp/CustomButton.cs");
    var icon = GD.Load<Texture2D>("res://addons/godot-plugin-template-csharp/custom_button_icon_16x16.png");
    AddCustomType("CustomButton", "Button", script, icon);
  }

  // Cleanup the plugin here:
  public override _ExitTree() {
    // Plugin deactivated, remove custom button:
    RemoveCustomType("CustomButton");
  }
}
