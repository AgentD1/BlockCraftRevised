using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer),typeof(MeshFilter),typeof(MeshCollider))]
public class ChunkMono : MonoBehaviour {

    public Chunk chunk;
    public bool hasUpdated = true;
    public Transform parentObject;

	// Use this for initialization
	void Start () {
        transform.parent = parentObject;
        name = "Chunk " + chunk.position.x + " " + chunk.position.y;
        UpdateMesh();
	}
	
	// Update is called once per frame
	void Update () {
		if(hasUpdated == true) {
            UpdateMesh();
            hasUpdated = false;
        }
	}



    void UpdateMesh() {
        GetComponent<MeshFilter>().mesh = chunk.GenerateMesh();
        GetComponent<MeshCollider>().sharedMesh = GetComponent<MeshFilter>().mesh;
    }
}
