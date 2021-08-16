using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    [SerializeField]
    int startinghealth = 5;
    [SerializeField]
    int currenthealth;

    private void OnEnable()
    {
        currenthealth = startinghealth;
    }

    public void TakeDamange(int damageamount)
    {
        currenthealth -= damageamount;
        if(currenthealth<=0)
        {
            Die();
        }
    }

    private void Die()
    {
        gameObject.SetActive(false);
    }
}
