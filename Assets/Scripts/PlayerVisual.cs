using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerVisual : MonoBehaviour
{
    [SerializeField] private MeshRenderer headMeshRenderer;
    [SerializeField] private MeshRenderer bodyMeshRenderer;

    private Material material;

    private void Awake()
    {
        material = new Material(headMeshRenderer.material);
        headMeshRenderer.material = material;
        bodyMeshRenderer.material = material;
    }

    private void Start()
    {
        //SetPlayerColor(KitchenGameMultiplayer.Instance.GetPlayerColor());
    }

    public void SetPlayerColor(Color color)
    {
        material.color = color;
    }
}
