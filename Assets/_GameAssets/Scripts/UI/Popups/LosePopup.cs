using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LosePopup : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Button _tryAgainButton;
    [SerializeField] private Button _mainMeButton;
    [SerializeField] private TMP_Text _timerText;
    [SerializeField] private TimerUI _timerUI;

    private void Awake()
    {
        _tryAgainButton.onClick.AddListener(OnTryAgainButtonClicked);
        _timerText.text = _timerUI.GetFinalTime();
    }
    private void OnTryAgainButtonClicked()
    {
        SceneManager.LoadScene(Consts.SceneNames.GAME_SCENE);
    }

}
