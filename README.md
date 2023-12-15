# GE1-Assignment1

Name: Erik Watchorn

Student Number: C21449374

Class Group: TU984/3 (3rd Year Game Design)

Video:

[![YouTube](https://i9.ytimg.com/vi/xrN_CFVcOek/mqdefault.jpg?sqp=CJCM8qsG-oaymwEmCMACELQB8quKqQMa8AEB-AHUBoAC4AOKAgwIABABGGUgZShlMA8=&rs=AOn4CLCcDey3pKIss_SgKD17qUtQK_QLUQ)](https://youtu.be/xrN_CFVcOek)

# Description of the project
This project is a VR simulation of being a lone researcher figuring out values to travel in time. Once values are inputted correctly you may travel to the future or the past. If they are input incorrectly you will travel to an unknown time and space. The project was made in Unity.

# Instructions for use
While playing in VR you can touch the controls, and use triggers on UI elements.
There is an instruction board once you press the red button.

# How it works
The UI interaction works through built-in events such as OnClick or OnValueChanged. This cycles between the UI pages, and triggers the ControlPanelHandler methods which calculate the values the player inputs and returns true or false for each value to determine if the player has failed, has travelled too far or have input the correct values. The project takes advantage of Unity's XR toolkit for some interactables and player movement. 

# List of classes/assets in the project

| Class/Asset | Source |
| ----------- | ------ |
| ButtonInteract.cs | Modified from [Valem Tutorials](https://youtu.be/bts8VkDP_vU?si=y_qVWZlA0i26neHe) |
| ButtonInteract1.cs | Modified from [Valem Tutorials](https://youtu.be/bts8VkDP_vU?si=y_qVWZlA0i26neHe) |
| ControlPanelHandler.cs | Self Written |
| SphereCollide.cs | Self Written |
| Particle Sprites | Modified from [Kenney Vieugels](https://opengameart.org/content/particle-pack-80-sprites) |
| Surface Textures | From [Yughues Free Metal Materials](https://assetstore.unity.com/packages/p/yughues-free-metal-materials-12949) |
| Surface Textures | From [Pack Free Textures 2](https://assetstore.unity.com/packages/2d/textures-materials/pack-free-textures-2-266006) |
| Surface Textures | From [Pack Free Textures 3](https://assetstore.unity.com/packages/2d/textures-materials/pack-free-textures-3-266007) |
| Surface Textures | From [5 Concrete Materials #1](https://assetstore.unity.com/packages/2d/textures-materials/concrete/5-concrete-materials-1-255940) |
| Background Audio | From [Prosser](https://freesound.org/people/Prosser/sounds/233996/) |
| Background Audio | From [PRINCEofWORMS](https://freesound.org/people/PRINCEofWORMS/sounds/571647/) |
| Background Audio | From [kyles](https://freesound.org/people/kyles/sounds/455828/) |
| Sound Effect | From [Cloud-10](https://freesound.org/people/Cloud-10/sounds/688735/) |
| Sound Effect | From [syrexshat](https://freesound.org/people/syrexshat/sounds/520629/) |
| Sphere.anim | Self Animated |
| Engulfing.anim | Self Animated |



# What I am most proud of in the assignment
I'm most proud of how I managed to use particle effects to create simple scenes that cause less lagging in VR.

# What I learned
I learned a lot about how different VR development is compared to traditional PC/Mobile development. I also learned a lot more about how to use particle effect settings to create quite unique particles which I have not explored very much before.

# Proposal
VR game where you have to follow instructions to set up a time machine, if successful the room changes to represent the new time.

