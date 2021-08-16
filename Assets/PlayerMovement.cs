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
    public float backSpeed = 3f;
    private void Awake()
    {
        CharacterController = GetComponent<CharacterController>();
        anim = GetComponentInChildren<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");
        var movement = new Vector3(horizontal, 0, vertical);
        anim.SetFloat("Speed", vertical);
        transform.Rotate(Vector3.up, horizontal * turnSpeed * Time.deltaTime);
        if (vertical != 0)
        {
            float moveSpeed = (vertical > 0) ? PlayerSpeed : backSpeed;
            CharacterController.SimpleMove(transform.forward * vertical * moveSpeed);
            //audioSource.clip = audioClip;
            //audioSource.Play();

            //Quaternion newDir = Quaternion.LookRotation(playerMove);
            //transform.rotation = Quaternion.Slerp(transform.rotation, newDir, Time.deltaTime*turnSpeed) ;

        }
    }
}
