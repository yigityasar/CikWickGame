using UnityEngine;

public class SpatulaBooster : MonoBehaviour, IBoostable
{
    [Header("Settings")]
    [SerializeField] private float _jumpforce;
    [Header("References")]
    [SerializeField] private Animator _spatulaAnimator;
    private bool _isActivated;
    public void Boost(PlayerController playerController)
    {
        if(_isActivated) return;

        PlayBoostAnimation();
        Rigidbody playerRigidbody = playerController.GetPlayerRigidbody();

        playerRigidbody.linearVelocity = new Vector3(playerRigidbody.linearVelocity.x, 0f, playerRigidbody.linearVelocity.z);
        playerRigidbody.AddForce(transform.forward * _jumpforce, ForceMode.Impulse);
        _isActivated = true;
        Invoke(nameof(ResetActivation), 0.2f);
    }

    private void PlayBoostAnimation()
    {
        _spatulaAnimator.SetTrigger(Consts.OtherAnimations.IS_SPATULA_JUMPING);
    }

    private void ResetActivation()
    {
        _isActivated = false;
    } 
}
