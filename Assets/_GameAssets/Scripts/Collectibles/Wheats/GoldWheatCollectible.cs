using UnityEngine;

public class GoldWheatCollectible : MonoBehaviour, ICollectible
{
    [SerializeField] private PlayerController _playerController;
    [SerializeField] private float _movementIncreaseSpeed;
    [SerializeField] private float _resetBoostDuration;
    public void Collect()
    {
        _playerController.SetMovementSpeed(_movementIncreaseSpeed, _resetBoostDuration);
        Destroy(gameObject);
    }
}
