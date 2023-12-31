using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour{

    public void PlayGame(){
        SceneManager.LoadScene("SampleScene");
    }

    public void ExitGame(){
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}

