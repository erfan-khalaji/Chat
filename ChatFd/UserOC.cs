// **************************************************************************************************
//		CUserOC
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
  public class CUserOC : Racon.RtiLayer.HlaObjectClass
  {
    #region Declarations
    public Racon.RtiLayer.HlaAttribute NickName;
    public Racon.RtiLayer.HlaAttribute Status;
    #endregion //Declarations
    
    #region Constructor
    public CUserOC() : base()
    {
      // Initialize Class Properties
      this.Name = "ObjectRoot.User";
      this.ClassPS = Racon.PSKind.PublishSubscribe;
      
      // Create Attributes
      // NickName
      NickName = new Racon.RtiLayer.HlaAttribute("NickName", Racon.PSKind.PublishSubscribe);
      this.Attributes.Add(NickName);
      // Status
      Status = new Racon.RtiLayer.HlaAttribute("Status", Racon.PSKind.PublishSubscribe);
      this.Attributes.Add(Status);
    }
    #endregion //Constructor
  }
}
