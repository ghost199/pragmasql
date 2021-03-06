﻿/********************************************************************
  Class ShowTocMenuCommand
  Created On: $datetime$
  Created by: Ali Özgür
  Contact: ali_ozgur@hotmail.com
  
  Copyright: Ali Özgür
*********************************************************************/

using System;
using System.Collections.Generic;
using System.Text;

using ICSharpCode.Core;
using PragmaSQL.Core;

namespace HtmlHelp2
{
  public class ShowTocMenuCommand : AbstractMenuCommand
  {
    public override void Run( )
    {
      HtmlHelp2TocPad pad = HtmlHelp2TocPad.Current;
      if (pad == null)
      {
        HtmlHelp2TocPad.Current = new HtmlHelp2TocPad();
        pad = HtmlHelp2TocPad.Current;
        HostServicesSingleton.HostServices.ShowForm(pad, AddInDockState.DockRightAutoHide);
      }
      else
      {
        HostServicesSingleton.HostServices.ShowForm(pad);
      }
    }
  }
}
