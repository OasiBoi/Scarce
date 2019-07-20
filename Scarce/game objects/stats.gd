extends CanvasLayer


# Called every frame. 'delta' is the elapsed time since the previous frame.
func _process(delta):
	$hlthStmn/stmn.value = $"/root/playerObject".stmn
	$hlthStmn/hlth.value = $"/root/playerObject".hlth
	$xpMoneyAmmo/XP.text = str($"/root/playerObject".xp)
	$xpMoneyAmmo/Money.text = str($"/root/playerObject".money)
	$xpMoneyAmmo/ammo.text = str($"/root/playerObject".ammo)
	