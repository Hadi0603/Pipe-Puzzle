using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject levelWonUI;
    [SerializeField] private GameObject winPanel;

    private void Awake()
    {
        levelWonUI.SetActive(false);
    }

    public void TriggerGameWon()
    {
        levelWonUI.SetActive(true);
        if (GameManager.levelToLoad < 5)
        {
            PlayerPrefs.SetInt("levelToLoad", ++GameManager.levelToLoad);
        }
        PlayerPrefs.Save();
    }
}
