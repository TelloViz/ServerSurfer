 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SO.Variables
{

    [CreateAssetMenu]
    public class FloatVariable : ScriptableObject
    {
        private float value;

        public float Value { get => value; set => this.value = value; }
    }
}