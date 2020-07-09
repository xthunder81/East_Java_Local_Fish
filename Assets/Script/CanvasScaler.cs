using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasScaler : MonoBehaviour
{

    public float resX;
    public float resY;

    private CanvasScaler canvas;
    // Start is called before the first frame update
    void Start()
    {
        canvas = GetComponent<CanvasScaler>();
        SetInfo();
    }

    void SetInfo()
    {
        //Get Current Resolution
        resX = (float)Screen.currentResolution.width;
        resY = (float)Screen.currentResolution.height;


    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
