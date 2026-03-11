using Unity.VisualScripting;
using UnityEngine;

public class InteractionSystem : MonoBehaviour
{
    [SerializeField] private HealthSystem healthSystem;
    [SerializeField] private string obstacleTag = "Obstacle";

    void Start()
    {
        healthSystem = GetComponent<HealthSystem>();

        if (healthSystem == null)
        {
            Debug.LogError("HealthSystem reference is not assigned in InteractionSystem!");
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        var otherGameObject = other.gameObject;

        if (otherGameObject.CompareTag(obstacleTag))
        {
            var damageAmount = otherGameObject.GetComponent<EnemyAttack>()?.DamageAmount ?? 0;
            healthSystem.TakeDamage(damageAmount);
            Destroy(otherGameObject);
        }
    }

}
