using UnityEngine;

public class EnemyBehaviour : MonoBehaviour{


    public float frequency = 1.0f;
    public float magnitude = 5.5f;
    public float downwardSpeed = 0.05f;

    private Vector3 startPos;
    private float timeCounter = 0;

    void Start() {
        startPos = transform.position;
    }

    void Update() {
        timeCounter += Time.deltaTime * frequency;

        float x = Mathf.Sin(timeCounter) * magnitude;
        float y = startPos.y - downwardSpeed * Time.time;

        transform.position = new Vector3(startPos.x + x, y, transform.position.z);
    }

    void OnCollisionEnter2D(Collision2D collision){
        BulletBehaviour bullet = collision.gameObject.GetComponent<BulletBehaviour>();

        if(bullet != null){
            bullet.SelfDestruct();
            Destroy(gameObject);
        }
    }
}
