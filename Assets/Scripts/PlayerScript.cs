using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] private PlayerActionController playerActionController;

    public PlayerActionController PlayerActionController { get => playerActionController; set => playerActionController = value; }
}
