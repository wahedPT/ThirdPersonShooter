using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgroDetection : MonoBehaviour
{
    //public event Action<Transform> OnAggro = delegate { };
    private void OnTriggerEnter(Collider other)
    {
        var player = other.GetComponent<PlayerMovement>();
        if (player != null)
        {
            Debug.Log("Aggro detector");
            //OnAggro(player.transform);
        }
    }
}
