using Godot;
using System;

public partial class Options : ColorRect
{

	public override void _Ready()
	{
	GetNode<Button>("MarginContainer/VBoxContainer/Back To Main Menu").Pressed +=
            () => GetNode<SceneLoader>("/root/SceneLoader").ChangetoScene("main_menu.tscn");
	
	}
}
