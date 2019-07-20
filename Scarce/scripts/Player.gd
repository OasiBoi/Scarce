extends KinematicBody

export var ID:String
export var stmn:int
export var spd:int
export var jump:int
export var sens:int

export var subFac:Vector2
export var grav = 9.8
export var look_limits:Vector2
var direction = Vector3()
var velocity = Vector3()
var lookY = 0
var lookX = 0
var lookXAngle = 0

# Called every frame. 'delta' is the elapsed time since the previous frame.
func _physics_process(delta):
	if(is_network_master()):
		#reset movement values
		direction = Vector3(0,0,0)
		lookY = 0
		lookX = 0
		
		#move
		if Input.get_joy_axis(0, 1) > .3 or Input.get_joy_axis(0, 1) < - .3:
			direction -= $head.global_transform.basis.z * Input.get_joy_axis(0, 1) * spd * delta
			stmn -= subFac.x
			if get_node("/root/playerObject").stmn == 0 and get_node("/root/playerObject").hlth > 1:
				get_node("/root/playerObject").hlth -= subFac.y
		if Input.get_joy_axis(0, 0) > .3 or Input.get_joy_axis(0, 0) < - .3:
			direction -= $head.global_transform.basis.x * Input.get_joy_axis(0, 0) * spd * delta
			stmn -= subFac.x
			if get_node("/root/playerObject").stmn == 0 and get_node("/root/playerObject").hlth > 1:
				get_node("/root/playerObject").hlth -= subFac.y
	
		#jump
		if(is_on_floor() and Input.is_action_just_pressed("ui_select")):
			velocity.y = jump;
			print("jump")
		
		#horizontal look
		if Input.get_joy_axis(0, 2) > .3 or Input.get_joy_axis(0, 2) < - .3:
			lookY -= Input.get_joy_axis(0, 2) * sens
	
		#vertical look
		if Input.get_joy_axis(0, 3) > .3 or Input.get_joy_axis(0, 3) < - .3:
			lookX += Input.get_joy_axis(0, 3) * sens
		
		#turns head around y axis
		$head.rotate_y(deg2rad(lookY))
		
		#turns head around x axis
		var change = lookX
		if change + lookXAngle < look_limits.x and change + lookXAngle > look_limits.y:
			$head/Camera.rotate_x(deg2rad(change))
			lookXAngle += change
		 
		
		if (velocity.y < 0):
			grav = 30
	
		velocity.y += -grav * delta
		velocity.x = direction.x * spd * delta
		velocity.z = direction.z * spd * delta
		
		# Tell the other computer about our new position so it can update       
		rpc_unreliable("setPos",Vector3(translation.x, translation.y, translation.z))   
		
		velocity = move_and_slide(velocity, Vector3(0,1,0))

	
slave func setPos(pos = Vector3()):
	translation = pos


func _on_Area_body_entered(body):
	if body.get_name() == "bullet":
		var bullet = body
		get_node("/root/playerObject").hlth -= bullet.dmg
