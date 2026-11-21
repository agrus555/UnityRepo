using UnityEngine;

public class BulletScript : MonoBehaviour
{
    float speed = 4f;

    void Update()
    {
        transform.position += transform.up * speed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Ouch");

        DamageScript possibleVictim =
            collision.transform.GetComponent<DamageScript>();

        if (possibleVictim)
        {
            possibleVictim.takeDamage(25);
            Destroy(gameObject);
        }
    }
}