using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
public class ProceduralCubeGenerator : MonoBehaviour
{
    public Vector3[] vertices =
        {
        new Vector3(0,0,0),
        new Vector3(1,0,0),
        new Vector3(1,1,0),
        new Vector3(0,1,0),
        new Vector3(0,0,1),
        new Vector3(0,1,1),
        new Vector3(1,0,1),
        new Vector3(1,1,1)
    };

    public int[] tris =
    {
        0,2,1,
        0,3,2, //FrontArea
        0,4,5,
        0,5,3, //LeftSideArea
        0,1,4,
        1,7,4, //BottomArea
        7,5,4,
        5,7,8, //BackArea
        1,2,7,
        2,8,7, //RightSideArea
        3,5,2,
        5,8,2 //TopArea
        
    };
    // Start is called before the first frame update
    void Start()
    {
        Mesh mesh = GetComponent<MeshFilter>().mesh;
        mesh.Clear();
        mesh.vertices = vertices;
        mesh.triangles = tris;
        mesh.Optimize();
        mesh.RecalculateNormals();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
