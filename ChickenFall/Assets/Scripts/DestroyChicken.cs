using UnityEngine;
using UnityEngine.UI;

public class DestroyChicken : MonoBehaviour
{
    [SerializeField] private GameObject destroyObject;
    [SerializeField] private Text counter;

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0) && !GameOver._gameOver)
        {
            counter.text = (int.Parse(counter.text) + 1).ToString(); 
            Destroy(destroyObject);
        }
    }
}
