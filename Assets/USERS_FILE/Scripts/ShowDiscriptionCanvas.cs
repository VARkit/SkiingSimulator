using UnityEngine;
using UnityEngine.UI;

public class ShowDiscriptionCanvas : MonoBehaviour
{
   public GameObject Canvas;
   public void CanvasOnOff(){
        Canvas.SetActive(!Canvas.activeSelf);
   }
}
