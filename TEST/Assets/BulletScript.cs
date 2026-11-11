using UnityEngine;

public class BulletScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    float speed = 4f;
    // Update is called once per frame
    void Update()
    {
        transform.position += (transform.up * speed * Time.deltaTime);
    }
}
