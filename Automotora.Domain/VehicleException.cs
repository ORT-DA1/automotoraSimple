using Automotora.Contracts.Services;
using System;
using System.Runtime.Serialization;

namespace Automotora.Domain
{

    public class VehicleException : BusinessRuleException
    {
        private static readonly string MESSAGE = "Invalid info for the vehicle";

        public VehicleException() : base(MESSAGE)
        {
        }
       
    }
}