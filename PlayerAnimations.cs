using UnityEngine;

[RequireComponent(typeof(Animator), typeof(PhysicsMovement))]
public class PlayerAnimations : MonoBehaviour
{

    private Animator _playerAnimator;
    private PhysicsMovement _physicsMovement;

    private void OnEnable()
    {
        _playerAnimator = GetComponent<Animator>();
        _physicsMovement = GetComponent<PhysicsMovement>();
    }

    private void LateUpdate()
    {
        _playerAnimator.SetInteger("VelocityX", Mathf.RoundToInt(_physicsMovement.Velocity.x));
        _playerAnimator.SetBool("Grounded", _physicsMovement.grounded);
    }

}
