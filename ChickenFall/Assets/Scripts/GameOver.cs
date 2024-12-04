using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    [SerializeField] private GameObject restartButton;
    [SerializeField] private GameObject defeat;
    [SerializeField] private Text defeatTimer;
    [SerializeField] private float _seconds = 6;
    public static bool _gameOver = false;

    private void Update()
    {
        if (TriggerLimit._triggerEnable > 0)
        {
            if (_seconds <= 0)
            {
                _gameOver = true;
                defeatTimer.text = "";
                defeat.SetActive(true);
                restartButton.SetActive(true);
            }
            else Timer();
        }
        else if (!_gameOver) _seconds = 6;
    }

    private void Timer()
    {
        _seconds -= Time.deltaTime;
        defeatTimer.text = _seconds < 5.5f ? _seconds < 1 ? _seconds.ToString("F1") : ((int)_seconds).ToString() : "";
    }
}
