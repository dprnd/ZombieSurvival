using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;            // 앞뒤 움직임의 속도
    public float ratateSpeed = 180f;        // 좌우 회전 속도

    private PlayerInput playerInput;        // 플레이어 입력을 알려주는 컴포넌트
    [SerializeField] private Rigidbody playerRigidbody;      // 플레이어 캐릭터의 리지드바디  
    // [SerializeField]주면 private여도 직렬처리됨 보안성은 지키되 인스펙터창에서 확인할 수 있게 함.
    private Animator playerAnimator;        // 플레이어 캐릭터의 애니메이션


    private void Start()        // 사용할 컴포넌트들의 참조 가져오기
    {
        playerInput = GetComponent<PlayerInput>();
        playerRigidbody = GetComponent<Rigidbody>();
        playerAnimator = GetComponent<Animator>();      // 제대로 할당 되었는지 어떻게 아는가?
    }

    // FixedUpdate는 물리 갱신 주기마다 움직임, 회전, 애니메이션 처리
    private void FixedUpdate()
    {
        
    }

    // 입력값에 따라 캐릭터를 앞뒤로 움직임
    private void Move()
    {

    }

    // 입력값에 따라 캐릭터를 좌우로 회전
    private void Rotate()
    {

    }
}
