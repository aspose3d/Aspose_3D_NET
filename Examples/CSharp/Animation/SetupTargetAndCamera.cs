﻿//////////////////////////////////////////////////////////////////////////
// Copyright 2015 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.3D. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System;
using System.IO;
using System.Collections;
using Aspose.ThreeD;
using Aspose.ThreeD.Animations;
using Aspose.ThreeD.Entities;
using Aspose.ThreeD.Utils;

namespace CSharp.Animation
{
    class SetupTargetAndCamera
    {
        public static void Run()
        {
            //ExStart:SetupTargetAndCamera
            // The path to the documents directory.
            string MyDir = RunExamples.GetDataDir();            
            // Initialize scene object
            Scene scene = new Scene();
            // Get a child node object
            Node cameraNode = scene.RootNode.CreateChildNode("camera", new Camera());
            // Set camera node translation
            cameraNode.Transform.Translation = new Vector3(100, 20, 0);
            cameraNode.GetEntity<Camera>().Target = scene.RootNode.CreateChildNode("target");
            MyDir = MyDir + "camera-test.3ds";
            scene.Save(MyDir , FileFormat.Distreet3DS);
            //EndEnd: SetupTargetAndCamera
            Console.WriteLine("\nThe target and camera has been setup successfully.\nFile saved at " + MyDir);
        }
    }
}