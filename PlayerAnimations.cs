using UnityEngine;

[RequireComponent(typeof(Animator), typeof(PlayerMovement))]
public class PlayerAnimations : MonoBehaviour
{

    private Animator _playerAnimator;
    private PlayerMovement _playerMovement;

    private readonly int Grounded = Animator.StringToHash("Grounded");
    private readonly int VelocityX = Animator.StringToHash("VelocityX");

    private void OnEnable()
    {
        _playerAnimator = GetComponent<Animator>();
        _playerMovement = GetComponent<PlayerMovement>();
    }

    private void LateUpdate()
    {
        _playerAnimator.SetInteger(VelocityX, Mathf.RoundToInt(_playerMovement.Velocity.x));
        _playerAnimator.SetBool(Grounded, _playerMovement.grounded);
    }

}
