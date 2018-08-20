# About

This is a very simple example of how to setup [Facepunch.Steamworks](https://github.com/Facepunch/Facepunch.Steamworks) in Unity3D

First of all, you'd need to import the [Facepunch](https://github.com/Facepunch/Facepunch.Steamworks) package 
(you can head to Releases, and just get the UnityPackage file)

Next you'll need to copy the **native** dll files to *the root of your UnityProject* (where the Assets/Library/etc folders are)

After that you should be able to just attach the *SteamClient* script to any object in a scene, and fill in an AppID.
The SteamClient script is the one provided by Facepunch, I did not make this. 

Tested in Unity 5.6 and 2017.1
