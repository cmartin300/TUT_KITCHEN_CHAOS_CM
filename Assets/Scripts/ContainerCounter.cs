using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ContainerCounter : BaseCounter
{

    public event EventHandler OnPlayerGrabbedObject;

    [SerializeField] private KitchenObjectSO spawnObject;


    public override void Interact(Player player)
    {
        if (!HasKitchenObject())
        {
            Transform objectTransform = Instantiate(spawnObject.prefab);
            objectTransform.GetComponent<KitchenObject>().SetKitchenObjectParent(player);
            OnPlayerGrabbedObject?.Invoke(this, EventArgs.Empty);
        }

    }
}
