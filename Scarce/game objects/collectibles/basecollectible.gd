extends Spatial

var id

export var spd:float
export var stmn:int
export var money:int
export var xp:int

# Called when the node enters the scene tree for the first time.
func _ready():
	pass # Replace with function body.

# Called every frame. 'delta' is the elapsed time since the previous frame.
func _process(delta):
	rotation.y += rad2deg(spd) * 0.0001

func _on_Area_body_entered(body):
	if body.get_name() == "Player":
		body.addValues(money, xp, stmn)
		queue_free()
