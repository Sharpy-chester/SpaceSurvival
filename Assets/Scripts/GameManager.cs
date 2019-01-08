using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public bool allowMovement = true;
    public bool showInv = false;
    public GameObject inventoryGO;
    public GameObject[] slots;
    

    void Awake()
    {
        slots = GameObject.FindGameObjectsWithTag("Slot");
        inventoryGO.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            allowMovement = !allowMovement;
            showInv = !showInv;
            if (showInv)
            {
                ShowInventory();
            }
            else
            {
                HideInventory();
            }
        }
        
    }

    void ShowInventory ()
    {
        Time.timeScale = 0;
        inventoryGO.SetActive(true);
    }
    void HideInventory()
    {
        Time.timeScale = 1;
        inventoryGO.SetActive(false);
    }

    void InventoryManager()
    {

    }
    
}
