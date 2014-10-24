﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using AdventureKata;
using Moq;

namespace AdventureStateMachineTests
{
    [TestFixture]
    public class StateMachineTests
    {
        [Test]
        public void AStateMachineShouldNotBeNull()
        {
            AdventureStateMachine stateMachine = new AdventureStateMachine();

            Assert.That(stateMachine, Is.Not.Null);
        }

        [Test]
        public void AStateMachineShouldTakeATextInput()
        {
            AdventureStateMachine stateMachine = new AdventureStateMachine();

            stateMachine.Input(It.IsAny<string>());
        }

        [Test]
        public void AStateMachineShouldHaveAnInitialStateOf_InitialState()
        {
            AdventureStateMachine stateMachine = new AdventureStateMachine();

            Assert.That(stateMachine.GetState(), Is.EqualTo(AdventureStateMachine.AdventureStates.INITIAL_STATE));
        }

        [Test]
        public void AnyStringInputWillResultInMovingToThe()
        {
            AdventureStateMachine stateMachine = new AdventureStateMachine();

            Assert.That(stateMachine.GetState(), Is.EqualTo(AdventureStateMachine.AdventureStates.CAVE_STATE));
        }

        [Test]
        public void AnyStringInputWillResultInMovingToThe()
        {
            AdventureStateMachine stateMachine = new AdventureStateMachine();

            stateMachine.currentState = AdventureStateMachine.AdventureStates.CAVE_STATE;
            stateMachine.Input("Jump");


            Assert.That(stateMachine.GetState(), Is.EqualTo(AdventureStateMachine.AdventureStates.CAVE_STATE));
        }



    }
}
