using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadVehicle : MonoBehaviour
{

    public GameObject[] vehiclePrefabs;
    public Transform spawPoint;
    

    // Start is called before the first frame update
    void Start()
    {
        int selectedVehicle = PlayerPrefs.GetInt("selectedVehicle");
        GameObject prefab = vehiclePrefabs[selectedVehicle];
        GameObject clone = Instantiate(prefab, spawPoint.position, Quaternion.identity);
        
    }

   
}
