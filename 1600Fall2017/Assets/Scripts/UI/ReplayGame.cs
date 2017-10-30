using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReplayGame : MonoBehaviour
{
    public Transform player;
    public UIHealth HealthBar;
    public GameObject GameOverUI;
    public static Vector3 StartPosition;
    private float FillAmount;

    private void Start()
    {
        StartPosition = player.position;
        FillAmount = HealthBar.bar.fillAmount;
        GameOverUI.SetActive(false);
    }

    public void Click ()
    {
        PlayerControl.gameOver = false;
        player.position = StartPosition;
        HealthBar.bar.fillAmount = FillAmount;
        GameOverUI.SetActive(false);
    }
}
