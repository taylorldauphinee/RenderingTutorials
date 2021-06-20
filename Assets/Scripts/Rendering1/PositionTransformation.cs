﻿using System.Collections;
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

    public override Matrix4x4 Matrix
    {
        get
        {
            Matrix4x4 matrix = new Matrix4x4();
            matrix.SetRow(0, new Vector4(1f, 0f, 0f, position.x));
            matrix.SetRow(1, new Vector4(0f, 1f, 0f, position.y));
            matrix.SetRow(2, new Vector4(0f, 0f, 1f, position.z));
            matrix.SetRow(3, new Vector4(0f, 0f, 0f, 1f));
            return matrix;
        }
    }
}