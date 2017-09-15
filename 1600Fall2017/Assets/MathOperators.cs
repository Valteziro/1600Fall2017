using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathOperators : MonoBehaviour {

    public float num1;
    public float num2;
    public float num3;
    public float num4;
    public float addResult;
    public float addResult2;
    public float subResult;
    public float subResult2;
    public float multResult;
    public float multResult2;
    public float divResult;
    public float divResult2;
    public float remainderResult;
    public float remainderResult2;
	
	// Update is called once per frame
	void Update ()
    {
        // This adds num1 and num2 and gives you the answer.
        addResult = num1 + num2;
        addResult2 = num3 + num4;

        
        // This subtracts num2 from num1 and gives you the answer.
        subResult = num1 - num2;
        subResult2 = num3 - num4;
        
        // This multiplies num1 and num2 and gives you the answer.
        multResult = num1 * num2;
        multResult = num3 * num4;
        
        // This checks the number to make sure neither is 0.
        if (num1 != 0 && num2 != 0)
        if (num3 != 0 && num4 != 0)
        {
            // This divides num1 by num2 and gives you the answer.
            divResult = num1 / num2;
            divResult2 = num3 / num4;
        }
        else
        {
            // This is the answer you get if either num1 or num2 is 0.
            print("Can't Divide By 0");
        }
        
        // This checks the number to make sure neither is 0.
        if (num1 != 0 && num2 != 0)
        if (num3 != 0 && num4 != 0)
        {
            // This divides num1 by num2 and gives you the remainder.
            remainderResult = num1 % num2;
            remainderResult2 = num3 % num4;
        }
        else
        {
            print("Can't Divide By 0");
        }
	}
}
