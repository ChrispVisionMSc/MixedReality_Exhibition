# MixedReality_Exhibition

Unity Version 2022.38f1
Based on Unity Universal 3D Template.

Additional Packages:
Meta XR All-in-One SDK v71.0.0
XR Plugin Managemnt v4.5.0

This is a mixed reality application designed to run on the Meta_Quest-3 headset.
This app may also run on the Meta-3s headset but not tested.

The app is designed to work specifically within the Temporary Science Exhibition gallery at National Museum Wales in Cardiff.

However it is possible to run the app within a large room of approximately 10 x 10 metres or larger.
To run the app it is first necessary to set up a room space using the Meta Horizon OS.
See link here for guidance on doing this. https://www.youtube.com/watch?v=v5hMgoAgcsU
A furniture item called 'other' will need to be added at the centre of the room space as the app uses this as an anchor point to spawn the mixed reality experience.

There are 3 scenes in the Unnity Project:
MRUK Exhibiiton Test Master - This is used as a template to save new scenes that can be set up for specific rooms or devices.
MRUK Exhibiiton Test V1 - This Scene references anchor prefabs AnchorGalleryModel V1 & AnchorInteractives V1 that have Transforms of X=(0) Y=(0) Z=(0)
MRUK Exhibiiton Test V2 - This Scene references anchor prefabs AnchorGalleryModel V2 & AnchorInteractives V2 that have Transforms of X=(0.18) Y=(0) Z=(-1.42)
These V2 prefabs are adjusted to allign the MR Exhibition Model with the Science Tempex Gallery rooms scans at National Museum Wales.

NB!! When building an APK file first check Meta XR Project Setup Tools to ensure all recommended fixes are applied (this does not seem to auto save in the project).
