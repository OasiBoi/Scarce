extends Node2D

var host = NetworkedMultiplayerENet.new()

func _ready():
  get_tree().connect("network_peer_connected", self, "_player_connected")

func _player_connected(id):
	print(str(id) +" connected to server!")
	#Game on!
	globals.otherPlayerId = id
	var game = preload("res://scenes/Test.tscn").instance()
	get_tree().get_root().add_child(game)
	hide()

func _on_buttonHost_pressed():
	print(get_node("/root/playerObject").ID + " is hosting network")
	var res = host.create_server(4242, 2)
	if res != OK:
		print("Error creating server")
		_on_buttonJoin_pressed()
		return
	$buttons/buttonJoin.hide()
	$buttons/buttonHost.disabled = true
	$buttons.i = $buttons.get_child_count() -1
	$buttons.scrollok = false
	get_tree().set_network_peer(host)


func _on_buttonJoin_pressed():
	print("Joining network")
	host.create_client("127.0.0.1", 4242)
	get_tree().set_network_peer(host)
	$buttons/buttonHost.hide()
	$buttons/buttonJoin.disabled = true
	$buttons.i = $buttons.get_child_count() -1
	$buttons.scrollok = false

func _on_back_pressed():
	get_tree().change_scene("res://scenes/GameTypeSelect.tscn")
	print("connection closed")