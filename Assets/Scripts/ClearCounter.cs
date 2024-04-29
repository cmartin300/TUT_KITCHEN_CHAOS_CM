using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearCounter : MonoBehaviour
{

    [SerializeField] private KitchenObjectSO spawnObject;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private ClearCounter secondClearCounter;
    [SerializeField] private bool testing;

    private KitchenObject kitchenObject;

    private void Update()
    {
        if (testing && Input.GetKeyDown(KeyCode.T))
        {
            if (kitchenObject != null)
            {
                kitchenObject.SetClearCounter(secondClearCounter);
            }
        }
    }

    public void Interact()
    {
        if (kitchenObject == null)
        {
            Transform objectTransform = Instantiate(spawnObject.prefab, spawnPoint);
            objectTransform.GetComponent<KitchenObject>().SetClearCounter(this);
        }
        else
        {
            Debug.Log(kitchenObject.GetKitchenObjectSO().objectName + " on " + kitchenObject.GetClearCounter());
        }

    }

    public Transform GetKitchenObjectFollowTransform()
    {
        return spawnPoint;
    }

    public void SetKitchenObject(KitchenObject kitchenObject)
    {
        this.kitchenObject = kitchenObject;
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
