using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameOverController : MonoBehaviour {

    private float delay = 5.0f;

    void Start() {
        StartCoroutine(GoToMainMenuAfterDelay());
    }

    IEnumerator GoToMainMenuAfterDelay() {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene("MainMenu");
    }
}

