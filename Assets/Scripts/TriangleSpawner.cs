using UnityEngine;

public class TriangleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject trianglePrefab;
    [SerializeField] private Transform containerTransform;

    [SerializeField] private float minScale = 0.5f;
    [SerializeField] private float maxScale = 1.5f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SpawnTriangle();
        }
    }

    void SpawnTriangle()
    {
        Vector3 spawnPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        spawnPosition.z = 0f;

        var spawnedTriangle = Instantiate(trianglePrefab, spawnPosition, GetRandomRotation(), containerTransform);
        spawnedTriangle.transform.localScale = GetRandomScale();
    }

    Quaternion GetRandomRotation()
    {
        float randomZRotation = Random.Range(0f, 360f);
        return Quaternion.Euler(0f, 0f, randomZRotation);
    }

    Vector3 GetRandomScale()
    {
        float randomScale = Random.Range(minScale, maxScale);
        return new Vector3(randomScale, randomScale, 1f);
    }
}
