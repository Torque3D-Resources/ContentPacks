   // START: Kraad Sequences
   %this.addSequence("art/shapes/weapons/Kraad/PlayerAnims/Soldier_Kraad_Back.dae Back", "Kraad_Back", "0", "-1");
   %this.addSequence("art/shapes/weapons/Kraad/PlayerAnims/Soldier_Kraad_Celebrate_01.dae Celebrate_01", "Kraad_Celebrate_01", "0", "-1");
   %this.addSequence("art/shapes/weapons/Kraad/PlayerAnims/Soldier_Kraad_Crouch_Back.dae Crouch_Back", "Kraad_Crouch_Back", "0", "-1");
   %this.addSequence("art/shapes/weapons/Kraad/PlayerAnims/Soldier_Kraad_Crouch_Forward.dae Crouch_Forward", "Kraad_Crouch_Forward", "0", "-1");
   %this.addSequence("art/shapes/weapons/Kraad/PlayerAnims/Soldier_Kraad_Crouch_Left.dae Crouch_Left", "Kraad_Crouch_Left", "0", "-1");
   %this.addSequence("art/shapes/weapons/Kraad/PlayerAnims/Soldier_Kraad_Crouch_Root.dae Crouch_Root", "Kraad_Crouch_Root", "0", "-1");
   %this.addSequence("art/shapes/weapons/Kraad/PlayerAnims/Soldier_Kraad_Death1.dae Death1", "Kraad_Death1", "0", "-1");
   %this.addSequence("art/shapes/weapons/Kraad/PlayerAnims/Soldier_Kraad_Death2.dae Death2", "Kraad_Death2", "0", "-1");
   %this.addSequence("art/shapes/weapons/Kraad/PlayerAnims/Soldier_Kraad_Death3.dae Death3", "Kraad_Death3", "0", "-1");
   %this.addSequence("art/shapes/weapons/Kraad/PlayerAnims/Soldier_Kraad_Fall.dae Fall", "Kraad_Fall", "0", "-1");
   %this.addSequence("art/shapes/weapons/Kraad/PlayerAnims/Soldier_Kraad_Head.dae Head", "Kraad_Head", "0", "-1");
   %this.addSequence("art/shapes/weapons/Kraad/PlayerAnims/Soldier_Kraad_Jump.dae Jump", "Kraad_Jump", "0", "-1");
   %this.addSequence("art/shapes/weapons/Kraad/PlayerAnims/Soldier_Kraad_Land.dae Land", "Kraad_Land", "0", "-1");
   %this.addSequence("art/shapes/weapons/Kraad/PlayerAnims/Soldier_Kraad_Look.dae Look", "Kraad_Look", "0", "-1");
   %this.addSequence("art/shapes/weapons/Kraad/PlayerAnims/Soldier_Kraad_Reload.dae Reload", "Kraad_Reload", "0", "-1");
   %this.addSequence("art/shapes/weapons/Kraad/PlayerAnims/Soldier_Kraad_Root.dae Root", "Kraad_Root", "0", "-1");
   %this.addSequence("art/shapes/weapons/Kraad/PlayerAnims/Soldier_Kraad_Run.dae Run", "Kraad_Run", "0", "-1");
   %this.addSequence("art/shapes/weapons/Kraad/PlayerAnims/Soldier_Kraad_Side.dae Side", "Kraad_Side", "0", "-1");
   %this.addSequence("art/shapes/weapons/Kraad/PlayerAnims/Soldier_Kraad_Sitting.dae Sitting", "Kraad_Sitting", "0", "-1");
   %this.addSequence("art/shapes/weapons/Kraad/PlayerAnims/Soldier_Kraad_Swim_Back.dae Swim_Back", "Kraad_Swim_Back", "0", "-1");
   %this.addSequence("art/shapes/weapons/Kraad/PlayerAnims/Soldier_Kraad_Swim_Forward.dae Swim_Forward", "Kraad_Swim_Forward", "0", "-1");
   %this.addSequence("art/shapes/weapons/Kraad/PlayerAnims/Soldier_Kraad_Swim_Idle.dae Swim_Idle", "Kraad_Swim_Idle", "0", "-1");
   %this.addSequence("art/shapes/weapons/Kraad/PlayerAnims/Soldier_Kraad_Swim_Left.dae Swim_Left", "Kraad_Swim_Left", "0", "-1");
   %this.addSequence("art/shapes/weapons/Kraad/PlayerAnims/Soldier_Kraad_Swim_Right.dae Swim_Right", "Kraad_Swim_Right", "0", "-1");

   %this.setSequenceCyclic("Kraad_Back", true);
   %this.setSequenceCyclic("Kraad_Celebrate_01", true);
   %this.setSequenceCyclic("Kraad_Crouch_Back", true);
   %this.setSequenceCyclic("Kraad_Crouch_Forward", true);
   %this.setSequenceCyclic("Kraad_Crouch_Left", true);
   %this.setSequenceCyclic("Kraad_Crouch_Root", true);
   %this.setSequenceCyclic("Kraad_Death1", false);
   %this.setSequenceCyclic("Kraad_Death2", false);
   %this.setSequenceCyclic("Kraad_Death3", false);
   %this.setSequenceCyclic("Kraad_Fall", true);
   %this.setSequenceCyclic("Kraad_Head", false);
   %this.setSequenceCyclic("Kraad_Jump", false);
   %this.setSequenceCyclic("Kraad_Land", false);
   %this.setSequenceCyclic("Kraad_Look", false);
   %this.setSequenceCyclic("Kraad_Reload", false);
   %this.setSequenceCyclic("Kraad_Root", true);
   %this.setSequenceCyclic("Kraad_Run", true);
   %this.setSequenceCyclic("Kraad_Side", true);
   %this.setSequenceCyclic("Kraad_Sitting", true);
   %this.setSequenceCyclic("Kraad_Swim_Back", true);
   %this.setSequenceCyclic("Kraad_Swim_Forward", true);
   %this.setSequenceCyclic("Kraad_Swim_Idle", true);
   %this.setSequenceCyclic("Kraad_Swim_Left", true);
   %this.setSequenceCyclic("Kraad_Swim_Right", true);
   
   %this.setSequenceBlend( "Kraad_Head", "1", "Kraad_Root", "0");
   %this.setSequenceBlend( "Kraad_Look", "1", "Kraad_Root", "0");
   %this.setSequenceBlend( "Kraad_Reload", "1", "Kraad_Root", "0");
   
   %this.setSequenceGroundSpeed( "Kraad_Back", "0 -10.6 0");
   %this.setSequenceGroundSpeed( "Kraad_Run", "0 10.6 0");
   %this.setSequenceGroundSpeed( "Kraad_Side", "10.6 0 0");
   %this.setSequenceGroundSpeed( "Kraad_Swim_Backward", "0 -1 0");
   %this.setSequenceGroundSpeed( "Kraad_Swim_Forward", "0 1 0");
   %this.setSequenceGroundSpeed( "Kraad_Swim_Left", "1 0 0");
   %this.setSequenceGroundSpeed( "Kraad_Swim_Right", "-1 0 0");
   %this.setSequenceGroundSpeed( "Kraad_Crouch_Backward", "0 -1 0");
   %this.setSequenceGroundSpeed( "Kraad_Crouch_Forward", "0 1 0");
   %this.setSequenceGroundSpeed( "Kraad_Crouch_Side", "1 0 0");
   // END: Kraad Sequences
echo(" -- Kraad Animations Loaded");