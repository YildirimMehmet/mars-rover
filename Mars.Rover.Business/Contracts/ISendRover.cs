using Mars.Rover.Data;
using Mars.Rover.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mars.Rover.Business.Contracts
{
    public interface ISendRover
    {
        void ApplyCommand(string commands);

        Direction TurnLeft(Direction direction);
        Direction TurnRight(Direction direction);
        void Move(Direction direction);

    }
}