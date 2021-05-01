using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MarsRovers_VE
{
    class Program
    {

        // I assuming that the firstlien is not a command so i think is the grid x,y(5 5) 
        // Whe have 2 outputs so i assuming that we have 2 rovers 
        // two instruction each the first one is to set the robers position 
        // and the second one to move it in the plateau 


        //Input
        // rover 1
        //      Input   =  1 2 N
        //      Command = LMLMLMLMM
        //      Output  = 1 3 N
        // rover 2
        //      Input   =  3 3 E
        //      Command =  MMRMMRMRRM
        //      Output  =  5 1 E


        //Cardinale point
        // Y will be on West  and East   West  Will Increase the X= X+1 and y decrease the X = X-1
        // X will be on North and South  North Will Increase the Y = Y+1 and South Will decrease the Y = Y-1

        //Movements
        // L and R  will depend on Cardinale points
        // so for example if we are in N(North) and the movement is to the right the new cardinale point will be East. 
        // and if the next command is an M this will increase X =X+1





        //Create an Instance of encapsule code
        private static MarsRovers rovers = null;
        static void Main(string[] args)
        { 
            //Second Rover
            rovers = new MarsRovers("1 2 N"); // Contructor
            rovers.SendCommandRovers("LMLMLMLMM");
            Console.WriteLine(string.Format("Result Movement Rover : {0} {1} {2}", rovers.xPosition, rovers.yPosition, rovers.Cardinalpoint));
            //Second Rover
            rovers = new MarsRovers("3 3 E");// Contructor
            rovers.SendCommandRovers("MMRMMRMRRM");
            Console.WriteLine(string.Format("Result Movement Rover : {0} {1} {2}", rovers.xPosition, rovers.yPosition, rovers.Cardinalpoint));
            Console.ReadKey();
        }

       
       
    }
}
