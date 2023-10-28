using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ShootCircle : MonoBehaviour{

    public GameObject bulletPrefab;
    public float shootSpeed = 10f;
    public float moveSpeed = 5f;
    


    void Update(){
        if (Input.GetKeyDown(KeyCode.Space)){
            Shoot();
        }

        if (Input.GetKey(KeyCode.A)){
            Move(Vector2.left);
        } else if (Input.GetKey(KeyCode.D)){
            Move(Vector2.right);
        }
    }

void Shoot(){
    if (bulletPrefab){
        float yOffset = 1.5f; // Set this to whatever offset you want
        Vector3 spawnPosition = new Vector3(transform.position.x, transform.position.y + yOffset, transform.position.z);
        GameObject bulletInstance = Instantiate(bulletPrefab, spawnPosition, Quaternion.identity);
        Rigidbody2D rb = bulletInstance.GetComponent<Rigidbody2D>();
        
        if (rb){
            rb.velocity = Vector2.up * shootSpeed;
        }
    }
}

    void Move(Vector2 direction){
        transform.position += (Vector3)direction * moveSpeed * Time.deltaTime;
    }
    
    
    
    void OnCollisionEnterSpaceShip2D(Collision2D collision){
        BulletBehaviour bullet = collision.gameObject.GetComponent<BulletBehaviour>();

        if(bullet != null){
            bullet.SelfDestruct();
            Destroy(gameObject);
        SceneManager.LoadScene("GameOver");
        print("Got hit");

        }
        
    }
}

