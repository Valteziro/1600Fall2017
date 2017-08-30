using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mammal : Animal {


    public override void Start()
    {
        base.Start();
        GiveLiveBirth();
    }

    void GiveLiveBirth()
    {

        print(this.name + " gives live birth");

    }
}
