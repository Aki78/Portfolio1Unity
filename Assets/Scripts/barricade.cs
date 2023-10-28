using UnityEngine;

public class BarricadeBehaviour : MonoBehaviour{

    void OnCollisionEnter2D(Collision2D collision){
        BulletBehaviour bullet = collision.gameObject.GetComponent<BulletBehaviour>();

        if(bullet != null){
            bullet.SelfDestruct();
        }
    }
}

