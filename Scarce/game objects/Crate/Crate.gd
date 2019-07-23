extends RigidBody

export var hlth:float

export var moneyInt:int
export var stmnInt:int
export var xpInt:int

var i = 0
var j = 0
var k = 0
var m = preload("res://game objects/collectibles/money.tscn")
var s = preload("res://game objects/collectibles/stmn.tscn")
var x = preload("res://game objects/collectibles/xp.tscn")

# Called when the node enters the scene tree for the first time.
func _ready():
	pass

func _process(delta):
	var n = randi() % $spawns.get_child_count()
	var spwnPos = $spawns.get_child(n)
	if hlth <= 0:
		$Crate1.visible = false
		$CollisionShape.disabled = true
		$StaticBody/CollisionShape2.disabled = true
		$Particles.emitting = true
		if i < moneyInt:
			var money = m.instance()
			spwnPos.add_child(money)
			print("money spawn at: " + str(n) + " " + str(spwnPos))
			i += 1
			print("money spawned: " + str(i))
		if j < stmnInt:
			var stmn = s.instance()
			spwnPos.add_child(stmn)
			print("stamina spawned at: " + str(n) + " " + str(spwnPos))
			j += 1
			print("stamina spawned: " + str(j))
		if k < xpInt:
			var xp = x.instance()
			spwnPos.add_child(xp)
			print("xp spawned at: " + str(n) + " " + str(spwnPos))
			k += 1
			print("xp spawed: " + str(k))
		


func _on_Crate_body_entered(body):
	if body.get_name() == "Bullet":
		hlth -= body.dmg
		print("oof i got hit")
		print(hlth)



