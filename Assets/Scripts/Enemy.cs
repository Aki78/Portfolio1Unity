using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class EnemyBehaviour : MonoBehaviour{


    public float frequency = 1.0f;
    public float magnitude = 5.5f;
    public float downwardSpeed = 0.05f;
    public GameObject bulletPrefab;
    public float shootSpeed = -10f;
    
    public float threshold = 1; // Change this to get a different probability of shooting mkay?

    private Vector3 startPos;
    private float timeCounter = 0;

    void Awake() {
        startPos = transform.position;
    }

    void Update() {
        timeCounter += Time.deltaTime * frequency;

        float x = Mathf.Sin(timeCounter) * magnitude;
        float y = startPos.y - downwardSpeed * Time.time;

        transform.position = new Vector3(startPos.x + x, y, transform.position.z);
        
        if (y < -1){
//                SceneManager.LoadScene("GameOver");
//                print(y);
        }
        
        float randomNumber = Random.Range(0, 5000);

        if (randomNumber < threshold){
            Shoot();
   //         print("Enemy Shooting");
        } 
    }

    void OnCollisionEnter2D(Collision2D collision){
        BulletBehaviour bullet = collision.gameObject.GetComponent<BulletBehaviour>();

        if(bullet != null){
            bullet.SelfDestruct();
            Destroy(gameObject);
            ScoreManager.instance.AddScore(10);

        }
        
    }
    
    
void Shoot(){
    if (bulletPrefab){
        float yOffset = -1.5f;
        Vector3 spawnPosition = new Vector3(transform.position.x, transform.position.y + yOffset, transform.position.z);
        GameObject bulletInstance = Instantiate(bulletPrefab, spawnPosition, Quaternion.identity);
        Rigidbody2D rb = bulletInstance.GetComponent<Rigidbody2D>();
        
        if (rb){
            rb.velocity = Vector2.up * shootSpeed;
        }
    }
}

    
}
