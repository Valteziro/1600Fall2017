using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Void : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		Shoot();
		Reload();
		Melee();
		Jump();
		DropDown();
		HopUp();
		Crouch();
		Drop();
		PickUp();
		ThrowGrenade();
	}
	void Shoot()
	{
		print(this.name + " shoots the weapon.");
	}
	void Reload()
	{
		print(this.name + " reloads the weapon.");
	}
	void Melee()
	{
		print(this.name + " melees.");
	}
	void Jump()
	{
		print(this.name + " jumps.");
	}
	void DropDown()
	{
		print(this.name + " drops down a level.");
	}
	void HopUp()
	{
		print(this.name + " hops up a level.");
	}
	void Crouch()
	{
		print(this.name + " crouches.");
	}
	void Drop()
	{
		print(this.name + " drops the weapon.");
	}
	void PickUp()
	{
		print(this.name + " picks up the weapon.");
	}
    void ThrowGrenade()
    {
        print(this.name + " throws a grenade.");
    }
}
