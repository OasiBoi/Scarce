extends Node

var otherPlayerId = -1

var pauseGame
var inGame

func _ready():
	inGame = false
	pauseGame = false

func GamePause():
		if get_tree().paused == false:
			print("pausing...")
			get_tree().paused = true
		if get_tree().paused == true:
			print("pausing...")
			get_tree().paused = false
