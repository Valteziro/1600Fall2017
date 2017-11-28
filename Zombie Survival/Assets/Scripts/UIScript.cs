using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    public static bool gameOver = false;
    public Image bar;
    public GameObject gameOverUI;
    public float powerLevel = 0.1f;
    public float amountToAdd = 0.01f;   
	public PowerUpType DamageOrHeal;
    //Lists all "PowerUpTypes"
    public enum PowerUpType	
    {
        Healthkit,
        EnemyAttack
    }
    void OnTriggerEnter(Collider other)
    {
        //lists both "Healthkit" and "EnemyAttack" under a drop down menu in Unity's inspector.
        switch (DamageOrHeal)
        {
            //lists type of "DamageOrHeal" "Healthkit"
            case PowerUpType.Healthkit:
                StartCoroutine(HealthKitBar());
                break;

            //lists type of "DamageOrHeal" "EnemyAttack"
            case PowerUpType.EnemyAttack:
                StartCoroutine(EnemyAttackBar());
                break;
        }        
    }
    IEnumerator HealthKitBar()
    {
        //makes type "HealthKitBar" add health from the health bar.
        float tempAmount = bar.fillAmount + powerLevel;
        //checks to see if the health bar is over 100%
        if (tempAmount > 1)
        {
            //sets the health bar to 100% if the statement comes back true, stops the health bar from going over 100%.
            tempAmount = 1;
        }

        //checks to see if the amount added is greater than the bar fill amount.
        while (bar.fillAmount < tempAmount)
        {
            //adds to the health bar when the while statement is true.
            bar.fillAmount += amountToAdd;
            //adds a debounce to the amount to add.
            yield return new WaitForSeconds(amountToAdd);
        }
    }
    IEnumerator EnemyAttackBar()
    {
        //makes type "EnemyAttackBar" subtract health from the health bar.
        float tempAmount = bar.fillAmount - powerLevel;
        //checks to see if the health bar is over 0%
        if (tempAmount < 0)
        {
            //sets the health bar to 0% if the statement comes back true, stops the health bar from going under 0%.
            tempAmount = 0;
        }

        //checks to see if the amount added is less than the bar fill amount.
        while (bar.fillAmount > tempAmount)
        {
            //subtracts from the health bar when the while statement is true.
            bar.fillAmount -= amountToAdd;
            //adds a debounce to the amount to subtract.
            yield return new WaitForSeconds(amountToAdd);
        }
        
        //checks to see if the health bar is at 0%
        if (bar.fillAmount == 0)
        {
            //sets the gameOverUI to active if the health bar reaches 0%
            gameOverUI.SetActive(true);
            //when gameOver is true, sends PlayerController a gameOver = true message.
            PlayerController.gameOver = true;
        }
    }
}