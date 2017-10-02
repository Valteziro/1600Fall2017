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
<<<<<<< HEAD
			print("Condition 4 is False.");
=======
			print("Condition 1 is False.");
>>>>>>> master
		}

		if (IsTrue || IsFalse)
		{
<<<<<<< HEAD
			print("Condition 5 is True.");
=======
			print("Condition 2 is True.");
>>>>>>> master
		}

		if (!(IsTrue && IsFalse))
		{
<<<<<<< HEAD
			print("Condition 6 is True.");
=======
			print("Condition 3 is True.");
>>>>>>> master
		}

		bool Sierra = true;
		bool Gumbo = false;

		if (Sierra && Gumbo)
		{
<<<<<<< HEAD
			print("Condition 7 is False.");
=======
			print("Condition 1 is False.");
>>>>>>> master
		}

		if (Sierra || Gumbo)
		{
<<<<<<< HEAD
			print("Condition 8 is True.");
=======
			print("Condition 2 is True.");
>>>>>>> master
		}

		if (!(Sierra && Gumbo))
		{
<<<<<<< HEAD
			print("Condition 9 is True.");
=======
			print("Condition 3 is True.");
>>>>>>> master
		}

		bool IsAlwaysTrue = true;
		bool IsAlsoAlwaysTrue = true;

		if (!(IsAlwaysTrue && IsAlsoAlwaysTrue))
		{
<<<<<<< HEAD
			print("Condition 10 is False.");
=======
			print("Condition 3 is False.");
>>>>>>> master
		}
	}
}
