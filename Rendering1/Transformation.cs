using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Transformation.cs
/// June 9, 2021
/// Completed by Taylor Dauphinee
/// A class to handle base operations of transformations
/// Followed from Catlike Coding - Rendering 1
/// </summary>

public abstract class Transformation : MonoBehaviour
{
    // use a 4x4 matrix to change all aspects of transformation together
    public abstract Matrix4x4 Matrix { get; }

    public Vector3 Apply(Vector3 point)
    {
        return Matrix.MultiplyPoint(point);
    }
}
