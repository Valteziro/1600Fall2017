﻿using System.Collections;
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
	public PowerUpType powerUp; 

    public enum PowerUpType
	
    {
        PowerUp,
        PowerDown
    }

    void OnTriggerEnter(Collider other)
    {
        switch (powerUp)
        {
            case PowerUpType.PowerUp:
                StartCoroutine(PowerUpBar());
                break;

            case PowerUpType.PowerDown:
                StartCoroutine(PowerDownBar());
                break;
        }      
        
    }
    IEnumerator PowerUpBar()
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
    IEnumerator PowerDownBar()
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