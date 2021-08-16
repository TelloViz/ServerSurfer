using SO.Variables;
using System;
using UnityEngine;

namespace Vast.StateMachine {
    [Serializable]
    public abstract class State : ScriptableObject {
        [SerializeField] private StringVariable name;


        #region Properties
        public StringVariable Name { get => name; set => name = value; }

        #endregion

        #region Class Methods
        public abstract void OnEnter();
        public abstract void OnExit();
        public abstract void Update();
        public abstract void FixedUpdate();
        #endregion
    }
}