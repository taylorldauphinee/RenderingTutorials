using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ScaleTransformation.cs
/// June 9, 2021
/// Completed by Taylor Dauphinee
/// A script to handle scaling of the grid
/// Followed from Catlike Coding - Rendering 1
/// </summary>

public class ScaleTransformation : Transformation
{
    public Vector3 scale;

    public override Vector3 Apply(Vector3 point)
    {
        point.x *= scale.x;
        point.y *= scale.y;
        point.z *= scale.z;
        return point;
    }
}
