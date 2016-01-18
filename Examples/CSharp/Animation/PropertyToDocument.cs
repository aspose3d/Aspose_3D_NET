﻿using System;
using System.IO;
using System.Collections;
using Aspose.ThreeD;
using Aspose.ThreeD.Animations;
using Aspose.ThreeD.Entities;
using Aspose.ThreeD.Utils;
using CSharp.Geometry_Hierarchy;

namespace CSharp.Animation
{
    class PropertyToDocument
    {
        public static void Run()
        {
            //ExStart:AddAnimationPropertyToDocument
            // Initialize scene object
            Scene scene = new Scene();

            // Call Common class create mesh using polygon builder method to set mesh instance 
            Mesh mesh = Common.CreateMeshUsingPolygonBuilder();             

            // Each cube node has their own translation
            Node cube1 = scene.RootNode.CreateChildNode("cube1", mesh);

            // Find translation property on node's transform object
            Property translation = cube1.Transform.FindProperty("Translation");
            
            // Create a curve mapping based on translation property
            CurveMapping mapping = new CurveMapping(scene, translation);
            
            // Create curve on channel X and Z
            Curve curveX = mapping.CreateCurve("X");
            Curve curveZ = mapping.CreateCurve("Z");
            
            // Move node's translation to (10, 0, 10) at 0 sec using bezier interpolation
            curveX.CreateKeyFrame(0, 10.0f, Interpolation.Bezier);
            curveZ.CreateKeyFrame(0, 10.0f, Interpolation.Bezier);
            
            // Move node's translation to (20, 0, -10) at 3 sec
            curveX.CreateKeyFrame(3, 20.0f, Interpolation.Bezier);
            curveZ.CreateKeyFrame(3, -10.0f, Interpolation.Bezier);
            
            // Move node's translation to (30, 0, 0) at 5 sec
            curveX.CreateKeyFrame(5, 30.0f, Interpolation.Linear);
            curveZ.CreateKeyFrame(5, 0.0f, Interpolation.Bezier);            

            // The path to the documents directory.
            string MyDir = RunExamples.GetDataDir();
            MyDir = MyDir + RunExamples.GetOutputFilePath("PropertyToDocument.fbx");            

            // Save 3D scene in the supported file formats
            scene.Save(MyDir, FileFormat.FBX7400ASCII);
            //ExEnd:AddAnimationPropertyToDocument

            Console.WriteLine("\nAnimation property added successfully to document.\nFile saved at " + MyDir);
            
        }
    }
}
