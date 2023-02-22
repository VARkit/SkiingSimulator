using UnityEngine;
using UnityEngine.UI;

public class ImageSwapping : MonoBehaviour
{
    // ���������� ��� �������� ������ �� ��������, ������� �� ����� ������
    public Image image1;
    public Image image2;

    // ���������� ��� ������� ��������� ����� ��������
    public float swapInterval = 1f;

    // ���� ��� ������������ ������� �������� ��������
    private bool isImage1Active = true;

    // ������ ��� ������������ �������, ���������� ����� ��������� ����� ��������
    private float timer = 0f;

    // ����� Update ���������� ������ ����
    void Update()
    {
        // ����������� �������� ������� �� �������� ���������� ������� � ������� �����
        timer += Time.deltaTime;

        // ���� ������ ���������� ������� ��� ����� ��������
        if (timer >= swapInterval)
        {
            // ���������� ������
            timer = 0f;

            // ���� ������ �������� �������, �� ������������ �� � ���������� ������ ��������
            if (isImage1Active)
            {
                image1.gameObject.SetActive(false);
                image2.gameObject.SetActive(true);
                isImage1Active = false;
            }
            // ���� ������ �������� �������, �� ������������ �� � ���������� ������ ��������
            else
            {
                image1.gameObject.SetActive(true);
                image2.gameObject.SetActive(false);
                isImage1Active = true;
            }
        }
    }
}