extends KinematicBody

export var id:String
export var spd:int
export var dmg:int
#export var position:Vector3

var velocity = Vector3()
var direction
# Called when the node enters the scene tree for the first time.
func _ready():
	print("I EXIST")

# Called every frame. 'delta' is the elapsed time since the previous frame.
func _physics_process(delta):
	velocity = direction * spd * 10000 * delta
	velocity = move_and_slide(velocity)

func _on_Timer_timeout():
	queue_free()

func _on_Area_body_entered(body):
	print("hit something")
	$particles.emitting = false
	$particles2.emitting = true
	$Timer2.start(.1)
	if $Timer2.time_left == 0:
		_on_Timer_timeout()

func _on_bullet_tree_exited():
	print("now I don't :(")

#func _on_bullet_tree_entered():
#	translation = position
