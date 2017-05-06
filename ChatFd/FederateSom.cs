// **************************************************************************************************
//		FederateSom
//
//		generated
//			by		: 	Simulation Generator (SimGe) v.0.2.4
//			at		: 	Saturday, March 8, 2014 4:21:16 PM
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
  public class FederateSom : Racon.ObjectModel.CObjectModel
  {
    #region Declarations
    #region SOM Declaration
    public Chat_DDM.Som.CUserOC UserOC;
    public Chat_DDM.Som.CChatIC ChatIC;
    public Chat_DDM.Som.CChatWorldSpace ChatWorldSpace;
    #endregion
    #endregion //Declarations

    #region Constructor
    public FederateSom()
      : base()
    {
      // Construct SOM
      UserOC = new Chat_DDM.Som.CUserOC();
      this.AddToObjectModel(UserOC);
      ChatIC = new Chat_DDM.Som.CChatIC();
      this.AddToObjectModel(ChatIC);
      ChatWorldSpace = new Chat_DDM.Som.CChatWorldSpace();
      this.AddToObjectModel(ChatWorldSpace);
    }
    #endregion //Constructor
  }
}
