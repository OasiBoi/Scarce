extends Spatial

onready var p = preload("res://game objects/Player.tscn")

export var ID:String
export var spd:int
export var jmp:int
export var hlth:int
export var money:int
export var xp:int
export var ammo:int

var player
# Called when the node enters the scene tree for the first time.
	

func spawnPlayer(pos = Vector3()):
	var player = p.instance()
	add_child(player)
	player.ID = ID
	player.jump = jmp
	player.spd = spd
	player.stmn = 100
	player.subFac.x = 0.1
	player.subFac.y = 0.1
	player.translation = pos
	