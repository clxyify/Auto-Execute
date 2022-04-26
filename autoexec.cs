public void AutoExecute()
{
   string scriptroot = "autoexec\\autoexec.lua";
   //TODO: search 'autoexec' and run all files in 'autoexec', maybe ill upgrade this soon
   string readscript = File.ReadAllText(scriptroot);
   API.Execute(readscript);
   API.Execute("print'this version sucks plz use a better one soon my friend.......\nbtw i might upgrade this later in the future uwu who knows?'");
}
