using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace TopDown
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private InputActionAsset _actionAsset;
        [SerializeField] private CharacterController _characterController;
        [SerializeField] private Transform _cameraTarget;
        [SerializeField] private Transform _cameraTransform;



        [SerializeField] private float _rotationSmoothTime = 0.12f;
        [SerializeField] private float _speedChangeTime = 10f;
        [SerializeField] private float _speedMove = 10f;
        [SerializeField] private float _sprintSpeed = 20f;
        [SerializeField] private float _speedRotation = 200f;
        [SerializeField] private float _topClamp = 70f;
        [SerializeField] private float _bottomClamp = -9f;

        private float _cameraTargetYaw;
        private float _cameraTargetPitch;
        private float _cameraRotationVel;
        private float _targetRotation;


        private InputActionMap playerMap;
        private InputAction moveAction;
        private InputAction lookAction;
        private void Awake()
        {
            playerMap = _actionAsset.FindActionMap("Player");
            moveAction = _actionAsset.FindAction("Move");
            lookAction = _actionAsset.FindAction("Look");


        }

        private void OnEnable()
        {
            playerMap.Enable();
        }

        private void OnDisable()
        {
            playerMap.Disable();
        }


        private void Update()
        {
            Vector2 move = moveAction.ReadValue<Vector2>();
            Move(move, false);

        }

        private void LateUpdate()
        {
            Vector2 look = lookAction.ReadValue<Vector2>();
            CameraRotation(look);
        }

        private void Move(Vector2 move, bool isSprint)
        {

        }

        private void CameraRotation(Vector2 look)
        {

        }

    }
}
