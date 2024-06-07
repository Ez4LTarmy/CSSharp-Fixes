﻿using CounterStrikeSharp.API.Modules.Cvars;

namespace CSSharpFixes;

public partial class CSSharpFixes
{
    public FakeConVar<bool> EnableWaterFix = new("css_fixes_water_fix", "Fixes being stuck to the floor underwater, allowing players to swim up.", true);
    public FakeConVar<bool> EnableTriggerPushFix = new("css_fixes_trigger_push_fix", "Reverts trigger_push behaviour to that seen in CS:GO.", true);
    public FakeConVar<bool> EnableCPhysBoxUseFix = new("css_fixes_cphys_box_use_fix", "Fixes CPhysBox use. Make func_physbox pass itself as the caller in OnPlayerUse.", false);
    public FakeConVar<bool> EnableBlastDamageCrashFix = new("css_fixes_blast_damage_fix", "Blast damage would frequently cause whole server crashes.", false);
    //public FakeConVar<bool> EnableNavmeshLookupLagFix = new("css_fixes_navmesh_lookup_lag_fix", "Some maps with built navmeshes would cause tremendous lag.", false); // Commented out since it seems to cause crashes every time I test it...
    public FakeConVar<bool> EnableNoBlock = new("css_fixes_no_block", "Prevent players from blocking each other. (Sets debris collision on every player).", false);
    public FakeConVar<bool> DisableTeamMessages = new("css_fixes_disable_team_messages", "Disables team join messages.", false);
    public FakeConVar<bool> EnableStopSound = new("css_fixes_enable_stop_sound", "Enables the stop sound command.", false);
    public FakeConVar<bool> DisableSubTickMovement = new("css_fixes_disable_sub_tick_movement", "Disables sub-tick movement.", false);
    public FakeConVar<bool> EnableMovementUnlocker = new("css_fixes_enable_movement_unlocker", "Enables movement unlocker.", false);
    public FakeConVar<bool> EnforceFullAlltalk = new("css_fixes_enforce_full_alltalk", "Enforces sv_full_alltalk 1.", false);
    public FakeConVar<bool> EnableDropMapWeapons = new("css_fixes_enable_drop_map_weapons", "Enables force dropping map-spawned weapons on death.", false);
    public FakeConVar<bool> EnableEntityStringPurge = new("css_fixes_purge_entity_strings", "Enables purge of the EntityNames stringtable on new rounds", false);
    
    private void RegisterConVars()
    {
        EnableWaterFix.ValueChanged += (sender, value) => { _configuration.EnableWaterFix = value; };
        EnableTriggerPushFix.ValueChanged += (sender, value) => { _configuration.EnableTriggerPushFix = value; };
        EnableCPhysBoxUseFix.ValueChanged += (sender, value) => { _configuration.EnableCPhysBoxUseFix = value; };
        EnableBlastDamageCrashFix.ValueChanged += (sender, value) => { _configuration.EnableBlastDamageCrashFix = value; };
        //EnableNavmeshLookupLagFix.ValueChanged += (sender, value) => { _configuration.EnableNavmeshLookupLagFix = value; }; // Commented out since it seems to cause crashes every time I test it...
        EnableNoBlock.ValueChanged += (sender, value) => { _configuration.EnableNoBlock = value; };
        DisableTeamMessages.ValueChanged += (sender, value) => { _configuration.DisableTeamMessages = value; };
        EnableStopSound.ValueChanged += (sender, value) => { _configuration.EnableStopSound = value; };
        DisableSubTickMovement.ValueChanged += (sender, value) => { _configuration.DisableSubTickMovement = value; };
        EnableMovementUnlocker.ValueChanged += (sender, value) => { _configuration.EnableMovementUnlocker = value; };
        EnforceFullAlltalk.ValueChanged += (sender, value) => { _configuration.EnforceFullAlltalk = value; };
        EnableDropMapWeapons.ValueChanged += (sender, value) => { _configuration.EnableDropMapWeapons = value; };
        EnableEntityStringPurge.ValueChanged += (sender, value) => { _configuration.EnableEntityStringPurge = value; };
        
        RegisterFakeConVars(typeof(ConVar));
    }
}