using DesignPatterns.GangOfFour.Behavioral.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.GangOfFour.State
{
    public class TestState
    {
        /// <summary>
        /// Allows an object (transmission) to alter its behavior (gear) 
        /// when its internal state changes.
        /// 
        /// State vs. Strategy Pattern: Similar structure, but diff intents. 
        /// Strategy is focused on an alternative to inheritance/subclassing. 
        /// State is focused on different behaviors being encapsulated in a 
        /// state object. Both patterns enforce composition and delegation.
        /// </summary>
        [Fact]
        public void TestStateBehavior()
        {
            // Initialize
            Transmission transmission = new();
            
            // Test Park
            Assert.True(transmission.CurrentGear is StatePark);

            // Test Reverse
            transmission.ShiftToReverse();
            Assert.True(transmission.CurrentGear is StateReverse);

            // Test Drive
            transmission.ShiftToDrive();
            Assert.True(transmission.CurrentGear is StateDrive);

            // Test Overdrive
            transmission.ShiftToOverdrive();
            Assert.True(transmission.CurrentGear is StateOverdrive);

            // Test NOT going Reverse --> Overdrive
            transmission.ShiftToReverse();
            transmission.ShiftToOverdrive();
            Assert.True(transmission.CurrentGear is StateReverse);
        }
    }
}
