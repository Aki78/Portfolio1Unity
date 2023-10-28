using UnityEngine;

public class ShootCircle : MonoBehaviour{

    public GameObject bulletPrefab;
    public float shootSpeed = 10f;

    void Update(){
        if (Input.GetKeyDown(KeyCode.Space)){
            Shoot();
        }
    }

    void Shoot(){
    
        if (bulletPrefab){
        
            GameObject bulletInstance = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            Rigidbody2D rb = bulletInstance.GetComponent<Rigidbody2D>();
            
            if (rb){
            
                rb.velocity = Vector2.up * shootSpeed;
                
            }
        }
    }
}

