﻿using System.Collections;
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

    public override Matrix4x4 Matrix
    {
        get
        {
            Matrix4x4 matrix = new Matrix4x4();
            matrix.SetRow(0, new Vector4(scale.x, 0f, 0f, 0f));
            matrix.SetRow(1, new Vector4(0f, scale.y, 0f, 0f));
            matrix.SetRow(2, new Vector4(0f, 0f, scale.z, 0f));
            matrix.SetRow(3, new Vector4(0f, 0f, 0f, 1f));
            return matrix;
        }
    }
}
