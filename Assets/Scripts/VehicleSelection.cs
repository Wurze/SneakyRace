
using UnityEngine;
using UnityEngine.SceneManagement;

public class VehicleSelection : MonoBehaviour
{

    public GameObject[] vehicles;
    public int selectedVehicle = 0 ;
    

  
    public void NextVehicle()
    {
        vehicles[selectedVehicle].SetActive(false);
        selectedVehicle = (selectedVehicle + 1) % vehicles.Length;
        vehicles[selectedVehicle].SetActive(true);
    }

    public void PreviousVehicle()
    {
        vehicles[selectedVehicle].SetActive(false);
        selectedVehicle--;
        if(selectedVehicle < 0)
        {
            selectedVehicle += vehicles.Length;

        }
        vehicles[selectedVehicle].SetActive(true);
    }


    public void PickVehicle1()
    {
        PlayerPrefs.SetInt("selectedVehicle1", selectedVehicle);
    }

    public void PickVehicle2()
    {
        PlayerPrefs.SetInt("selectedVehicle2", selectedVehicle);
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }


    public void StartGame()
    {
        
        SceneManager.LoadScene(1, LoadSceneMode.Single);

    }

   
}
