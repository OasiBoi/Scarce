extends Spatial

var id

export var spd:int
export var stmn:int
export var scb:int
export var xp:int

# Called when the node enters the scene tree for the first time.
func _ready():
	pass # Replace with function body.

# Called every frame. 'delta' is the elapsed time since the previous frame.
func _process(delta):
	rotation.y += rad2deg(spd) * delta

func _on_Area_body_entered(body):
	body.stmn += stmn
	$"/root/playerObject".money += scb
	$"/root/playerObject".xp += xp	
