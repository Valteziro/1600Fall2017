using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class LogicalOperators : MonoBehaviour 
{	// Use this for initialization
	static void Main(string[] args)
	{
		bool a = true;
		bool b = false;

		if (a && b)
		{
			print("Condition 1 is False.");
		}

		if (a || b)
		{
			print("Condition 2 is True.");
		}

		if (!(a && b))
		{
			print("Condition 3 is True.");
		}

		bool IsTrue = true;
		bool IsFalse = false;

		if (IsTrue && IsFalse)
		{
			print("Condition 1 is False.");
		}

		if (IsTrue || IsFalse)
		{
			print("Condition 2 is True.");
		}

		if (!(IsTrue && IsFalse))
		{
			print("Condition 3 is True.");
		}

		bool Sierra = true;
		bool Gumbo = false;

		if (Sierra && Gumbo)
		{
			print("Condition 1 is False.");
		}

		if (Sierra || Gumbo)
		{
			print("Condition 2 is True.");
		}

		if (!(Sierra && Gumbo))
		{
			print("Condition 3 is True.");
		}

		bool IsAlwaysTrue = true;
		bool IsAlsoAlwaysTrue = true;

		if (!(IsAlwaysTrue && IsAlsoAlwaysTrue))
		{
			print("Condition 3 is False.");
		}
	}
}
