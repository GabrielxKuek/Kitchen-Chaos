﻿using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCounter : MonoBehaviour, IKitchenObjectParent
{
    public static event EventHandler OnAnyObjectPlacedHere;

    [SerializeField] private Transform counterTopPoint;

    private KitchenObject kitchenObject;

    public static void ResetStaticData()
    {
        OnAnyObjectPlacedHere = null;
    }

    public virtual void Interact(Player player)
    {
        Debug.LogError("BaseCounter.Interact(); This is child abuse.");
    }
    public virtual void InteractAlternate(Player player)
    {
        // Debug.LogError("BaseCounter.InteractAlternate(); This is child abuse.");
    }

    public Transform GetKitchenObjectFollowTransform()
    {
        return counterTopPoint;
    }

    public void SetKitchenObject(KitchenObject kitchenObject)
    {
        this.kitchenObject = kitchenObject;

        if (kitchenObject != null)
        {
            OnAnyObjectPlacedHere?.Invoke(this, EventArgs.Empty);
        }
    }

    public KitchenObject GetKitchenObject()
    {
        return kitchenObject;
    }

    public void ClearKitchenObject()
    {
        kitchenObject = null;
    }

    public bool HasKitchenObject()
    {
        return kitchenObject != null;
    }
}