﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : Interactable
{

    [SerializeField]
    SpriteRenderer spriteRenderer;

    [SerializeField]
    Sprite openChestSprite;

    private void Awake()
    {
        base.Awake();
    }

    public override void Interact()
    {

        base.Interact();
        OpenChest();
        
    }

    void OpenChest()
    {
        ChangeGraphics();
        this.enabled = false;
    }

    void ChangeGraphics()
    {
        spriteRenderer.sprite = openChestSprite;
    }


    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, interactableRadius);
    }

}
