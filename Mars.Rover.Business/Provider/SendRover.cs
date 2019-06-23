using Mars.Rover.Business.Contracts;
using Mars.Rover.Data;
using Mars.Rover.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mars.Rover.Business.Provider
{
    public class SendRover : ISendRover
    {
        private Data.Rover rover;
        private string commands;
        private Direction goDirection = Direction.N;

        public SendRover(Data.Rover _rover, string _commands)
        {
            rover = _rover;
            commands = _commands;
            ApplyCommand(commands);
        }

        public Data.Rover GetRover()
        {
            return rover;
        }

        public void ApplyCommand(string commands)
        {
            foreach (var letter in commands.ToCharArray())
            {
                switch (char.ToUpper(letter))
                {
                    case 'L':
                        TurnLeft(goDirection);
                        break;
                    case 'R':
                        TurnRight(goDirection);
                        break;
                    case 'M':
                        Move(goDirection);
                        break;
                    default:
                        Move(Direction.N);
                        break;
                }
            }
        }

        public void Move(Direction direction)
        {
            if (rover.Direction == Direction.E && direction == Direction.N) { rover.Y--; }
            else if (rover.Direction == Direction.E && direction == Direction.E) { rover.Y++; }
            else if (rover.Direction == Direction.W && direction == Direction.S) { rover.X--; }
            else if (rover.Direction == Direction.W && direction == Direction.W) { rover.X++; }
            else
            {
                switch (direction)
                {
                    case Direction.N:
                        rover.Y++;
                        break;
                    case Direction.S:
                        rover.X++;
                        break;
                    case Direction.E:
                        rover.Y--;
                        break;
                    case Direction.W:
                        rover.X--;
                        break;
                }
            }
            if (rover.Y == -1)
            {
                rover.Y = 1;
                if (rover.Direction == Direction.N)
                    rover.Direction = Direction.E;
                else
                    rover.Direction = Direction.N;
            }
            if (rover.X == -1)
            {
                rover.X = 1;
                if (rover.Direction == Direction.S)
                    rover.Direction = Direction.W;
                else
                    rover.Direction = Direction.S;
            }
        }

        public Direction TurnLeft(Direction direction)
        {
            switch (direction)
            {
                case Direction.N:
                    goDirection = Direction.W;
                    break;
                case Direction.S:
                    goDirection = Direction.N;
                    break;
                case Direction.E:
                    goDirection = Direction.S;
                    break;
                case Direction.W:
                    goDirection = Direction.E;
                    break;

                default: break;
            }
            return goDirection;
        }

        public Direction TurnRight(Direction direction)
        {
            switch (direction)
            {
                case Direction.N:
                    goDirection = Direction.S;
                    break;
                case Direction.S:
                    goDirection = Direction.E;
                    break;
                case Direction.E:
                    goDirection = Direction.W;
                    break;
                case Direction.W:
                    goDirection = Direction.N;
                    break;
                default: break;
            }
            return goDirection;
        }

    }
}