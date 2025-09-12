using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class WinLoseUI : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private GameObject _blackBackgroundObject;
    [SerializeField] private GameObject _winPopup;
    [SerializeField] private GameObject _losePopup;
    [SerializeField] private Image _blackBackgroundImage;
    [SerializeField] private RectTransform _winPopupTransform;
    [SerializeField] private RectTransform _losePopupTransform;

    [Header("References")]
    [SerializeField] private float _animationDuration = 0.3f;

    public void OnGameWin()
    {
        _blackBackgroundObject.SetActive(true);
        _winPopup.SetActive(true);

        _blackBackgroundImage.DOFade(0.8f, _animationDuration).SetEase(Ease.Linear);
        _winPopupTransform.DOScale(1.5f, _animationDuration).SetEase(Ease.OutBack);
    }

    public void OnGameLose()
    {
        _blackBackgroundObject.SetActive(true);
        _losePopup.SetActive(true);

        _blackBackgroundImage.DOFade(0.8f, _animationDuration).SetEase(Ease.Linear);
        _losePopupTransform.DOScale(1.5f, _animationDuration).SetEase(Ease.OutBack);
    }

}
