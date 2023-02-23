using UnityEngine;
using System.Collections;

public class AvoidBumps : MonoBehaviour
{
    public float maxHeight = 2f; // ������������ ������, �� ������� ����� ��������� �����
    public LayerMask groundLayer; // ���� �����
    public float groundRaycastDistance = 0.1f; // ����������, �� ������� ������ ���������� ��� �������� �����

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        RaycastHit hit;

        // ��������, ��������� �� ����� �� �����
        if (Physics.Raycast(transform.position, Vector3.down, out hit, groundRaycastDistance, groundLayer))
        {
            // ���� ������ ������ ������ ������������, �� �� ������ ���� ��������� �� �����
            if (transform.position.y - hit.point.y > maxHeight)
            {
                rb.velocity = new Vector3(rb.velocity.x, 0f, rb.velocity.z); // �������� ������������ ��������, ����� ����� �� ������
                transform.position = new Vector3(transform.position.x, hit.point.y + maxHeight, transform.position.z); // ������������� ������ �� ����� � ������ ������������ ������
            }
        }
    }
}