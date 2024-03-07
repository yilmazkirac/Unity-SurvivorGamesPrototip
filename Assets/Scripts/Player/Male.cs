using UnityEngine;

public class Male : MonoBehaviour
{
    public GameObject[] Head;
    public GameObject[] Mask;
    public GameObject[] Eyebrows;
    public GameObject[] FacialHair;
    public GameObject[] Torso;
    public GameObject[] Arm_Upper_Right;
    public GameObject[] Arm_Upper_Left;
    public GameObject[] Arm_Lower_Right;
    public GameObject[] Arm_Lower_Left;
    public GameObject[] Hand_Right;
    public GameObject[] Hand_Left;
    public GameObject[] Hips;
    public GameObject[] Leg_Right;
    public GameObject[] Leg_Left;

    public int currentHeadIndex;
    public int currentMaskIndex;
    public int currentEyebrowsIndex;
    public int currentFacialHairIndex;
    public int currentTorsoIndex;
    public int currentArm_Upper_RightIndex;
    public int currentArm_Upper_LeftIndex;
    public int currentArm_Lower_RightIndex;
    public int currentArm_Lower_LeftIndex;
    public int currentHand_RightIndex;
    public int currentHand_LeftIndex;
    public int currentHipsIndex;
    public int currentLeg_RightIndex;
    public int currentLeg_LeftIndex;

    private void Start()
    {
        GetCost();
        UpdateCost();
    }
    public void SaveCost()
    {
        PlayerPrefs.SetInt("currentHeadIndex", currentHeadIndex);
        PlayerPrefs.SetInt("currentMaskIndex", currentMaskIndex);
        PlayerPrefs.SetInt("currentEyebrowsIndex", currentEyebrowsIndex);
        PlayerPrefs.SetInt("currentFacialHairIndex", currentFacialHairIndex);
        PlayerPrefs.SetInt("currentTorsoIndex", currentTorsoIndex);
        PlayerPrefs.SetInt("currentArm_Upper_RightIndex", currentArm_Upper_RightIndex);
        PlayerPrefs.SetInt("currentArm_Upper_LeftIndex", currentArm_Upper_LeftIndex);
        PlayerPrefs.SetInt("currentArm_Lower_RightIndex", currentArm_Lower_RightIndex);
        PlayerPrefs.SetInt("currentArm_Lower_LeftIndex", currentArm_Lower_LeftIndex);
        PlayerPrefs.SetInt("currentHand_RightIndex", currentHand_RightIndex);
        PlayerPrefs.SetInt("currentHand_LeftIndex", currentHand_LeftIndex);
        PlayerPrefs.SetInt("currentHipsIndex", currentHipsIndex);
        PlayerPrefs.SetInt("currentLeg_RightIndex", currentLeg_RightIndex);
        PlayerPrefs.SetInt("currentLeg_LeftIndex", currentLeg_LeftIndex);        
    }
    public void GetCost()
    {
        currentHeadIndex= PlayerPrefs.GetInt("currentHeadIndex");
        currentMaskIndex = PlayerPrefs.GetInt("currentMaskIndex");
        currentEyebrowsIndex = PlayerPrefs.GetInt("currentEyebrowsIndex");
        currentFacialHairIndex = PlayerPrefs.GetInt("currentFacialHairIndex");
        currentTorsoIndex = PlayerPrefs.GetInt("currentTorsoIndex");
        currentArm_Upper_RightIndex= PlayerPrefs.GetInt("currentArm_Upper_RightIndex");
        currentArm_Upper_LeftIndex = PlayerPrefs.GetInt("currentArm_Upper_LeftIndex");
        currentArm_Lower_RightIndex = PlayerPrefs.GetInt("currentArm_Lower_RightIndex");
        currentArm_Lower_LeftIndex = PlayerPrefs.GetInt("currentArm_Lower_LeftIndex");
        currentHand_RightIndex = PlayerPrefs.GetInt("currentHand_RightIndex");
        currentHand_LeftIndex = PlayerPrefs.GetInt("currentHand_LeftIndex");
        currentHipsIndex = PlayerPrefs.GetInt("currentHipsIndex");
        currentLeg_RightIndex = PlayerPrefs.GetInt("currentLeg_RightIndex");
        currentLeg_LeftIndex = PlayerPrefs.GetInt("currentLeg_LeftIndex");
    }


    public void SetCostumUp(string objeName)
    {
        switch (objeName)
        {
            case "Head":
                currentHeadIndex += 1;
                IndexCheck(objeName);
                Set(currentHeadIndex, Head);
                break;

            case "Mask":
                currentMaskIndex += 1;
                IndexCheck(objeName);
                Set(currentMaskIndex,Mask);
                break;
            case "Eyebrows":
                currentEyebrowsIndex += 1;
                IndexCheck(objeName);
                Set(currentEyebrowsIndex, Eyebrows);
                break;
            case "FacialHair":
                currentFacialHairIndex += 1;
                IndexCheck(objeName);
                Set(currentFacialHairIndex, FacialHair);
                break;
            case "Torso":
                currentTorsoIndex += 1;
                IndexCheck(objeName);
                Set(currentTorsoIndex, Torso);
                break;
            case "Arm_Upper_Right":
                currentArm_Upper_RightIndex += 1;
                IndexCheck(objeName);
                Set(currentArm_Upper_RightIndex, Arm_Upper_Right);
                break;
            case "Arm_Upper_Left":
                currentArm_Upper_LeftIndex += 1;
                IndexCheck(objeName);
                Set(currentArm_Upper_LeftIndex, Arm_Upper_Left);
                break;
            case "Arm_Lower_Right":
                currentArm_Lower_RightIndex += 1;
                IndexCheck(objeName);
                Set(currentArm_Lower_RightIndex, Arm_Lower_Right);
                break;
            case "Arm_Lower_Left":
                currentArm_Lower_LeftIndex += 1;
                IndexCheck(objeName);
                Set(currentArm_Lower_LeftIndex, Arm_Lower_Left);
                break;
            case "Hand_Right":
                currentHand_RightIndex += 1;
                IndexCheck(objeName);
                Set(currentHand_RightIndex, Hand_Right);
                break;
            case "Hand_Left":
                currentHand_LeftIndex += 1;
                IndexCheck(objeName);
                Set(currentHand_LeftIndex, Hand_Left);
                break;
            case "Hips":
                currentHipsIndex += 1;
                IndexCheck(objeName);
                Set(currentHipsIndex, Hips);
                break;
            case "Leg_Right":
                currentLeg_RightIndex += 1;
                IndexCheck(objeName);
                Set(currentLeg_RightIndex, Leg_Right);
                break;
            case "Leg_Left":
                currentLeg_LeftIndex += 1;
                IndexCheck(objeName);
                Set(currentLeg_LeftIndex, Leg_Left);
                break;
        }
    }
    public void SetCostumDown(string objeName)
    {
        switch (objeName)
        {
            case "Head":
                currentHeadIndex -= 1;
                IndexCheck(objeName);
                Set(currentHeadIndex, Head);
                break;

            case "Mask":
                currentMaskIndex -= 1;
                IndexCheck(objeName);
                Set(currentMaskIndex, Mask);
                break;
            case "Eyebrows":
                currentEyebrowsIndex -= 1;
                IndexCheck(objeName);
                Set(currentEyebrowsIndex, Eyebrows);
                break;
            case "FacialHair":
                currentFacialHairIndex -= 1;
                IndexCheck(objeName);
                Set(currentFacialHairIndex, FacialHair);
                break;
            case "Torso":
                currentTorsoIndex -= 1;
                IndexCheck(objeName);
                Set(currentTorsoIndex, Torso);
                break;
            case "Arm_Upper_Right":
                currentArm_Upper_RightIndex -= 1;
                IndexCheck(objeName);
                Set(currentArm_Upper_RightIndex, Arm_Upper_Right);
                break;
            case "Arm_Upper_Left":
                currentArm_Upper_LeftIndex -= 1;
                IndexCheck(objeName);
                Set(currentArm_Upper_LeftIndex, Arm_Upper_Left);
                break;
            case "Arm_Lower_Right":
                currentArm_Lower_RightIndex -= 1;
                IndexCheck(objeName);
                Set(currentArm_Lower_RightIndex, Arm_Lower_Right);
                break;
            case "Arm_Lower_Left":
                currentArm_Lower_LeftIndex -= 1;
                IndexCheck(objeName);
                Set(currentArm_Lower_LeftIndex, Arm_Lower_Left);
                break;
            case "Hand_Right":
                currentHand_RightIndex -= 1;
                IndexCheck(objeName);
                Set(currentHand_RightIndex, Hand_Right);
                break;
            case "Hand_Left":
                currentHand_LeftIndex -= 1;
                IndexCheck(objeName);
                Set(currentHand_LeftIndex, Hand_Left);
                break;
            case "Hips":
                currentHipsIndex -= 1;
                IndexCheck(objeName);
                Set(currentHipsIndex, Hips);
                break;
            case "Leg_Right":
                currentLeg_RightIndex -= 1;
                IndexCheck(objeName);
                Set(currentLeg_RightIndex, Leg_Right);
                break;
            case "Leg_Left":
                currentLeg_LeftIndex -= 1;
                IndexCheck(objeName);
                Set(currentLeg_LeftIndex, Leg_Left);
                break;
        }
    }

 
    private void Set(int currentIndex, GameObject[] obje)
    {
        foreach (var item in obje)
        {
            item.SetActive(false);
        }
        int index=0;
        index = currentIndex;
    
        if (index > obje.Length - 1)
        {
            index = 0;
        }
        else if (index < 0)
        {
            index = obje.Length - 1;
        }
        obje[index].SetActive(true);
    }

    private void IndexCheck(string index)
    {
        switch (index)
        {
            case "Head":
                if (currentHeadIndex > Head.Length - 1)
                {
                    currentHeadIndex = 0;
                }
                else if (currentHeadIndex < 0)
                {
                    currentHeadIndex = Head.Length - 1;
                }
                break;
            case "Mask":
                if (currentMaskIndex > Mask.Length - 1)
                {
                    currentMaskIndex = 0;
                }
                else if (currentMaskIndex < 0)
                {
                    currentMaskIndex = Mask.Length - 1;
                }
                break;
            case "Eyebrows":
                if (currentEyebrowsIndex > Eyebrows.Length - 1)
                {
                    currentEyebrowsIndex = 0;
                }
                else if (currentEyebrowsIndex < 0)
                {
                    currentEyebrowsIndex = Eyebrows.Length - 1;
                }
                break;
            case "FacialHair":
                if (currentFacialHairIndex > FacialHair.Length - 1)
                {
                    currentFacialHairIndex = 0;
                }
                else if (currentFacialHairIndex < 0)
                {
                    currentFacialHairIndex = FacialHair.Length - 1;
                }
                break;
            case "Torso":
                if (currentTorsoIndex > Torso.Length - 1)
                {
                    currentTorsoIndex = 0;
                }
                else if (currentTorsoIndex < 0)
                {
                    currentTorsoIndex = Torso.Length - 1;
                }
                break;
            case "Arm_Upper_Right":
                if (currentArm_Upper_RightIndex > Arm_Upper_Right.Length - 1)
                {
                    currentArm_Upper_RightIndex = 0;
                }
                else if (currentArm_Upper_RightIndex < 0)
                {
                    currentArm_Upper_RightIndex = Arm_Upper_Right.Length - 1;
                }
                break;
            case "Arm_Upper_Left":
                if (currentArm_Upper_LeftIndex > Arm_Upper_Left.Length - 1)
                {
                    currentArm_Upper_LeftIndex = 0;
                }
                else if (currentArm_Upper_LeftIndex < 0)
                {
                    currentArm_Upper_LeftIndex = Arm_Upper_Left.Length - 1;
                }
                break;
            case "Arm_Lower_Right":
                if (currentArm_Lower_RightIndex > Arm_Lower_Right.Length - 1)
                {
                    currentArm_Lower_RightIndex = 0;
                }
                else if (currentArm_Lower_RightIndex < 0)
                {
                    currentArm_Lower_RightIndex = Arm_Lower_Right.Length - 1;
                }
                break;
            case "Arm_Lower_Left":
                if (currentArm_Lower_LeftIndex > Arm_Lower_Left.Length - 1)
                {
                    currentArm_Lower_LeftIndex = 0;
                }
                else if (currentArm_Lower_LeftIndex < 0)
                {
                    currentArm_Lower_LeftIndex = Arm_Lower_Left.Length - 1;
                }
                break;
            case "Hand_Right":
                if (currentHand_RightIndex > Hand_Right.Length - 1)
                {
                    currentHand_RightIndex = 0;
                }
                else if (currentHand_RightIndex < 0)
                {
                    currentHand_RightIndex = Hand_Right.Length - 1;
                }
                break;
            case "Hand_Left":
                if (currentHand_LeftIndex > Hand_Left.Length - 1)
                {
                    currentHand_LeftIndex = 0;
                }
                else if (currentHand_LeftIndex < 0)
                {
                    currentHand_LeftIndex = Hand_Left.Length - 1;
                }
                break;
            case "Hips":
                if (currentHipsIndex > Hips.Length - 1)
                {
                    currentHipsIndex = 0;
                }
                else if (currentHipsIndex < 0)
                {
                    currentHipsIndex = Hips.Length - 1;
                }
                break;
            case "Leg_Right":
                if (currentLeg_RightIndex > Leg_Right.Length - 1)
                {
                    currentLeg_RightIndex = 0;
                }
                else if (currentLeg_RightIndex < 0)
                {
                    currentLeg_RightIndex = Leg_Right.Length - 1;
                }
                break;
            case "Leg_Left":
                if (currentLeg_LeftIndex > Leg_Left.Length - 1)
                {
                    currentLeg_LeftIndex = 0;
                }
                else if (currentLeg_LeftIndex < 0)
                {
                    currentLeg_LeftIndex = Leg_Left.Length - 1;
                }
                break;

        }
    }

    private void UpdateCost()
    {
        Set(currentHeadIndex, Head);
        Set(currentMaskIndex, Mask);
        Set(currentEyebrowsIndex, Eyebrows);
        Set(currentFacialHairIndex, FacialHair);
        Set(currentTorsoIndex, Torso);
        Set(currentArm_Upper_RightIndex, Arm_Upper_Right);
        Set(currentArm_Upper_LeftIndex, Arm_Upper_Left);
        Set(currentArm_Lower_RightIndex, Arm_Lower_Right);
        Set(currentArm_Lower_LeftIndex, Arm_Lower_Left);
        Set(currentHand_RightIndex, Hand_Right);
        Set(currentHand_LeftIndex, Hand_Left);
        Set(currentHipsIndex, Hips);
        Set(currentLeg_RightIndex, Leg_Right);
        Set(currentLeg_LeftIndex, Leg_Left);
    }
    public void ResetCost()
    {
        PlayerPrefs.SetInt("currentHeadIndex", 0);
        PlayerPrefs.SetInt("currentMaskIndex", 0);
        PlayerPrefs.SetInt("currentEyebrowsIndex", 0);
        PlayerPrefs.SetInt("currentFacialHairIndex", 0);
        PlayerPrefs.SetInt("currentTorsoIndex", 0);
        PlayerPrefs.SetInt("currentArm_Upper_RightIndex", 0);
        PlayerPrefs.SetInt("currentArm_Upper_LeftIndex", 0);
        PlayerPrefs.SetInt("currentArm_Lower_RightIndex", 0);
        PlayerPrefs.SetInt("currentArm_Lower_LeftIndex", 0);
        PlayerPrefs.SetInt("currentHand_RightIndex", 0);
        PlayerPrefs.SetInt("currentHand_LeftIndex", 0);
        PlayerPrefs.SetInt("currentHipsIndex", 0);
        PlayerPrefs.SetInt("currentLeg_RightIndex", 0);
        PlayerPrefs.SetInt("currentLeg_LeftIndex", 0);


        GetCost();
        UpdateCost();
    }
}
