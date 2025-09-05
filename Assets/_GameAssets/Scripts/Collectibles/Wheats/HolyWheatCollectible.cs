using UnityEngine;

public class HolyWheatCollectible : MonoBehaviour
{
    [SerializeField] private PlayerController _playerController;
    [SerializeField] private float _forceIncrease;
    [SerializeField] private float _resetBoostDuration;
    public void Colect()
    {
        _playerController.SetJumpForce(_forceIncrease, _resetBoostDuration);
        Destroy(gameObject);
    }
}
