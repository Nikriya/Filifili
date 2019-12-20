using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour
{
    // waktu delay untuk load scene
   [SerializeField] private float delayLoading = 10f;
   
   // nama scene untuk pindah scene yang diinputkan pada Inspector
   [SerializeField] private string namaScene;
 
    private float timeElapsed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime;
        
        if (timeElapsed > delayLoading) {
            SceneManager.LoadScene(namaScene);
        }
    }
}
