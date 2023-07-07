using Godot;

// Custom node logic

[Tool]
public partial class CustomButton : Button
{

  // Initialize the custom node here:    
  public override void _EnterTree() {
    // Connect pressed signal with function
    Pressed += onButtonPressed;
  }

  // Cleanup the custom node here:
  public override void _ExitTree() {}

  // Called then button is clicked:
  public void onButtonPressed() {
    GD.Print("Button pressed.");
  }
}
