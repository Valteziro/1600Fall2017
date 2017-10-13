using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aminals : MonoBehaviour
{
    public string[] FoxFood = { "Bananas", "Apples", "Grapes", "Chicken", "Turkey", "Cake"};
    public int[] FoodCount = { 10, 2, 30, 1, 2, 1};

    public virtual void Start()
    {
        for (int i = 0; i < FoxFood.Length; i++)
        {
            Eat(FoxFood[i], FoodCount[i]);
        }
        Sleep();
    }
    void Eat(string food, int amount)
    {
        print(this.name + " likes to eat " + food);
        print(this.name + " ate " + amount);
    }
    void Sleep()
    {
        print(this.name + " sleeps");
    }        
}