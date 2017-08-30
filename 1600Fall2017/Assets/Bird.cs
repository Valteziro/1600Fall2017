using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : Animal {

    public override void Start ()
    {
        base.Start();
        Fly();
    }

    //This makes birds fly
    void Fly ()
    {
        print(this.name + " flies");
    }
}
