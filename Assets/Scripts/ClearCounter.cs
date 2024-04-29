using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearCounter : MonoBehaviour
{

    [SerializeField] private KitchenObjectSO spawnObject;
    [SerializeField] private Transform spawnPoint;

    private KitchenObject kitchenObject;

    public void Interact()
    {
        if (kitchenObject == null)
        {
            Transform objectTransform = Instantiate(spawnObject.prefab, spawnPoint);
            objectTransform.localPosition = Vector3.zero;

            kitchenObject = objectTransform.GetComponent<KitchenObject>();
        }

    }
}
