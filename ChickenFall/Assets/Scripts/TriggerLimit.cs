using UnityEngine;

public class TriggerLimit : MonoBehaviour
{
    public static int _triggerEnable = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _triggerEnable++;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _triggerEnable--;
    }
}
