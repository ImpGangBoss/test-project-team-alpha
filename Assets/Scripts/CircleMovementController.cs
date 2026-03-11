using UnityEngine;
using UnityEngine.Rendering.UI;

public class CircleMovementController : MonoBehaviour
{
    [SerializeField] private float moveStep = 0.1f;
    [SerializeField] private Transform circleTransform;

    void Update()
    {
        Vector3 moveDirection = Vector3.zero;

        moveDirection.x = Input.GetAxis("Horizontal");
        moveDirection.y = Input.GetAxis("Vertical");

        moveDirection.Normalize();

        circleTransform.position += moveDirection * moveStep;
    }
}
