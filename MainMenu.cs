using Godot;
using System;

public partial class MainMenu : ColorRect
{
    public override void _Ready()
    {
        GetNode<Button>("MarginContainer/VBoxContainer/Play").Pressed +=
            () => GetNode<SceneLoader>("/root/SceneLoader").ChangetoScene("main_menu_2.tscn");

			GetNode<Button>("MarginContainer/VBoxContainer/Options").Pressed +=
            () => GetNode<SceneLoader>("/root/SceneLoader").ChangetoScene("options.tscn");
    }


    public void ExitGame() {
        GetTree().Quit();
    }
}