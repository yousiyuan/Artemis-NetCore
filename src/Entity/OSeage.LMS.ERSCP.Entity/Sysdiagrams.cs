//*******************************
// Create By 流年 公子
// Date 2019-07-03 13:57
// Code Generate By SmartCode
// Code Generate Github : https://github.com/Ahoo-Wang/SmartCode
//*******************************

using System;
namespace OSeage.LMS.ERSCP.Entity
{

    ///<summary>
/// Table, sysdiagrams
///</summary>
    public class Sysdiagrams
    {
///<summary>
/// name, nvarchar
///</summary>
public string Name { get; set; }
///<summary>
/// principal_id, int
///</summary>
public int PrincipalId { get; set; }
///<summary>
/// diagram_id, int
///</summary>
public int DiagramId { get; set; }
///<summary>
/// version, int
///</summary>
public int? Version { get; set; }
///<summary>
/// definition, varbinary
///</summary>
public byte[] Definition { get; set; }
    }
    }

