using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UIElements;
using Vast.StateMachine;

public class DataCollection : MonoBehaviour
{

    [SerializeField] private AppManager appManager;
    [SerializeField] private DebugData debugData;
    [SerializeField] private UIDocument uIDoc;




    private List<Label> labelList;

    private List<State> regStates;

    public AppManager AppManager { get => appManager; set => appManager = value; }
    public UIDocument UiDoc { get => uIDoc; set => uIDoc = value; }
    public List<State> RegStates { get => regStates; set => regStates = value; }

    private void Start()
    {
        //var root = UIDocument.rootVisualElement;
        RegStates = AppManager.AppStateMachine.States;

       // InitLabelReferences(root);
        SetNumRegisteredStates(RegStates.Count, labelList.First());


    }

    private void InitLabelReferences(VisualElement root)
    {
        labelList.Add(root.Q<Label>("registered-states-value-label"));
    }

    private void SetNumRegisteredStates(int numStates, Label valueLabel)
    {
        debugData.NumRegisteredStates = numStates;
        valueLabel.text = debugData.NumRegisteredStates.ToString();
    }

    private void SetStateNameStringList()
    {
        foreach (State state in RegStates)
        {
            debugData.StateNameStrings.Add(state.Name.Value);
        }
    }

}
