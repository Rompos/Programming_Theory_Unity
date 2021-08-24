using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class CarSelector : MonoBehaviour
{
    
    public GameObject selectedCar;
    public GameObject[] carPrefabs = new GameObject[3];//depending the number of cars we want in the scene we make it dynamic or static 
    public GameObject[] carShow;
    public int index;

    void Awake()
    {
        Scene scene = SceneManager.GetActiveScene();
        Debug.Log("Awake:" + SceneManager.GetActiveScene().name);

        index = 0;
        //carPrefabs = new GameObject[transform.childCount];//dynamic list/array
        carShow = new GameObject[transform.childCount];//dynamic list/array

        ////fill the array with our models
        //for (int i = 0; i < transform.childCount; i++)
        //{
        //    carPrefabs[i] = transform.GetChild(i).gameObject;// GetChild returns gameObject

        //    //carPrefabs[i].SetActive(true);//turn all the renderers of the cars on
        //}

        //fill the array with our models
        for (int i = 0; i < transform.childCount; i++)
        {
            carShow[i] = transform.GetChild(i).gameObject;// GetChild returns gameObject

        }


        //we toggle off their renderer
        foreach (GameObject go in carShow)
        {
            go.SetActive(false);
        }

        //we toggle on the Selected car index renderer
        if (carShow[index])
        {
            carShow[index].SetActive(true);
        }
    }


    void Start()
    {

        //selectedCar = carPrefabs[index];//we initiate the gameObject prefab car
        MainManager.Instance.carGameObject = carPrefabs[index];//we initiate the gameObject prefab car
    }

    public void ToggleLeft()
    {
        //Toggle off the current model
        //carPrefabs[index].SetActive(false);
        carShow[index].SetActive(false);

        index--;//  index-=1;  index=index-1;
        if (index < 0)//check to see if we are out of bounds with the array
        {
            index = carPrefabs.Length - 1;
        }

        //Toggle on the new model
        //carPrefabs[index].SetActive(true);
        carShow[index].SetActive(true);

        selectedCar = carPrefabs[index];
        MainManager.Instance.carGameObject = selectedCar;
    }

    public void ToggleRight()
    {
        //Toggle off the current model
        //carPrefabs[index].SetActive(false);
        carShow[index].SetActive(false);

        index++;//  index+=1;  index=index+1;
        if (index == carPrefabs.Length)//check to see if we are out of bounds with the array
        {
            index = 0;
        }

        //Toggle on the new model
        //carPrefabs[index].SetActive(true);
        carShow[index].SetActive(true);

        selectedCar = carPrefabs[index];
        MainManager.Instance.carGameObject = selectedCar;
    }

    //private void Update()
    //{
    //    if (selectedCar != MainManager.Instance.carGameObject)
    //    {
    //        selectedCar = MainManager.Instance.carGameObject;
    //        //ChangeCar();

    //    }
    //}

    //private void ConfirmButton(int number)// ABSTRACTION Main
    //{

    //    //selectedCar = carPrefabs[number];
    //    MainManager.Instance.carGameObject = carPrefabs[number];
    //    //ChangeCar();
    //    SceneManager.LoadScene(2);//i have the same line of code in CarUIHandle script in the canvas confirm button
    //}

    //void ChangeCar()
    //{
    //    MainManager.Instance.ChangeCar(selectedCar);
    //}

    //public void Submit()// ABSTRACTION run
    //{
    //    if (carPrefabs[0])
    //    {
    //        ConfirmButton(0);
    //    }
    //    else if (carPrefabs[1])
    //    {
    //        ConfirmButton(1);
    //    }
    //    else if (carPrefabs[2])
    //    {
    //        ConfirmButton(2);
    //    }
    //    else
    //    {
    //        ConfirmButton(3);
    //    }
    //}

    //public void RedCar()
    //{
    //    SelectCar(0);
    //}
    //public void BlueCar()
    //{
    //    SelectCar(1);
    //}
    //public void GrayCar()
    //{
    //    SelectCar(2);
    //}
    //public void YellowCar()
    //{
    //    SelectCar(3);
    //}

    //public void SelectCar(int carIndex) // Abstraction
    //{
    //    selectedCar = carPrefabs[carIndex];
    //    MainManager.Instance.carGameObject = selectedCar;
    //    SceneManager.LoadScene(2);
    //}
}
