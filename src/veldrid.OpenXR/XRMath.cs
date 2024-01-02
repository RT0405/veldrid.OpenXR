// This file was copied from (https://github.com/microsoft/OpenXR-MixedReality/blob/main/shared/XrUtility/XrMath.h) and falls under the following license:

/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * Copyright (c) Microsoft Corporation.                                            *
 * MIT License                                                                     *
 *                                                                                 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy    *
 * of this software and associated documentation files (the "Software"), to deal   *
 * in the Software without restriction, including without limitation the rights    *
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell       *
 * copies of the Software, and to permit persons to whom the Software is           *
 * furnished to do so, subject to the following conditions:                        *
 *                                                                                 *
 * The above copyright notice and this permission notice shall be included in all  *
 * copies or substantial portions of the Software.                                 *
 *                                                                                 *
 * THE SOFTWARE IS PROVIDED *AS IS*, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR      *
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,        *
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE     *
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER          *
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,   *
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE   *
 * SOFTWARE.                                                                       *
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

using System.Numerics;
using System.Runtime.CompilerServices;
using Veldrid.OpenXR.Native;

namespace Veldrid.OpenXR.Mathematics;

public static class XRMath
{
    public static Matrix4x4 ComposeProjectionMatrixFast(this XrFovf fov, float near, float far)
    {
        float nearPlane = near;
        float farPlane = far;
        float l = float.Tan(fov.angleLeft);
        float r = float.Tan(fov.angleRight);
        float b = float.Tan(fov.angleDown);
        float t = float.Tan(fov.angleUp);
        l *= nearPlane;
        r *= nearPlane;
        b *= nearPlane;
        t *= nearPlane;

        return Matrix4x4.CreatePerspectiveOffCenter(l, r, b, t, nearPlane, farPlane);
    }
    public static Matrix4x4 ComposeProjectionMatrix(this XrFovf fov, float near, float far)
    {
        static void ValidateFovAngle(float angle)
        {
            if (angle >= float.Pi / 2 || angle <= -float.Pi / 2)
                throw new InvalidOperationException("Invalid projection specification");
        }
        ValidateFovAngle(fov.angleLeft);
        ValidateFovAngle(fov.angleRight);
        ValidateFovAngle(fov.angleUp);
        ValidateFovAngle(fov.angleDown);

        if (float.Abs(fov.angleLeft - fov.angleRight) < float.Epsilon ||
            float.Abs(fov.angleUp - fov.angleDown) < float.Epsilon)
        {
            throw new InvalidOperationException("Invalid projection specification");
        }

        float nearPlane = near;
        float farPlane = far;
        bool infNearPlane = float.IsInfinity(nearPlane);
        bool infFarPlane = float.IsInfinity(farPlane);

        float l = float.Tan(fov.angleLeft);
        float r = float.Tan(fov.angleRight);
        float b = float.Tan(fov.angleDown);
        float t = float.Tan(fov.angleUp);
        if (!infNearPlane)
        {
            l *= nearPlane;
            r *= nearPlane;
            b *= nearPlane;
            t *= nearPlane;
        }

        if (nearPlane < 0f || farPlane < 0f)
            throw new InvalidOperationException("Invalid projection specification");

        if (infNearPlane || infFarPlane)
        {
            if (infNearPlane && infFarPlane)
                throw new InvalidOperationException("Invalid projection specification");

            float reciprocalWidth = 1.0f / (r - l);
            float reciprocalHeight = 1.0f / (t - b);

            Unsafe.SkipInit(out Matrix4x4 projectionMatrix);

            float twoNearZ;
            if (infNearPlane)
            {
                twoNearZ = 2;

                projectionMatrix.M33 = 0.0f;     // far / (near - far) = far / inf = 0
                projectionMatrix.M43 = farPlane; // near * far / (near - far) = far * (near / (near - far)) = far * (inf / inf) = far
            }
            else
            {
                twoNearZ = nearPlane + nearPlane;

                projectionMatrix.M33 = -1.0f;      // far / (near - far) = inf / -inf = -1
                projectionMatrix.M43 = -nearPlane; // near * far / (near - far) = near * inf / -inf = -near
            }

            projectionMatrix.M11 = twoNearZ * reciprocalWidth;
            projectionMatrix.M12 = 0.0f;
            projectionMatrix.M13 = 0.0f;
            projectionMatrix.M14 = 0.0f;

            projectionMatrix.M21 = 0.0f;
            projectionMatrix.M22 = twoNearZ * reciprocalHeight;
            projectionMatrix.M23 = 0.0f;
            projectionMatrix.M24 = 0.0f;

            projectionMatrix.M31 = (l + r) * reciprocalWidth;
            projectionMatrix.M32 = (t + b) * reciprocalHeight;
            projectionMatrix.M34 = -1.0f;

            projectionMatrix.M41 = 0.0f;
            projectionMatrix.M42 = 0.0f;
            projectionMatrix.M44 = 0.0f;

            return projectionMatrix;
        }
        else
        {
            return Matrix4x4.CreatePerspectiveOffCenter(l, r, b, t, nearPlane, farPlane);
        }
    }
}