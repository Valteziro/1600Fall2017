using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchStatements : MonoBehaviour {
    public string[] weapons;
    public void MyWeaponSwitch (int i)
    {
        switch (weapons[i])
        {
            case "Rhino":
                print("Rhino equipped");
                break;

            case "1911-A1":
                print("1911-A1 equipped");
                break;

			case "1860 Army":
                print("1860 Army equipped");
                break;

			case "Rough Rider .22":
                print("Rough Rider .22 equipped");
                break;	

			case "870":
                print("870 equipped");
                break;

			case "1887":
                print("1887 equipped");
                break;

			case "M91/30":
                print("M91/30 equipped");
                break;

			case "C39V2":
                print("C39V2 equipped");
                break;

			case "AA-15":
                print("AA-15 equipped");
                break;

			case "CPX-2":
                print("CPX-2 equipped");
                break;

            default:
                print("You have no other weapons.");
                break;
        }   
    }
}

