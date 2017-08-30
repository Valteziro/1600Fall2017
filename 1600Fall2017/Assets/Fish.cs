using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : Animal {

    public override void Start() {
        base.Start();
        Swim();
    }

    //This makes fish swim
    void Swim() {

        print(this.name + " swims");

    }
}