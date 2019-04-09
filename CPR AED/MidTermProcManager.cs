using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRStandardAssets.Utils;

public class MidTermProcManager : MonoBehaviour {
    /*
     *      Initialization
     */
    private GameObject standBody;
    private GameObject faintBody;
    private GameObject bareFaintBody;
    private GameObject bigPhone;
    private GameObject smallPhone;
    private GameObject AED;
    private GameObject nose;
    private GameObject shoulder;
    private GameObject neck;
    private GameObject middlePhone;
    private GameObject TVscreen;
    private int n = 0;
    public AudioSource playAudioCurrent;
    public AudioSource noise;
    public AudioClip liuTwo;
    public AudioClip liuThree;
    public AudioClip faintDetect;
    public AudioClip faintAnnounce;
    public AudioClip liuFour;
    public AudioClip liuFive;
    public AudioClip liuSix;
    public AudioClip liuSeven;
    public AudioClip liOne;
    public AudioClip liTwo;
    public AudioClip liThree;
    public AudioClip liFour;
    public AudioClip liFive;
    public AudioClip liSix;
    public AudioClip liSeven;
    public AudioClip liEight;
    public AudioClip liNine;
    public AudioClip liTen;
    public AudioClip liEleven;
    public AudioClip liTwelve;
    public AudioClip liThirteen;
    public AudioClip liFourteen;
    public AudioClip count;
    public AudioClip liFifteen;
    public AudioClip ambulance;
    /*
     *      Start UI
     */
    [SerializeField] private UIFader cpr_Start;
	[SerializeField] private SelectionSlider cpr_StartConfirm;
	/*
     *      Check AED UI
     */
	[SerializeField] private FallDown cpr_AEDController;
	[SerializeField] private UIFader cpr_CheckAED;
    /*
     *      Check Person UI
     */
    [SerializeField] private TurnVisible cpr_LeftShoulderVisible;
    [SerializeField] private TurnVisible cpr_RightShoulderVisible;
    [SerializeField] private TurnVisible cpr_NeckVisible;
    [SerializeField] private TurnVisible cpr_NoseVisible;
    [SerializeField] private UIFader cpr_CheckPerson;
	[SerializeField] private CheckPerson cpr_PersonController;
	/*
     *      Dail UI
     */
	[SerializeField] private UIFader cpr_Dail;
	[SerializeField] private PickUpThePhone cpr_SetPhone;
	[SerializeField] private DailThePhone cpr_DailController;
	[SerializeField] private ClosedToBare cpr_Disrobe;
    /*
     *      Instruction UI
     */
    //[SerializeField] private UIFader cpr_Instruction;
	//[SerializeField] private FallDown cpr_CheckAED;

    /*
     *      Information UI
     */
    [SerializeField] private UIFader cpr_Information;
	[SerializeField] private TrainCPR cpr_TrainController;
    [SerializeField] private PutDownThePhone cpr_PutDownPhone;

    // Use this for initialization
    private IEnumerator Start()
	{
        playAudioCurrent.Play();
        standBody = GameObject.Find("Body/StandBody");
        TVscreen = GameObject.Find("_Level/TVscreen");
        faintBody = GameObject.Find("Body/FaintBody");
        bareFaintBody = GameObject.Find("Body/BareFaintBody");
        bigPhone = GameObject.Find("Phone/BigPhone");
        smallPhone = GameObject.Find("Phone/SmallPhone");
        AED = GameObject.Find("AED");
        nose = GameObject.Find("TestText/Nose");
        neck = GameObject.Find("TestText/Neck");
        shoulder = GameObject.Find("TestText/Shoulder");
        cpr_Disrobe = GameObject.Find("Body").transform.Find("FaintBody").gameObject.GetComponent<ClosedToBare>();
        middlePhone = GameObject.Find("Phone/MiddlePhone");
        //cpr_Start = GameObject.Find("GUI").transform.Find("StartGUI").gameObject.GetComponent<UIFader>();
        //cpr_CheckAED = GameObject.Find("GUI").transform.Find("CheckAEDGUI").gameObject.GetComponent<UIFader>();
        //initialization
        if (standBody == null) Debug.Log("MidTermProcManager : Can't find standing body!");
        else standBody.SetActive(true);
        if (TVscreen == null) Debug.Log("MidTermProcManager : Can't find TV screen!");
        else TVscreen.SetActive(false);
        if (AED == null) Debug.Log("MidTermProcManager : Can't find AED!");
        else AED.SetActive(true);
        if (faintBody == null) Debug.Log("MidTermProcManager : Can't find fainted body!");
        else faintBody.SetActive(false);
        if (bareFaintBody == null) Debug.Log("MidTermProcManager : Can't find bare fainted body!");
        else bareFaintBody.SetActive(false);
        if (bigPhone == null) Debug.Log("MidTermProcManager : Can't find big phone!");
        else bigPhone.SetActive(false);
		if (smallPhone == null) Debug.Log("MidTermProcManager : Can't find small phone!");
        else smallPhone.SetActive(true);
        if (nose == null) Debug.Log("MidTermProcManager : Can't find NoseText!");
        else nose.SetActive(false);
        if (neck == null) Debug.Log("MidTermProcManager : Can't find NeckText!");
        else neck.SetActive(false);
        if (shoulder == null) Debug.Log("MidTermProcManager : Can't find ShoulderText!");
        else shoulder.SetActive(false);
        if (middlePhone == null) Debug.Log("MidTermProcManager : Can't find middlephone!");
        else middlePhone.SetActive(false);

        yield return StartCoroutine(cpr_Start.InteruptAndFadeIn());
     
		yield return StartCoroutine(cpr_StartConfirm.WaitForBarToFill());

        playAudioCurrent.clip = liuTwo;
        playAudioCurrent.Play();
        yield return StartCoroutine(cpr_Start.InteruptAndFadeOut());
		yield return StartCoroutine(cpr_CheckAED.InteruptAndFadeIn());
		yield return StartCoroutine(cpr_AEDController.WaitForCheckingAED());
        playAudioCurrent.clip = liuThree;
        playAudioCurrent.Play();
        yield return new WaitForSeconds(4);
        yield return StartCoroutine(cpr_LeftShoulderVisible.Show());
        yield return StartCoroutine(cpr_RightShoulderVisible.Show());
        playAudioCurrent.clip = faintDetect;
        playAudioCurrent.Play();
        yield return new WaitForSeconds(12);
        playAudioCurrent.clip = faintAnnounce;
        playAudioCurrent.Play();
        yield return new WaitForSeconds(6);
        playAudioCurrent.clip = liuFour;
        playAudioCurrent.Play();
        yield return StartCoroutine(cpr_CheckAED.InteruptAndFadeOut());
        yield return StartCoroutine(cpr_Dail.InteruptAndFadeIn());
        yield return StartCoroutine(cpr_SetPhone.SetPhone());
        yield return StartCoroutine(cpr_DailController.StartDailing());
        yield return StartCoroutine(cpr_PutDownPhone.PutItDown());
        yield return StartCoroutine(cpr_Dail.InteruptAndFadeOut());
                
        playAudioCurrent.clip = liOne;
        playAudioCurrent.Play();
        yield return new WaitForSeconds(2);
        /*playAudioCurrent.clip = liuFive;
        playAudioCurrent.Play();
        yield return new WaitForSeconds(13);
        playAudioCurrent.clip = liTwo;
        playAudioCurrent.Play();
        yield return new WaitForSeconds(14);
        playAudioCurrent.clip = liuSix;
        playAudioCurrent.Play();
        yield return new WaitForSeconds(7);
        playAudioCurrent.clip = liThree;
        playAudioCurrent.Play();
        yield return new WaitForSeconds(5);
        playAudioCurrent.clip = liFour;
        playAudioCurrent.Play();
        yield return new WaitForSeconds(7);*/
        yield return StartCoroutine(cpr_CheckPerson.InteruptAndFadeIn());
        yield return StartCoroutine(cpr_NeckVisible.Show());
        yield return StartCoroutine(cpr_NoseVisible.Show());
        playAudioCurrent.clip = liFive;
        playAudioCurrent.Play();
        yield return new WaitForSeconds(16);
        yield return StartCoroutine(cpr_PersonController.WaitForCheckingPerson());
		yield return StartCoroutine(cpr_CheckPerson.InteruptAndFadeOut());
        yield return StartCoroutine(cpr_Information.InteruptAndFadeIn());
        
        playAudioCurrent.clip = liSix;
        playAudioCurrent.Play();
        yield return new WaitForSeconds(9);
        playAudioCurrent.clip = liSeven;
        yield return new WaitForSeconds(20);
        playAudioCurrent.Play();
        yield return StartCoroutine(cpr_Disrobe.CheckBare());
        noise.Stop();
        
        
        /*playAudioCurrent.clip = liEight;
        playAudioCurrent.Play();
        yield return new WaitForSeconds(10);*/
        playAudioCurrent.clip = liNine;
        playAudioCurrent.Play();
        yield return new WaitForSeconds(10);
        playAudioCurrent.clip = liTen;
        playAudioCurrent.Play();
        yield return new WaitForSeconds(4);
        playAudioCurrent.clip = liEleven;
        playAudioCurrent.Play();
        yield return new WaitForSeconds(4);
        playAudioCurrent.clip = liTwelve;
        playAudioCurrent.Play();
        yield return StartCoroutine(cpr_TrainController.LocomotionTracker());
        playAudioCurrent.clip = count;
        playAudioCurrent.loop = true;
        playAudioCurrent.Play();
        yield return new WaitForSeconds(30);
        playAudioCurrent.clip = ambulance;
        playAudioCurrent.volume = 0;
        playAudioCurrent.Play();
        while (n < 1000) { playAudioCurrent.volume += 0.001f; ++n; }
        yield return new WaitForSeconds(5);
        playAudioCurrent.loop = false;
        playAudioCurrent.clip = liuSeven;
        playAudioCurrent.Play();
        yield return new WaitForSeconds(3);
        playAudioCurrent.clip = liFifteen;
        playAudioCurrent.Play();
        yield return StartCoroutine(cpr_Information.InteruptAndFadeOut());
		//Debug.Log ("111");

    }
	
	// Update is called once per frame
	void Update () {
		//if (Input.GetKey(KeyCode.Space)) StartCoroutine(cpr_Instruction.InteruptAndFadeIn());
    }
}
