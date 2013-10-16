singleton TSShapeConstructor(PlayerAnim_Lurker_Death1DAE)
{
   baseShape = "./PlayerAnim_Lurker_Death1.dae";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Lurker_Death1DAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "false");
   %this.addSequence("ambient", "Death1", "1140", "1180");
}