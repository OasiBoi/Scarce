extends RigidBody

export var id:String
export var spd:int
export var dmg:int

var direction

# Called when the node enters the scene tree for the first time.
func _ready():
#	print("I EXIST (/uwu)/")
	$particles.emitting = false
	$OmniLight.visible = false

# Called every frame. 'delta' is the elapsed time since the previous frame.
func _physics_process(delta):
	add_central_force(direction * spd * 1000 * delta)


func _on_Bullet_body_entered(body):
	if body != get_node("/root").get_child(0).get_child(0):
#		print("hit something (/'O')/")
		$particles.emitting = true
		$OmniLight.visible = true
		mode = RigidBody.MODE_STATIC
		$bulletTimeout.stop()
		$MeshInstance.visible = false
		$collisionParticle.start()
#		print(body)


func _on_bulletTimeout_timeout():
#	print("time out (/-_-)/")
	queue_free()

func _on_collisionParticle_timeout():
	queue_free()

func _on_Area_tree_exited():
#	print("i dead boi (/x~x)/")
	pass
