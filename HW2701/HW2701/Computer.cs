using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2701
{
    [DebuggerDisplay("COMPUTER MODEL = {_price * 0.267}")]
    class Computer
    {
        public string _model;
        public int _price;
        public int _numberOfProcessors;
        public float _screenSize;
        public bool _isTurnOn = false;

        public int TellMeThePrice()
        {
            return _price;
        }

        public float TellMeTheScreenSize()
        {
            return _screenSize;
        }

        public void TurnOn()
        {
            Console.WriteLine("Turning on the computer");
            _isTurnOn = true;
        }

        public void TurnOff()
        {
            Console.WriteLine("Turning off the computer");
            _isTurnOn = false;
        }

        public void AddProcessor()
        {
            Console.WriteLine("Buying another processor");
            _numberOfProcessors++;
        }

        public override string ToString()
        {
            return $"Computer model={_model} price={_price} number of processors = {_numberOfProcessors} screen size = {_screenSize} power = {(_isTurnOn ? "ON" : "OFF")}";
        }
    }
}
