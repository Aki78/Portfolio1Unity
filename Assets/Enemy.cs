using UnityEngine;

public class EnemyBehaviour : MonoBehaviour{

    void OnCollisionEnter2D(Collision2D collision){
        BulletBehaviour bullet = collision.gameObject.GetComponent<BulletBehaviour>();

        if(bullet != null){
            bullet.SelfDestruct();
            Destroy(gameObject);
        }
    }
}
