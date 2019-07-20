extends Position3D

onready var bullet = preload("res://game objects/bullet.tscn") 
var shootOk = true

var b


# Called every frame. 'delta' is the elapsed time since the previous frame.
func _process(delta):
	b = bullet.instance()	
	
	if(Input.is_action_pressed("ui_shoot")):
		if(shootOk):
			get_tree().get_root().get_child(2).add_child(b)
			b.translation = global_transform.origin
			b.direction = global_transform.basis.z
			b.id = playerObject.ID
			shootOk = false

func _on_gunCoolDown_timeout():
	shootOk = true
