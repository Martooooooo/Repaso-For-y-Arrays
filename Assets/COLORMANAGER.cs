using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class COLORMANAGER : MonoBehaviour
{
    public Color[] colores;
    public Renderer cubeRenderer;
    public int randomColorIndex;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(SetRandomColor),0,.5f);
    }

   void SetRandomColor()
    {
        randomColorIndex = Random.Range(0, colores.Length);
        cubeRenderer.material.color = colores[randomColorIndex];
    }

}
