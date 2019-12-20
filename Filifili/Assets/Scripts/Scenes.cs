using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
    // Start is called before the first frame update
    public void MenuScene() {
       SceneManager.LoadScene("Menu");
   }
 
   // pindah scene ke loading
   public void LoadingScene() {
       SceneManager.LoadScene("Loading");
       Data.score = 0;
   }
 
   // keluar dari game
   public void KeluarScene() {
       Application.Quit();
   }
}
