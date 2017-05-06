// **************************************************************************************************
//		CChatWorldSpace
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
/// This class is extended from the routing space model of Racon API
/// </summary>

using System;

namespace Chat_DDM.Som
{
  public class CChatWorldSpace : Racon.ObjectModel.CRoutingSpace
  {
    #region Declarations
    // Dimensions
    // Regions - Manually declare regions such as:
    // public Racon.RtiLayer.CHlaRegion Room1Region;
    // Region Extents - Manually declare region extents such as:
    // public private Racon.RtiLayer.CHlaExtent exOd1;

    // Dimensions
    private Racon.ObjectModel.CDimension Rooms;
    // Regions
    public Racon.ObjectModel.CRegion Room1Region;
    public Racon.ObjectModel.CRegion Room2Region;
    public Racon.ObjectModel.CRegion Oda0Region;
    // Region Extents
    private Racon.ObjectModel.CExtent exOd1;
    private Racon.ObjectModel.CExtent exOd2;
    #endregion //Declarations
    
    #region Constructor
    public CChatWorldSpace() : base("ChatWorld")
    {
      // Create Dimensions
      Rooms = new Racon.ObjectModel.CDimension("Rooms", this);
      this.Dimensions.Add(Rooms);
      // Create Extensions
      exOd1 = new Racon.ObjectModel.CExtent(Rooms, 2, 3);
      exOd2 = new Racon.ObjectModel.CExtent(Rooms, 4, 5);

      // Room1 Region (2-3)
      Room1Region = new Racon.ObjectModel.CRegion("Room1Region");
      Room1Region.Extents.Add(exOd1);// Add extent to the region
      this.Regions.Add(Room1Region);// Add region to the Space
      // Room2 Region (4-5)
      Room2Region = new Racon.ObjectModel.CRegion("Room2Region");
      Room2Region.Extents.Add(exOd2);// Add extent to the region      
      this.Regions.Add(Room2Region);// Add region to the Space
    }
    #endregion //Constructor
  }
}
