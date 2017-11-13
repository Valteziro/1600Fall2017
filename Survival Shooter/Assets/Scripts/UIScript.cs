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
	public PowerUpType Healthkit; 

    public enum PowerUpType
	
    {
        Healthkit,
        EnemyAttack
    }

    void OnTriggerEnter(Collider other)
    {
        switch (Healthkit)
        {
            case PowerUpType.Healthkit:
                StartCoroutine(HealthKitBar());
                break;

            case PowerUpType.EnemyAttack:
                StartCoroutine(EnemyAttackBar());
                break;
        }      
        
    }
    IEnumerator HealthKitBar()
    {
        float tempAmount = bar.fillAmount + powerLevel;
        if (tempAmount > 1)
        {
            tempAmount = 1;
        }

        while (bar.fillAmount < tempAmount)
        {
            bar.fillAmount += amountToAdd;
            yield return new WaitForSeconds(amountToAdd);
        }
    }
    IEnumerator EnemyAttackBar()
    {

        float tempAmount = bar.fillAmount - powerLevel;
        if (tempAmount < 0)
        {
            tempAmount = 0;
        }

        while (bar.fillAmount > tempAmount)
        {
            bar.fillAmount -= amountToAdd;
            yield return new WaitForSeconds(amountToAdd);
        }

        if (bar.fillAmount == 0)
        {
            gameOverUI.SetActive(true);
            CharacterController.gameOver = false;
        }
    }
}