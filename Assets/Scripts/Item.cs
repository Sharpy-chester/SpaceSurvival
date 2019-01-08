﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Item : MonoBehaviour
{
    Vector3 startPos;
    string parentName;
    public bool followPointer;
    GameManager gameManager;
    public GraphicRaycaster graphicRaycaster;
    public EventSystem eventSystem;
    public Transform parent;

    private void Awake()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        startPos = this.transform.position;
        parentName = this.gameObject.GetComponentInParent<Transform>().name;
    }

    private void Update()
    {
        if (followPointer)
        {
            this.transform.position = Input.mousePosition;
        }
    }

    public void FollowPointer()
    {
        startPos = this.transform.position;
        followPointer = true;
    }
    public void GoToNextPos ()
    {
        this.transform.position = startPos;
        PointerEventData pointerEventData = new PointerEventData(eventSystem);
        pointerEventData.position = Input.mousePosition;
        List<RaycastResult> results = new List<RaycastResult>();
        graphicRaycaster.Raycast(pointerEventData, results);
        foreach (RaycastResult result in results)
        {
            if(result.gameObject.tag == "Slot" && result.gameObject.transform.childCount == 0)
            {
                this.transform.position = result.gameObject.transform.position;
                parent.parent = result.gameObject.transform;
            }
        } //Iterates through all UI items under mouse position. If one has the slot tag and has no children the item goes to that position (The slot under the mouse).
        followPointer = false;
        
    }
    public void GoToStartPos ()
    {
        followPointer = false;
        this.transform.position = startPos;
    }

    
}
