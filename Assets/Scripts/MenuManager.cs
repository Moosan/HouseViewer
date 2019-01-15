using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour {
    public static MenuManager menuManager;
    private bool isOpen = false;
    public GameObject MenuPanel;
    public GameObject Laser;
    public GameObject Teleprter;
    public GameObject LODPanel;

    private void Awake()
    {
        menuManager = this;
    }
    void Update () {
        if (GvrControllerInput.AppButtonDown)
        {
            if (isOpen)
            {
                MenuClose();
                isOpen = false;
            }
            else
            {
                MenuOpen();
                isOpen = true;
            }
        }
	}
    public void MenuOpen()
    {
        LODPanel.SetActive(false);
        MenuPanel.SetActive(true);
        Laser.SetActive(true);
        Teleprter.SetActive(false);
    }
    public void MenuClose()
    {
        LODPanel.SetActive(true);
        MenuPanel.SetActive(false);
        Laser.SetActive(false);
        Teleprter.SetActive(true);
        isOpen = false;
    }
}
