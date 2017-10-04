using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopeAndAccess : MonoBehaviour
{
    //These can be called anywhere as they are in scope.
    private int health = 100;

    public int score = 100;

    private void Start()
    {
        //These cannot be called anywhere as they are in brackets.
        int NewScore = 10;
        print(NewScore);
    }


}
