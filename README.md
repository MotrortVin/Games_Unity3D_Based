# Unity3D_VR_Projects
---
## Abstract:
Nowadays, people are living under great pressure, and nearly 80 percent of them are in sub-health, according to some surveys. Nearly half a million people in China are killed by sudden cardiac death each year, while China has less control over cardiopulmonary resuscitation than other developed countries, leading to a lower survival rate. The popularization of cardiopulmonary resuscitation is urgent.

Cardiopulmonary resuscitation (CPR) electronic training system (CPR_VR - a set of anytime, anywhere can be a highly specialized CPR training programs), based on MRTK, using the Unity and development, set up four VR training platform: "CPR_VR basic operation training," "the story situation exercises training", "cardiopulmonary resuscitation (CPR) pressure plate special training" and "special training" AED combination plate. The training process includes first aid call, life feature detection, chest compressive assessment and AED instruction. Users can conduct unnecessary training according to their different needs.

At the same time, the training system combining Ardiuno, collect data from the flexible thin film pressure sensor, and established a set of relatively complete cardiopulmonary resuscitation (CPR) training system, the position of the head of our VR Davis showed, and the pressure feedback, using AI algorithms, such as the specific performance of the operator for feedback and error correction promptly, and at the end of the operation, combined with the user's performance in the whole process of score evaluation, thus a good training effect.

Cardiopulmonary resuscitation (CPR) electronic training system in training at the same time, also introduced the national laws and first aid knowledge of popular science, let everybody in CPR and first aid and rescue them a more wide range of cognitive, this system compared with the traditional lecture, the coverage is more complete, training more scientific, more comprehensive content, the scene more realistic, therefore also had the high efficiency, convenience and professional.
In the future, with the promotion and popularization of VR equipment, CPR_VR technology will be able to enter thousands of households, and people can conduct highly specialized CPR training at any time and anywhere.

**Key words: CPR, VR, AI**
---
## 软件设计
在软件方面，我们选择使用当前VR开发比较常用的Unity3D进行开发，整体流程使用协程控制。先后展开模型搭建，动画制作，协程编写，功能实现，语音导入，硬件结合，算法编写，测试修改等多个步骤。

模型搭建和动画设计过程中，我们采用3Dmax进行模型的搭建，骨骼的配置和动画的制作。在具体功能的实现上，我们优化了UI，结合VR的特征，选择加入了凝视操作；配音环节，我们经过不断的优化，进行配音工作，使得整个培训系统更加完整。我们对头显的位置进行追踪，结合薄膜柔性压力传感器的数据反馈，我们使用AI算法实现了对频率和深度的检测。而在测试调整环节，我们继续进行完善和微调，加入了国家法律显示等细节，使得整个培训完整而全面。

我们的应用型软件为“CPR_VR”，是一套可以用Vive等当前常用的VR头显操控的VR培训系统。一共五个场景，包括一个主场景和四个培训场景。进入环形主界面后，用户可以选择进入“CPR_VR基础操作培训”，“地铁故事情境演习培训”，“心肺复苏按压板块专项培训”以及“AED结合板块专项培训”。用户可通过凝视的操作实现培训的选择。

我们的培训整体脱离steamVR平台，基于MRTK进行开发，发布后，可以脱离steam平台独立使用。

---
## 软件流程
在四个培训板块中，分工明确，各有专长。

首先，在第一板块：“CPR_VR基础操作培训”的板块中，用户将在我们的带领下学习如何在场景中移动，转向，瞬移，选择，凝视和退出，本培训板块为剩余三大板块的基础，用户可以通过本板块迅速掌握VR头显和手柄各个按键和设备的功能。

第二板块为“地铁情景急救培训模式”，体验者将会被带到一个真实的地铁场景中，地铁中人流涌动，摩肩接踵。随着故事的发展，会有人突然晕倒，这时，需要体验者去确认其是否有意识，在没有意识的情况下，拨打120急救，并在急救人员的带领下进行呼吸和脉搏的检测，继续脱衣施救，展开胸外按压，最后急救人员赶到现场，头显上播放国家法律中对急救的相关规定。在胸外按压过程中，我们将结合硬件与AI算法展开按压频率和深度的检测以及错误动作的纠正操作，在按压结束后，我们将通过算法对操作者的按压效果给出成绩评估。

第三板块是“心肺复苏按压板块专项训练”，虽然在故事情境模式中，我们的培训更加系统化，全面化，但是最容易犯错，最难以培训的按压过程可能没有得到很好的培训效果，因此我们单独建立一个板块，进行心肺复苏按压部分的培训。

第四板块是“AED结合板块专项培训”，在CPR技术的施展过程中，如果可以加入AED的使用，可以大大提高患者的生还率，而当今AED在我们周边相当普及，会使用的人却并不多，因而我们单独建立AED使用板块，进行AED的培训，包括提取AED，启动AED，张贴电极贴片，分析心率，除颤等过程。
