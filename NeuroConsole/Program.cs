using System.Diagnostics;
using NeuroDomain;

// Below is a very simplified, categorization of the ~100 billion neurons in a mature, human brain.
//
// 1. Sensory Neurons : Carry information TO our brain re: our 5 senses. E,g,, burns, smells, tastes.
//
// 2. Motor Neurons   : Carry information FROM our brain to control voluntary and involuntary movements. 
//                      Allow the brain and spinal cord to communicate with muscles, organs, glands. 
//                      They send info to the muscles, etc. that need to react.
//
// 3. Inter-Neurons   : These neurons are the most common. They send information between sensory and motor neurons.
//                      E.g., they help you react to external stimuli, like a hot stove, and pull your
//                      hand away because it burns.
//
// In addition to below, we can categorize neurons have Unipolar, Bipolar, Multipolar, and Psuedounipolar. 

// Some key goals: Understanding GABA, the inhibitory neurotransmitter: Gamma-Aminobutyric Acid.
// Load open-source datasets and gather GABA data from other experiments.
// Evaluate whether the person has:
//                 (1) Too much     : Naturally occurring, or through supplements.
//                 (2) Too little   : Naturally occurring, or through medication.
//                 (3) Side Effects : Quickly changing the amount.
// (1) Adjust the Dendrite abstraction to receive more/less of the GABA neuro transmitter from the post-synaptic neuron.
// (2) Monitoring which Dendrites even absorb GABA due to electrical charges.
// (3) Adjust when Action Potentials are fired via the Ion and Neuron abstractions.
// (4) Confirm whether Myelin is a factor.
// (5) Measure how much GABA is released under what conditions.
// (6) Compare with people who have pre-existing illnesses.

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Hello World!!");
    }
}