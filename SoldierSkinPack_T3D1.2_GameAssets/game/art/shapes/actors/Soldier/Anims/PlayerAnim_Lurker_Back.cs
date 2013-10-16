singleton TSShapeConstructor(PlayerAnim_Lurker_BackDAE)
{
   baseShape = "./PlayerAnim_Lurker_Back.dae";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Lurker_BackDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Back", "250", "269");
}