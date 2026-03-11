using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;

public class HUDController : MonoBehaviour
{
    [SerializeField] private UnityEngine.UI.Image healthBarFill;
    [SerializeField] private HealthSystem healthSystem;

    [SerializeField] private GameObject deathScreen;

    void Start()
    {
        if (healthBarFill == null)
        {
            Debug.LogError("Health bar fill image is not assigned in HUDController!");
        }

        if (healthSystem == null)
        {
            Debug.LogError("HealthSystem reference is not assigned in HUDController!");
        }
    }

    public void UpdateHealthBar()
    {
        if (healthSystem == null || healthBarFill == null)
        {
            return;
        }

        float healthPercentage = (float)healthSystem.CurrentHealth / healthSystem.MaxHealth;
        healthBarFill.fillAmount = healthPercentage;
    }

    public void OnPlayerDeath()
    {
        Debug.Log("Player has died. You can implement additional logic here, such as showing a game over screen.");
        deathScreen.SetActive(true);

        Time.timeScale = 0f;
    }
}
