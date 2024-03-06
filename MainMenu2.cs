 using Godot;
using System;

public partial class MainMenu2 : ColorRect
{

	public override void _Ready()
	{
		GetNode<Button>("VBoxContainer2/Back").Pressed +=
            () => GetNode<SceneLoader>("/root/SceneLoader").ChangetoScene("main_menu.tscn");
	}
}
 