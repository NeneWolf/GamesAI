using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
public class ProceduralGeneratorCube2 : MonoBehaviour
{
    public Vector3[] vertices =
        {
        //Front Face Vertices
        new Vector3(0,0,0),
        new Vector3(1,0,0),
        new Vector3(1,1,0),
        new Vector3(0,1,0),

        //Rear Face Vertices
        new Vector3(0,0,1),
        new Vector3(1,0,1),
        new Vector3(1,1,1),
        new Vector3(0,1,1),

        //Left Face Extra Vertices
        new Vector3(0,1,0),
        new Vector3(0,1,1),

        //Right Face Extra Vertices
        new Vector3(1,1,0),
        new Vector3(1,1,1),

        //Far end Face Extra Vertices
        new Vector3(0,1,0),
        new Vector3(1,1,0)
    };

    public Vector2[] uvs =
    {
        //UV Coordinates of the front face
        new Vector2(0.25f,0.66f),
        new Vector2(0.25f,0.33f),
        new Vector2(0,0.33f),
        new Vector2(0,0.66f),

        //UV Coordinates of the rear face
        new Vector2(0.5f,0.66f),
        new Vector2(0.5f,0.33f),
        new Vector2(0.75f,0.33f),
        new Vector2(0.75f,0.66f),

        //UV Coordinates of the left face extra vertices
        new Vector2(0.25f,1),
        new Vector2(0.5f,1),

        //UV Coordinates of the right face extra vertices
        new Vector2(0.25f,0),
        new Vector2(0.5f,0),

        //UV Coordinates of the far end face extra vertices
        new Vector2(1,0.66f),
        new Vector2(1,0.33f)
    };

    public int[] tris =
    {
        0, 2, 1, //front face
        0, 3, 2,

        7, 5, 6, //rear face
        5, 7, 4,

        6, 13, 12, //top face
        7, 6, 12,

        0, 5, 4, //bottom face
        0, 1, 5,

        0, 9, 8, //left face
        0, 4, 9,

        1, 10, 5, //right face
        10, 11, 5
    };

    // Start is called before the first frame update
    void Start()
    {
        Mesh mesh = GetComponent<MeshFilter>().mesh;
        mesh.Clear();
        mesh.vertices = vertices;
        mesh.triangles = tris;
        mesh.uv = uvs;
        mesh.Optimize();
        mesh.RecalculateNormals();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
