using UnityEngine;

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
            GameObject bulletInstance = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            Rigidbody2D rb = bulletInstance.GetComponent<Rigidbody2D>();
            
            if (rb){
                rb.velocity = Vector2.up * shootSpeed;
            }
        }
    }

    void Move(Vector2 direction){
        transform.position += (Vector3)direction * moveSpeed * Time.deltaTime;
    }
}

