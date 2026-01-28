// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.GridModule.dll
// Classes:  3
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

namespace UnityEngine
{

    // TypeToken: 0x2000002
    public class Grid : GridLayout
    {
        // Methods
        private UnityEngine.Vector3 get_cellSize() { }
        private System.Void .ctor() { }
        private System.Void get_cellSize_Injected(UnityEngine.Vector3& ret) { }

    }

    // TypeToken: 0x2000003
    public class GridLayout : Behaviour
    {
        // Methods
        private UnityEngine.Vector3 CellToLocal(UnityEngine.Vector3Int cellPosition) { }
        private System.Void DoNothing() { }
        private System.Void .ctor() { }
        private System.Void CellToLocal_Injected(UnityEngine.Vector3Int& cellPosition, UnityEngine.Vector3& ret) { }

    }

}

