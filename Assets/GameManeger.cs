using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManeger : MonoBehaviour
{
    public GameObject[] PiedraPapelTijera;
    // Start is called before the first frame update
    void Start()
    {
        //Invocar la activacion random cada 2 segundos
        InvokeRepeating(nameof(ActivateRandomElement),0, 2f);
    }
   
    
    //funcion que desactiva todos los elementos del array
    void DeactiveAll()
    {
        for (int i = 0; i< PiedraPapelTijera.Length; i++)
        {
            PiedraPapelTijera[i].SetActive(false);
        }
        //for
    }
    //funcion que activa un elemento al azar del array
    void ActivateRandomElement()
    {
        DeactiveAll();
        int randomIndex = Random.Range(0, PiedraPapelTijera.Length);
        PiedraPapelTijera[randomIndex].SetActive(true);
        //activar elemento al azar
    }
}
