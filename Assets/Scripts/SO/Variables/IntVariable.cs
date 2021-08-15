using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SO.Variables
{

    [CreateAssetMenu]
    public class IntVariable : ScriptableObject
    {
        [SerializeField] private int value;

        public int Value { get => value; set => this.value = value; }
    }
}