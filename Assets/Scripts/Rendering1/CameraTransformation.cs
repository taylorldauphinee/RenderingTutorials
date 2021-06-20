using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// CameraTransformation.cs
/// June 11, 2021
/// Completed by Taylor Dauphinee
/// A script to allow camera projection
/// Followed from Catlike Coding - Rendering 1
/// </summary>

public class CameraTransformation : Transformation
{
    public float focalLength = 1f;

    public override Matrix4x4 Matrix
    {
        get
        {
            Matrix4x4 matrix = new Matrix4x4();
            matrix.SetRow(0, new Vector4(focalLength, 0f, 0f, 0f));
            matrix.SetRow(1, new Vector4(0f, focalLength, 0f, 0f));
            matrix.SetRow(2, new Vector4(0f, 0f, 0f, 0f)); // drop z dimension to get orthographic camera
            matrix.SetRow(3, new Vector4(0f, 0f, 1f, 0f)); // switch to 0, 0, 1, 0 to get perspective camera
            return matrix;
        }
    }
}
