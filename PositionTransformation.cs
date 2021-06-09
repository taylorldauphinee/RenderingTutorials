using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// PositionTransformation.cs
/// June 9, 2021
/// Completed by Taylor Dauphinee
/// A script to handle translation of the grid
/// Followed from Catlike Coding - Rendering 1
/// </summary>

public class PositionTransformation : Transformation
{
    public Vector3 position;

    public override Vector3 Apply(Vector3 point)
    {
        return point + position;
    }
}
