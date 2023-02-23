using UnityEngine;
using System.Collections;

public class AvoidBumps : MonoBehaviour
{
    public float maxHeight = 2f; // ћаксимальна€ высота, на которую может подн€тьс€ игрок
    public LayerMask groundLayer; // —лой земли
    public float groundRaycastDistance = 0.1f; // –ассто€ние, на которое должен спускатьс€ луч проверки земли

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        RaycastHit hit;

        // ѕроверка, находитс€ ли игрок на земле
        if (Physics.Raycast(transform.position, Vector3.down, out hit, groundRaycastDistance, groundLayer))
        {
            // ≈сли высота игрока больше максимальной, то он должен быть перемещен на землю
            if (transform.position.y - hit.point.y > maxHeight)
            {
                rb.velocity = new Vector3(rb.velocity.x, 0f, rb.velocity.z); // ќбнул€ем вертикальную скорость, чтобы игрок не прыгал
                transform.position = new Vector3(transform.position.x, hit.point.y + maxHeight, transform.position.z); // ”станавливаем игрока на землю с учетом максимальной высоты
            }
        }
    }
}