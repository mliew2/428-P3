# CS 428 Project 3 - Our House

This code repository contains a folder with all of the code necessary to run this project. Before cloning this repository, make sure you have the following downloaded:
- [Unity 2021.3.6f1](https://unity3d.com/unity/whats-new/2021.3.6)
- [Unity Hub](https://unity3d.com/get-unity/download)
- [VRTK v4](https://assetstore.unity.com/packages/tools/utilities/vrtk-v4-tilia-package-importer-214936)

VRTK v4 can only be downloaded in Unity, so that will be the last step. After these softwares are downloaded, clone this repo to whatever location you want locally. Here are some simple steps below: 

```
cd 
git clone https://github.com/meganmehta/mmehta25-p2.git
```
After cloning, open this project file within Unity Hub (this will automatically open in Unity). 

If you have an Oculus Quest headset, you can run this project directly on the headset by connecting it to your computer. Then, in Unity click `File` then `Build Settings` and select `Android` then click `Build and Run`. If you don't see this option available, you probably don't have the Anroid SDK or modules downloaded. To do this, go to Unity Hub and click `Installs` on the left menu, and click the settings icon on the Unity version, you should be able to add the Android module from there. 

After `Build and Run` is clicked, navigate to the Quest headset settings and going to the `Developer` section - make sure `USB Connection Dialog` is on. Then, go back to the Unity project on your computer and enable `CameraRigs.UnityXRPluginFramework`. You can do this by right-clicking on it in the Unity hierarchy and clicking `Toggle Active Status`. Also, disable `CameraRigs.SpatialSimulator`. 

It may take a few minutes to load on the headset, but if you run into any errors try replugging in the headset or rebuilding the project for the Anroid platform. If it doesn't automatically show on the headset, you can try looking in the apps to see if it pops up as an `Unknown Source`. 

If you do not have a VR headset, not to worry! You can also just run the project on your computer. To do this, change the build settings to be `Windows, Mac, and Linux` and then click `Build and Run`. It should automatically run on your screen, but if not, press the Play button in the center of the Unity window, and Switch to `Game` mode near the top left. You can use the WASD keys to interact in the scene, and use keys 1,2, and 3 to use the controllers and your mouse to grab the objects. 

If you run this project on your laptop, it should look something like this...
<img width="401" alt="image1" src="https://github.com/mliew2/428-P3/blob/main/p3-overview.png">


If you'd like to read more about the project details, check out
the documentation [here](https://mmehta25.people.uic.edu/428p4.html).
