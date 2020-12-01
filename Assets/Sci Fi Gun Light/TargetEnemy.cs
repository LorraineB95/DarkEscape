
using UnityEngine;

public class TargetEnemy : MonoBehaviour
{
    public int health = 50;

    public void TakeDamage (int damage)
    {
        health -= damage;
        if(health <= 0f)
        {
            Destroy(gameObject);
        }
    }
   
}
