# RoboyUnityFace
Unity animation for Roboy face

## 1. Prerequesites 

Roboy's facial expressions are animated in Unity. The corresponding repository is in https://github.com/Roboy/RoboyUnityFace

First step: - Installation of Unity

For starting with RoboyUnityFace, clone the repository to your device. All existing animations are stored in RoboyUnityFace/assets/animations. Corresponding material (pictures to show them on the face, e.g. a moustache or sunglasses) are stored in RoboyUnityFace/assets/FaceComponents.

The connection to ROS (C#) is located in RoboyUnityFace/assets/RoboyAnimator.cs 
For communicating with other systems (ROS, dialogue etc.), the offlineToggle must be set to false. This can be done by pressing the letter O  when RoboyFace is running. 

Animations can get triggered from dialog system with this code snippet.  

```
if (emotion == "tongue")
            anim.SetTrigger("tongue_out");
```
In addition to that, animations can be triggered manually via the keyboard by pressing buttons: 

```
if (Input.GetKeyDown(KeyCode.Q))
            SetEmotion("happy");
```

The following emotions can be triggered via the keyboard:

S - Shy, E - Money, K - Kiss, L - lookleft, R - lookright, B - blink, W - smileblink, D - tongue out, Q - happy, Y - lucky, H - Hearts, N - pissed, A - angry, X - irritated , V - hypno eyes, U - coloured hypno eyes, I - rolling eyes, Z - surprised , P - pirate (boolean, key needs to be pressed again to stop animation), C - crying Roboy (boolean, key needs to be pressed again to stop animation), G - glasses (boolean, key needs to be pressed again to stop animation), M - moustache (boolean, key needs to be pressed again to stop animation), F - pink, sunglasses (boolean, key needs to be pressed again to stop animation)


## How to get started? How to get animations running in Unity? 

Go to RoboyUnityFace/Assets and open RoboyFace. Unity will open. 

Having started RoboyFace in Unity,there is a Project window. For viewing all existing animations, first click on "face" in the Project Window. In a second step, open the "Animator" window. For viewing existing animations, press the play button on the top and trigger the animations in the "Animator" (Parameters) window. All animations can also be triggered via the keyboard. The shortcuts for the animations are in the upper part ("Prerequesites"). New animations can be added via the Animation window (if the animation or the Animator window is not shown, you can open it by clicking on the "Window" button at the bar on the top of Unity program).

For all current and new animations, there is the Inspector on the right hand side, which has different functions for changing or modifying existing and new animations.

If you create a new animation, a transition from idle state to the animation state is necessary to get the animations running. This can be done in the Animator window. Transitions from the animation state back to the idle state are also necessary to stop the animations.

In addition to the old faces and expressions in Unity, the following faces & emotions were added in SS18 and can be triggered via ROS:

tongue out, happy, lucky, pissed, angry, irritated, hypno eyes, coloured hypno eyes, rolling eyes, surprised, pirate ,crying Roboy, glasses, moustache, pink sunglasses

## Emotions

In order to start the animations, it is necessary to disconnect from ROS. Otherwise, Unity will show an error message and the play mode cannot be entered. This can be avoided by changing the code in RoboyUnityFace/Assets/RoboyAnimator.cs . The line which must be changed looks like follows. In this line of code, the offline toggle should be set to true.

```
bool offlineToggle = true;
```

The offlineToggle can also be set to true or false by pressing O (oh) on the keyboard. 

Now, all existing animations can be triggered in Unity by starting the play mode and by triggering animations in the Animator column.

Additional faces could be added. Useful tutorials for starting with Unity can be found on YouTube and on the Unity homepage.
