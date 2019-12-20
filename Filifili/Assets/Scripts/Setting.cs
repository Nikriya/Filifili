using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Setting : MonoBehaviour
{
    Text persenTeks;
    

    Resolution[] resolutions;
    // Start is called before the first frame update
    void Start()
    {
        persenTeks = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void Volume (float value){
        persenTeks.text = Mathf.RoundToInt(value * 100) + "%";
    }
}
