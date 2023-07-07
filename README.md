# godot-plugin-template-csharp

Simple Godot 4 plugin template in C#.

If you want to use GDScript version of template go to [Godot Plugin Template in GDScript](https://github.com/eweninja/godot-plugin-template-gdscript).

## How to start creating?

1. Create project in Godot 4.
2. Create `res://addons` directory.
3. Open Terminal or CMD and `cd` into addons directory, for example `cd C:\godot-projects\my-project-1`.
4. Clone this repository: `git clone https://github.com/eweninja/godot-plugin-template-csharp`.
5. Rename directory as you want to.
6. Change paths in main script file `GodotPluginTemplate.cs`.

## Creating plugins

Minimal requirement is to have two files in plugin folder:
- main script, for example `plugin.cs`
- config file `plugin.cfg`

In config file you have to specify the name, description, author, version and base script.
In the plugin scripts you have to wrap class in:

```cs
#if TOOLS

...

#endif
```

and add `[Tool]` keyword.
