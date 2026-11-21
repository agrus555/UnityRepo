using UnityEngine;

public class DamageScript : MonoBehaviour
{
    int CHP = 100;
    public GameObject effectDead;

    internal void takeDamage(int howMuchDamage)
    {
        CHP -= howMuchDamage;

        Debug.Log("HP: " + CHP);

        if (CHP <= 0)
        {
            Instantiate(effectDead, transform.position, Quaternion.identity);

            Destroy(gameObject);
            Debug.Log("Died");
        }

        
    }

}
