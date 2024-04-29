using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearCounter : MonoBehaviour
{

    [SerializeField] private KitchenObjectSO spawnObject;
    [SerializeField] private Transform spawnPoint;

    public void Interact()
    {
        Debug.Log($"Interact!");
        Transform objectTransform = Instantiate(spawnObject.prefab, spawnPoint);
        objectTransform.localPosition = Vector3.zero;

        Debug.Log(objectTransform.GetComponent<KitchenObject>().GetKitchenObjectSO().objectName);
    }
}
