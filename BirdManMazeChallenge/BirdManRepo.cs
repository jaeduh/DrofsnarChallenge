using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdManMazeChallenge
{
    public class BirdManRepo
    {   
        public Drofsnar _drofsnar = new Drofsnar();
        List<string> commandList = new List<string>
        {
            "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "InvincibleBirdHunter", "EveningGrosbeak", "GreaterPrairieChicken", "VulnerableBirdHunter", "VulnerableBirdHunter", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "IcelandGull", "CrestedIbis", "GreatKiskudee", "InvincibleBirdHunter", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "RedCrossbill", "Red-neckedPhalarope", "InvincibleBirdHunter", "VulnerableBirdHunter", "Orange-belliedParrot", "InvincibleBirdHunter", "Bird", "Bird", "Bird", "Bird", "Bird", "VulnerableBirdHunter"
        };
        public void RunGameSequence()
        {
            foreach (var input in commandList)
            {
                switch (input)
                {
                    case "Bird":
                        _drofsnar.AddPoints(10);
                        Console.WriteLine($"Bird{_drofsnar.Points}");
                        break;
                    case "CrestedIbis":
                        _drofsnar.AddPoints(100);
                        Console.WriteLine($"CrestedIbis{_drofsnar.Points}");
                        break;
                    case "GreatKiskudee":
                        _drofsnar.AddPoints(300);
                        Console.WriteLine($"GreatKiskudee{_drofsnar.Points}");
                        break;
                    case "RedCrossbill":
                        _drofsnar.AddPoints(500);
                        Console.WriteLine($"RedCrossbll{_drofsnar.Points}");
                        break;
                    case "Red-neckedPhalarope":
                        _drofsnar.AddPoints(700);
                        Console.WriteLine($"Red-neckedPhalarope{_drofsnar.Points}");
                        break;
                    case "EveningGrosbreak":
                        _drofsnar.AddPoints(1000);
                        Console.WriteLine($"EveningGrosbreak{_drofsnar.Points}");
                        break;
                    case "GreaterPrairie Chicken":
                        _drofsnar.AddPoints(2000);
                        Console.WriteLine($"GreaterPrairie{_drofsnar.Points}");
                        break;
                    case "IcelandGull":
                        _drofsnar.AddPoints(3000);
                        Console.WriteLine($"IcelandGull{_drofsnar.Points}");
                        break;
                    case "Orange-belliedParrot":
                        _drofsnar.AddPoints(5000);
                        Console.WriteLine($"Orange-belliedParrot{_drofsnar.Points}");
                        break;

                }
            }
        }
    }
}
