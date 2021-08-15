using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DumbEnemy : MonoBehaviour
{
    [SerializeField] private FloatReference MaxHP;

    [SerializeField] private FloatReference MoveSpeed;

    private void Start()
    {
        MaxHP = new FloatReference();
        MoveSpeed = new FloatReference();
    }
    private void Update()
    {
        Debug.Log("MaxHP: " + MaxHP.Value.ToString());
    }
}
