using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// TransformationGrid.cs
/// June 9, 2021
/// Completed by Taylor Dauphinee
/// A script to create a rendered grid
/// Followed from Catlike Coding - Rendering 1
/// </summary>

public class TransformationGrid : MonoBehaviour
{
    public Transform prefab;

    public int gridResolution = 10;

    Transform[] grid;

    List<Transformation> transformations;

    private void Awake()
    {
        // Making Space Visible
        // create a 3D grid of points
        grid = new Transform[gridResolution * gridResolution * gridResolution];
        for (int i = 0, z = 0; z < gridResolution; z++)
        {
            for (int y = 0; y < gridResolution; y++)
            {
                for (int x = 0; x < gridResolution; x++, i++)
                {
                    grid[i] = CreateGridPoint(x, y, z);
                }
            }
        }

        // Adding Transformations
        transformations = new List<Transformation>();
    }

    Transform CreateGridPoint(int x, int y, int z)
    {
        Transform point = Instantiate<Transform>(prefab);
        point.localPosition = GetCoordinates(x, y, z);
        point.GetComponent<MeshRenderer>().material.color = new Color(
            (float)x / gridResolution,
            (float)y / gridResolution,
            (float)z / gridResolution
        );
        return point;
    }

    Vector3 GetCoordinates(int x, int y, int z)
    {
        return new Vector3(
            x - (gridResolution - 1) * 0.5f,
            y - (gridResolution - 1) * 0.5f,
            z - (gridResolution - 1) * 0.5f
        );
    }

    private void Update()
    {
        // get the transform components and change them during play mode
        GetComponents<Transformation>(transformations);
        for (int i = 0, z = 0; z < gridResolution; z++)
        {
            for (int y = 0; y < gridResolution; y++)
            {
                for (int x = 0; x < gridResolution; x++, i++)
                {
                    grid[i].localPosition = TransformPoint(x, y, z);
                }
            }
        }
    }

    Vector3 TransformPoint(int x, int y, int z)
    {
        Vector3 coordinates = GetCoordinates(x, y, z);
        for (int i = 0; i < transformations.Count; i++)
        {
            coordinates = transformations[i].Apply(coordinates);
        }
        return coordinates;
    }
}
