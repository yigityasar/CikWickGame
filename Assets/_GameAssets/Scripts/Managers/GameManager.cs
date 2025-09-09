using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance{ get; private set; }
    [Header("References")]
    [SerializeField] private EggCounterUI _eggCounterUI;
    [Header("Settings")]
    [SerializeField] private int _maxEggCount;
    private int _currentEggCount;
    private void Awake()
    {
        Instance = this;
    }

    public void OnEggCollected()
    {
        _currentEggCount++;
        _eggCounterUI.SetEggCounterText(_currentEggCount, _maxEggCount);
        if (_currentEggCount == _maxEggCount)
        {
            Debug.Log("Game win!");
            _eggCounterUI.setEggCompleted();
        }
        Debug.Log("Egg count: " + _currentEggCount);

    }
}
