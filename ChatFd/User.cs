// ***************************************************************************
//		
//		copyright	: 	(C) Okan Topcu
//		email			: 	okantopcu@gmail.com
// ***************************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Racon.RtiLayer;
using System.Runtime.InteropServices; // StructLayout

namespace Chat_DDM
{
  public enum StatusTypes { hazır, chatte };

  public class CUser : Racon.RtiLayer.HlaObject
  {
    private String _nickName;
    private StatusTypes _status;

    // NickName_User
    public string NickName
    {
      get { return _nickName; }
      set { _nickName = value; }
    }
    // Status_User
    public StatusTypes Status
    {
      get { return _status; }
      set { _status = value; }
    }

    public CUser(Racon.RtiLayer.HlaObjectClass _type) : base(_type)
    {
      // Local Data
      NickName = "Guest";
      Status = StatusTypes.hazır;
    }
    public CUser(Racon.RtiLayer.HlaObjectClass _type, Racon.RtiLayer.HlaObjectEventArgs _obj)
      : base(_type, _obj)
    {
      // Local Data
      NickName = "Guest";
      Status = StatusTypes.hazır;
    }

  }
}
