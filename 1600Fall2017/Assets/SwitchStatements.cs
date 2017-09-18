using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponsSwitch : MonoBehaviour {
    public string[] weapons;
    public void MyWeaponSwitch (int i)
    {
        switch (weapons[i])
        {
            case "Rhino":
                print("Rhino");
                break;

            case "1911-A1":
                print("1911-A1");
                break;

			case "1860 Army":
                print("1860 Army");
                break;

			case "Rough Rider .22":
                print("Rough Rider .22");
                break;	

			case "870":
                print("870");
                break;

			case "1887":
                print("1887");
                break;

			case "M91/30":
                print("M91/30");
                break;

			case "C39V2":
                print("C39V2");
                break;

			case "AA-15":
                print("AA-15");
                break;

			case "CPX-2":
                print("CPX-2");
                break;

            default:
                print("You have no other weapons.");
                break;
        }   
    }
}

