extends Control

func _ready():
	$VBoxContainer/Label.text = get_node("/root/playerObject").ID
	$VBoxContainer/Label2.text = str(get_node("/root/playerObject").xp)
	$VBoxContainer/Label3.text = str(get_node("/root/playerObject").money)
	$VBoxContainer/Label4.text = str(get_node("/root/playerObject").hlth)
	$VBoxContainer/Label5.text = str(get_node("/root/playerObject").ammo)

func _on_Button_button_down():
	get_tree().change_scene("res://scenes/GameTypeSelect.tscn")

func _on_Button2_button_down():
	get_tree().change_scene("res://scenes/store.tscn")

func _on_Button3_button_down():
	get_tree().quit()
