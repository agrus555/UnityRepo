using UnityEngine;

public class GunScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public GameObject Bullet;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(Bullet, transform.position + transform.forward * 2.5f, transform.rotation * Quaternion.Euler(90, 0, 0));
        }
        
    }
}
