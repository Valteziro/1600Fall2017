using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHealth : MonoBehaviour
{
    public Image bar;
    public float barTime = 0.1f;
    public float PowerLevel = 0.1f;
    public float IncrementUp = 0.01f;

    public enum PowerUpType
    {
        PowerUp,
        PowerDown
    }
    public PowerUpType PowerUp;

    void OnTriggerEnter ()
    {
        switch (PowerUp)
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
        while (PowerLevel < 1)
        {
            bar.fillAmount += IncrementUp;
            yield return new WaitForSeconds(barTime);
        }
    }

    IEnumerator PowerDownBar()
    {
        float TempAmount = PowerLevel;
        float FillAmount = bar.fillAmount;
        while (PowerLevel > 0)
        {
            TempAmount -= IncrementUp;
            //FillAmount = TempAmount - IncrementUp;
            bar.fillAmount -= TempAmount;
            yield return new WaitForSeconds(barTime);
        }
    }
}
