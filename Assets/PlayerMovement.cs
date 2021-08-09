using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    CharacterController CharacterController;
    public float PlayerSpeed;
    Animator anim;
    [SerializeField]
    private float turnSpeed;
    private void Awake()
    {
        CharacterController = GetComponent<CharacterController>();
        anim = GetComponentInChildren<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        var horizontalM = Input.GetAxis("Horizontal");
        var verticalM = Input.GetAxis("Vertical");

        var playerMove = new Vector3(horizontalM, 0, verticalM);
        CharacterController.SimpleMove(playerMove * Time.deltaTime*PlayerSpeed);
        anim.SetFloat("Speed", playerMove.magnitude);

        Quaternion newDir = Quaternion.LookRotation(playerMove);
        transform.rotation = Quaternion.Slerp(transform.rotation, newDir, Time.deltaTime*turnSpeed) ;

    }
}
