using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoop : MonoBehaviour
{
    int numCats = 2;
    int numDogs = 3;
    int numHamsters = 2;
    int numRats = 3;
    int numSnakes = 2;
    int numSpiders = 3;
    int numBirds = 2;
    int numLizards = 3;
    int numFishes = 2;
    int numRocks = 3;

    void Start()
    {
        for (int p = 0; p < numCats; p++)
        {
            print("Buying cat number: " + p);
        }

        for (int p = 0; p < numDogs; p++)
        {
            print("Buying dog number: " + p);
        }

        for (int p = 0; p < numHamsters; p++)
        {
            print("Buying hamster number: " + p);
        }

        for (int p = 0; p < numRats; p++)
        {
            print("Buying rat number: " + p);
        }

        for (int p = 0; p < numSnakes; p++)
        {
            print("Buying snake number: " + p);
        }

        for (int p = 0; p < numSpiders; p++)
        {
            print("Buying spider number: " + p);
        }

        for (int p = 0; p < numBirds; p++)
        {
            print("Buying bird number: " + p);
        }

        for (int p = 0; p < numLizards; p++)
        {
            print("Buying lizard number: " + p);
        }

        for (int p = 0; p < numFishes; p++)
        {
            print("Buying fish number: " + p);
        }

        for (int p = 0; p < numRocks; p++)
        {
            print("Buying rock number: " + p);
        }   
    }    
}

