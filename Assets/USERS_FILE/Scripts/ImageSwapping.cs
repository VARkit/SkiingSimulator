using UnityEngine;
using UnityEngine.UI;

public class ImageSwapping : MonoBehaviour
{
    // Переменные для хранения ссылок на картинки, которые мы будем менять
    public Image image1;
    public Image image2;

    // Переменная для задания интервала смены картинок
    public float swapInterval = 1f;

    // Флаг для отслеживания текущей активной картинки
    private bool isImage1Active = true;

    // Таймер для отслеживания времени, прошедшего после последней смены картинок
    private float timer = 0f;

    // Метод Update вызывается каждый кадр
    void Update()
    {
        // Увеличиваем значение таймера на значение прошедшего времени в текущем кадре
        timer += Time.deltaTime;

        // Если прошло достаточно времени для смены картинок
        if (timer >= swapInterval)
        {
            // Сбрасываем таймер
            timer = 0f;

            // Если первая картинка активна, то деактивируем ее и активируем вторую картинку
            if (isImage1Active)
            {
                image1.gameObject.SetActive(false);
                image2.gameObject.SetActive(true);
                isImage1Active = false;
            }
            // Если вторая картинка активна, то деактивируем ее и активируем первую картинку
            else
            {
                image1.gameObject.SetActive(true);
                image2.gameObject.SetActive(false);
                isImage1Active = true;
            }
        }
    }
}