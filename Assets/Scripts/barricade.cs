using UnityEngine;
using UnityEngine.SceneManagement;

public class BarricadeBehaviour : MonoBehaviour{

    void OnCollisionEnter2D(Collision2D collision){
    
//    if (collision.gameObject.name.Contains("Enemy")){
//        SceneManager.LoadScene("GameOver");
//    }
        BulletBehaviour bullet = collision.gameObject.GetComponent<BulletBehaviour>();

        if(bullet != null){
            bullet.SelfDestruct();
        }
    }
}

