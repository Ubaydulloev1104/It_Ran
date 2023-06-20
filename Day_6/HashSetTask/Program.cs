HashSet<string> playersSet = new HashSet<string>();
playersSet.Add("Ter Stegen");
playersSet.Add("Pique");
playersSet.Add("Alves");
playersSet.Add("Arauhjo");
playersSet.Add("Jordi Alba");
playersSet.Add("De Jong");
playersSet.Add("Busquets");
playersSet.Add("Gavi");
string[] playersArray = new string[7] { "De Jong", "Busquets", "Gavi", "Dembele", "Aubemiyang", "Ferran", "Adama" };
var commonPlayers = playersSet.Intersect(playersArray);
foreach (var player in commonPlayers)
{
    Console.WriteLine(player);
}
