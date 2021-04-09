using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadVehicle : MonoBehaviour
{

    public GameObject[] vehiclePrefabs;
    public Transform spawPointPlayer1;
    public Transform spawPointPlayer2;
    

    // Start is called before the first frame update
    void Start()
    {
        int selectedVehicle1 = PlayerPrefs.GetInt("selectedVehicle1");

        int selectedVehicle2 = PlayerPrefs.GetInt("selectedVehicle2");
        GameObject player1 = vehiclePrefabs[selectedVehicle1];
        GameObject player2 = vehiclePrefabs[selectedVehicle2];
        GameObject player1Clone = Instantiate(player1, spawPointPlayer1.position, Quaternion.identity);
        GameObject player2Clone = Instantiate(player2, spawPointPlayer2.position, Quaternion.identity);
        
    }

   
}
