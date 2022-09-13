using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshHider : MonoBehaviour
{
    private SkinnedMeshRenderer[] meshes;


    private void Awake()
    {
        meshes = GetComponentsInChildren<SkinnedMeshRenderer>();
    }

    public void Show()
    {
        foreach(SkinnedMeshRenderer mesh in meshes)
        {
            mesh.enabled = true;
        }
    }

    public void Hide()
    {
        foreach (SkinnedMeshRenderer mesh in meshes)
        {
            mesh.enabled = false;
        }
    }
}
