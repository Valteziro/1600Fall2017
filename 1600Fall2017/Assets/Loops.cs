using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour {
    public string[] pickups;

    public bool CanPlay = true;
    public bool CantPlay;
    public bool WillPlay;
    public bool WontPlay;
    public bool WantToPlay;
    public bool DontWantToPlay;
    public bool WouldLikeToPlay;
    public bool WouldntLikeToPlay;
    public bool NeverPlay;
    public bool AlwaysPlay;    

    void Start()
    {
        StartCoroutine(PlayGame());
    }

    IEnumerator PlayGame ()
    {
        while (CanPlay)
        {
            print("Playing");
            yield return new WaitForSeconds(0.1f);
        }
        print("End Game");

        while (CantPlay)
        {
            print("Can't Play");
            yield return new WaitForSeconds(0.1f);
        }
        print("End Game");

        while (WillPlay)
        {
            print("Will Play");
            yield return new WaitForSeconds(0.1f);
        }
        print("End Game");

        while (WontPlay)
        {
            print("Won't Play");
            yield return new WaitForSeconds(0.1f);
        }
        print("End Game");

        while (WantToPlay)
        {
            print("Want To Play");
            yield return new WaitForSeconds(0.1f);
        }
        print("End Game");

        while (DontWantToPlay)
        {
            print("Don't Want To Play");
            yield return new WaitForSeconds(0.1f);
        }
        print("End Game");

        while (WouldLikeToPlay)
        {
            print("Would Like To Play");
            yield return new WaitForSeconds(0.1f);
        }
        print("End Game");

        while (WouldntLikeToPlay)
        {
            print("Wouldn't Like To Play");
            yield return new WaitForSeconds(0.1f);
        }
        print("End Game");

        while (NeverPlay)
        {
            print("Never Play");
            yield return new WaitForSeconds(0.1f);
        }
        print("End Game");

        while (AlwaysPlay)
        {
            print("Always Play");
            yield return new WaitForSeconds(0.1f);
        }
        print("End Game");
    }
}
