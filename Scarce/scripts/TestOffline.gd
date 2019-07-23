extends Spatial

# Declare member variables here. Examples:
var host = NetworkedMultiplayerENet.new()
# var b = "text"

# Called when the node enters the scene tree for the first time.
func _ready():
	var res = host.create_server(4242, 2)
	if res != OK:
		print("Error creating server")
		return
	get_tree().set_network_peer(host)
	var thisPlayer = get_parent().get_child(0)
	thisPlayer.spawnPlayer($spawns/Position3D.translation)
	thisPlayer.set_name(str(get_tree().get_network_unique_id()))
	thisPlayer.set_network_master(get_tree().get_network_unique_id())
	add_child(thisPlayer)

# Called every frame. 'delta' is the elapsed time since the previous frame.
func _process(delta):
	if Input.is_action_pressed("pause"):
		get_node("/root/globals").GamePause()