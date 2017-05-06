// **************************************************************************************************
//		CChatIC
//
//		generated
//			by		: 	Simulation Generator (SimGe) v.0.2.4
//			at		: 	Saturday, March 8, 2014 3:51:42 PM
//		compatible with		: 	Racon v.0.0.1.2
//
//		copyright		: 	(C) 
//		email			: 	
// **************************************************************************************************
/// <summary>
/// This class is extended from the object model of Racon API
/// </summary>

using System;
using Racon;

namespace Chat_DDM.Som
{
  public class CChatIC : Racon.RtiLayer.HlaInteractionClass
  {
    #region Declarations
    public Racon.RtiLayer.HlaParameter Sender;
    public Racon.RtiLayer.HlaParameter Message;
    public Racon.RtiLayer.HlaParameter TimeStamp;
    #endregion //Declarations
    
    #region Constructor
    public CChatIC() : base()
    {
      // Initialize Class Properties
      this.Name = "InteractionRoot.Chat";
      this.ClassPS = Racon.PSKind.PublishSubscribe;
      
      // Create Parameters
      // Sender
      Sender = new Racon.RtiLayer.HlaParameter("Sender");
      this.Parameters.Add(Sender);
      // Message
      Message = new Racon.RtiLayer.HlaParameter("Message");
      this.Parameters.Add(Message);
      // TimeStamp
      TimeStamp = new Racon.RtiLayer.HlaParameter("TimeStamp");
      this.Parameters.Add(TimeStamp);
    }
    #endregion //Constructor
  }
}
