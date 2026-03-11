using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField] private int damageAmount = 10;
    public int DamageAmount => damageAmount;
}
