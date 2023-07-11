using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class button2 : MonoBehaviour, IPointerClickHandler
{
    public Sprite flag;
    public Sprite target_10;
    public int open2;
    private int b;
    private void Start()
    {
        b = GetComponent<button1>().a;
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        if(eventData.button == PointerEventData.InputButton.Right && GetComponent<button1>().open == 0)
        {
            GetComponent<Image>().sprite = flag;
            if(GetComponent<button1>().a != -1)
            {
                GetComponent<button1>().a = -1;
            }
            else
            {
                GetComponent<button1>().a = b;
                GetComponent<Image>().sprite = target_10;
            }
        }

    }
}
