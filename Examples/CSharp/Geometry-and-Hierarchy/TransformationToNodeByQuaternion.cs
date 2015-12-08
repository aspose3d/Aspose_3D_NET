﻿//////////////////////////////////////////////////////////////////////////
// Copyright 2015 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.3D. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.IO;
using Aspose.ThreeD;
using Aspose.ThreeD.Entities;
using Aspose.ThreeD.Utils;
namespace CSharp.Geometry_Hierarchy
{
    class TransformationToNodeByQuaternion
    {
        public static void Run()
        {
            //ExStart:AddTransformationToNodeByQuaternion            
            // Initialize scene object
            Scene scene = new Scene();

            // Initialize Node class object
            Node cubeNode = new Node("cube");

            // Call Common class create mesh using polygon builder method to set mesh instance 
            Mesh mesh = Common.CreateMeshUsingPolygonBuilder(); 
           
            // Point node to the Mesh geometry
            cubeNode.Entity = mesh;
            // Set rotation
            cubeNode.Transform.Rotation = Quaternion.FromRotation(new Vector3(0, 1, 0), new Vector3(0.3, 0.5, 0.1));            
            // Set translation
            cubeNode.Transform.Translation = new Vector3(0, 0, 20);            
            // Add cube to the scene
            scene.RootNode.ChildNodes.Add(cubeNode);            

            // The path to the documents directory.
            string MyDir = RunExamples.GetDataDir();
            MyDir = MyDir + RunExamples.GetOutputFilePath("TransformationToNode.fbx");
   
            // Save 3D scene in the supported file formats
            scene.Save(MyDir, FileFormat.FBX7400ASCII);
            //ExEnd:AddTransformationToNodeByQuaternion
            Console.WriteLine("\nTransformation added successfully to node.\nFile saved at " + MyDir);

        }
    }
}