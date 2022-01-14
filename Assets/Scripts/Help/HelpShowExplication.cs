using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class HelpShowExplication : MonoBehaviour, ISelectHandler
{
    [SerializeField] public TextMeshProUGUI m_Object;
    public string helperText = "...";
    public void OnSelect(BaseEventData eventData)
    {
        m_Object.text = helperText;
    }
}
