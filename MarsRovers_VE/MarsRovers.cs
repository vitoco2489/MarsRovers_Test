using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace MarsRovers_VE
{
    public class MarsRovers
    {
        public  int xPosition;
        public  int yPosition;
        public  string Cardinalpoint;

        //Contructor
        //this method will set the start position of the rovers and move it 

        //char [] expectedInput = new char[]{'L','R','M'};



        public MarsRovers(string input)
        {
            // We can do some validations in order to identify any typos 
            string[] data = input.Split(' ');
            xPosition = Convert.ToInt32(data[0]);
            yPosition = Convert.ToInt32(data[1]);
            Cardinalpoint = data[2];
            //SendCommandRovers(commands);

        }

        public  void MoveLeft()
        {
            switch (Cardinalpoint)
            {
                case "N":
                    Cardinalpoint = "W";
                    break;
                case "E":
                    Cardinalpoint = "N";
                    break;
                case "S":
                    Cardinalpoint = "E";
                    break;
                case "W":
                    Cardinalpoint = "S";
                    break;
                default:
                    throw new InvalidOperationException("Couldn't process operation: " + Cardinalpoint);

            }

        }
        public  void MoveRight()
        {
            switch (Cardinalpoint)
            {
                case "N":
                    Cardinalpoint = "E";
                    break;
                case "E":
                    Cardinalpoint = "S";
                    break;
                case "S":
                    Cardinalpoint = "W";
                    break;
                case "W":
                    Cardinalpoint = "N";
                    break;
                default:
                    throw new InvalidOperationException("Couldn't process operation: " + Cardinalpoint);

            }

        }
        public  void MoveForward()
        {
            switch (Cardinalpoint)
            {
                case "N":
                    yPosition++;
                    break;
                case "E":
                    xPosition++;
                    break;
                case "S":
                    yPosition--;
                    break;
                case "W":
                    xPosition--;
                    break;
                default:
                    throw new InvalidOperationException("Couldn't process operation: " + Cardinalpoint);

            }
        }
        public void SendCommandRovers(string command)
        { 
            // We can do some validations in order to identify any typos 


            foreach (char item in command.ToCharArray())
            {
                switch (item)
                {
                    case 'R':
                        MoveRight();
                        break;
                    case 'L':
                        MoveLeft();
                        break;
                    case 'M':
                        MoveForward();
                        break;
                    default:
                        throw new InvalidOperationException("Couldn't process operation: " + Cardinalpoint);
                }
            }

        }
    }
}
