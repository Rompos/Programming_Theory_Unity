using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawner : MonoBehaviour
{
    public GameObject clonePrefab; 
    void Start()
    {
        if (MainManager.Instance.carGameObject != null)
        {
            
            GameObject carToInstantiate = MainManager.Instance.carGameObject;
            carToInstantiate.SetActive(true);
            Instantiate(carToInstantiate, carToInstantiate.transform.position, carToInstantiate.transform.rotation);
            clonePrefab = carToInstantiate;
        }
    }
}
