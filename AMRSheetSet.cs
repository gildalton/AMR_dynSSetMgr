﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using ACSMCOMPONENTS24Lib;
using Autodesk.DesignScript.Runtime;
using AXDBLib;

namespace AMR.dynSSetMgr
{
    [IsVisibleInDynamoLibrary(false)]
    public class AMRSheetSet
    {
        AcSmSheetSet _curSheetSet;

        [IsVisibleInDynamoLibrary(false)]
        public AMRSheetSet(AcSmSheetSet sheetSetFromSSMgr)
        {
            _curSheetSet = sheetSetFromSSMgr;
        }
        [IsVisibleInDynamoLibrary(false)]
        public AcSmSheetSet BaseObject()
        {
            return _curSheetSet;
        }
    }
}
