public void AutoExecute()
{
   string scriptroot = "autoexec\\autoexec.lua";
   //TODO: search 'autoexec' and run all files in 'autoexec', maybe ill upgrade this soon
   string readscript = File.ReadAllText(scriptroot);
   API.Execute(readscript);
   API.Execute("print'this version sucks plz use a better one soon my friend.......\nbtw i might upgrade this later in the future uwu who knows?'");
   //something
   if (readscript == "") { File.WriteAllText(scriptroot, "ajeeiegagjagl....galggggayhomosexualstuffyayuwafaif..maybeimhomo"); }  else { API.Execute(""); }
}

try//catch error
{
   AutoExecute();//run attempt
}
catch (Exception x)//f**k u error >:(
{
   API.Execute("warn'error while autoexecuting\nmaybe the directory doesnt exist?\nor the script contains nothing?");//details
   API.Execute("print('" + x.Message + "')");//display error message
   MessageBox.Show("Attempt to fix error?","error");//'how to fix'
   Directory.CreateDirectory("autoexec");//make direc
   File.Create("autoexec\\autoexec.lua");//make file
   File.WriteAllText(scriptroot, "print'hey it works! autoexec works! no one gives a shit! :)'");//write to test
   MessageBox.Show("Error should be fixed!\nCheck dev console for details!", "fixed?");//ok
   //tryattempt #2
   AutoExecute();//hopefully succeed this time
   File.WriteAllText(scriptroot, "ajeeiegagjagl....galggggayhomosexualstuffyayuwafaif..awfmk");//yes
}
