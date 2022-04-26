public void AutoExecute()
{
   string scriptroot = "autoexec\\autoexec.lua";
   //TODO: search 'autoexec' and run all files in 'autoexec', maybe ill upgrade this soon
   string readscript = File.ReadAllText(scriptroot);
   API.Execute(readscript);
   API.Execute("print'this version sucks plz use a better one soon my friend.......\nbtw i might upgrade this later in the future uwu who knows?'");
}

try//catch error
{
   AutoExecute();//run attempt
}
catch (Exception x)//f**k u error >:(
{
   API.Execute("warn'error while autoexecuting\nmaybe the directory doesnt exist?\nor the script contains nothing?");
   API.Execute("print('" + x.Message + "')");//display error message
   MessageBox.Show("Attempt to fix error?","error");
   Directory.CreateDirectory("autoexec");
   File.Create("autoexec\\autoexec.lua");
   File.WriteAllText(scriptroot, "print'autoexec testing'");
   MessageBox.Show("Error should be fixed!", "fixed?");
   //tryattempt
   AutoExecute();//hopefully succeed this time
}
