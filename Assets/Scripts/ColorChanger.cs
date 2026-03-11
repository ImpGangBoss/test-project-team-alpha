using UnityEngine;
using System.Collections.Generic;

public class ColorChanger : MonoBehaviour
{
    [SerializeField] private List<SpriteRenderer> spriteRenderers;

    void Start()
    {
        if (spriteRenderers == null || spriteRenderers.Count == 0)
        {
            Debug.LogError("No SpriteRenderers assigned to ColorChanger!");
            return;
        }
    }

    void Update() 
    {
        if (Input.GetMouseButtonDown(0))
        {
            ChangeColor();
        }
    }

    void ChangeColor()
    {
        var randomColor = new Color(Random.value, Random.value, Random.value);

        foreach (SpriteRenderer renderer in spriteRenderers)
        {
            if (renderer == null)
            {
                Debug.LogWarning("One of the SpriteRenderers in the list is null.");
                continue;
            }

            renderer.color = randomColor;
        }
    }
}
