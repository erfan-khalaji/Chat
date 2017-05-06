// **************************************************************************************************
//		CSimulationManager
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
/// The Simulation Manager manages the (multiple) federation execution(s) and the (multiple instances of) joined federate(s).
/// </summary>

using System;
using System.ComponentModel;

using Racon;
namespace Chat_DDM
{
  public class CSimulationManager
  {

    #region Declarations
    // HLA Part (Communication Layer)
    // Federation Execution
    public Racon.Federation.CFederationExecution federation;
    // Application-specific Federate
    public CChatFd federate;
    // User Code
    public Form1 view;
    // The local data structures
    public BindingList<CUser> Users;    
    #endregion //Declarations
    
    #region Constructor
    public CSimulationManager(Form1 _form)
    {
      // Initialize the federation execution
      federation = new Racon.Federation.CFederationExecution();
      federation.Name = "TestFederation";
      federation.FDD = @".\SimGe_Chat_DDM.fed";
      // Initialize the application-specific federate
      federate = new CChatFd(this);

      // User Code
            view = _form;
      // Create Local Object - User
      Racon.RtiLayer.HlaObject user = new CUser(federate.Som.UserOC);
      // Populate the local user list for GUI
      Users = new BindingList<CUser>();
      Users.Add((CUser)user);
      // Set the type (object class) of the user object
      //user.Type = federate.UserOC;
      //MessageBox.Show("" + user.Type.ClassName + federate.som.OCList[0].AttributeList.Count());
    }
    #endregion //Constructor
    
  }
}
