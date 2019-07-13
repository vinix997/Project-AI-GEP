﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Author : Chandra Delon
[ExecuteInEditMode]
public class MeshFromSkinnedMesh : MonoBehaviour {

    void Start () {
        if (GetComponent<SkinnedMeshRenderer>())
        {
            SkinnedMeshRenderer skinnedMeshRenderer = GetComponent<SkinnedMeshRenderer>();
            MeshFilter filter = gameObject.AddComponent<MeshFilter>();
            MeshRenderer renderer = gameObject.AddComponent<MeshRenderer>();
            filter.mesh = skinnedMeshRenderer.sharedMesh;
            renderer.sharedMaterials = skinnedMeshRenderer.sharedMaterials;
            DestroyImmediate(skinnedMeshRenderer);
            DestroyImmediate(this);
        }
	}

}
