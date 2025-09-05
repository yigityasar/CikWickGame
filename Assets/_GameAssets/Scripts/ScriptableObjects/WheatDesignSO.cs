using UnityEngine;

[CreateAssetMenu(fileName = "HeatDesignSO", menuName = "ScriptableObjects/WheatDesignSO")]
 
public class WheatDesignSO : ScriptableObject
{
    [SerializeField] private float _increaseDecreaseMultiplier;
    [SerializeField] private float _resetBoostDuration;

    public float IncreaseDecreaseMultiplier => _increaseDecreaseMultiplier;
    public float ResetBoostDuration => _resetBoostDuration;
}
