using CrazyMinnow.SALSA;
using UnityEngine;

public class SalsaVisemeTriggerEventSubscriber : MonoBehaviour
{
	
	[SerializeField] private Salsa salsaInstance;

   



    private void OnEnable()
	{
		
	}

	private void OnDisable()
	{
		
	}

	private void SalsaOnVisemeTriggered(object sender, Salsa.SalsaNotificationArgs e)
	{
		if (e.salsaInstance == salsaInstance)
		{
			// here should e.visemeTrigger  & salsaInstance.CachedAnalysisValue be published to ROS


			Debug.Log("Viseme (Index) triggered: " + e.visemeTrigger);
            Debug.Log("Cached analysis value: " + salsaInstance.CachedAnalysisValue);
       


        }
	}

   
}
