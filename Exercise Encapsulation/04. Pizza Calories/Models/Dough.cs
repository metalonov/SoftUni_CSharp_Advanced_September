using FootballTeamGenerator.Exceptions;

namespace FootballTeamGenerator.Models;

public class Dough
{
    private const double baseCalorie = 2;
    private Dictionary<string, double> doughTypes;
    private Dictionary<string, double> bakingTechs;

    private string flourType;
    private string bakingTechnique;
    private double weight;
    public Dough(string flourType, string bakingTechnique, double weight)
    {
        doughTypes
            = new Dictionary<string, double>
            {
                { "white", 1.5 },
                { "wholegrain", 1.0 }
            };

        bakingTechs
            = new Dictionary<string, double>
            {
                { "crispy", 0.9 },
                { "chewy", 1.1 },
                { "homemade", 1.0 }
            };

        FlourType = flourType;
        BakingTechnique = bakingTechnique;
        Weight = weight;
    }

    public string FlourType
    {
        get => flourType;
        private set
        {
            if (!doughTypes.ContainsKey(value.ToLower()))
            {
                throw new ArgumentException(ExceptionMessages.InvalidDough);
            }
            flourType = value.ToLower();
        }
    }
    public string BakingTechnique
    {
        get => bakingTechnique;
        private set
        {
            if (!bakingTechs.ContainsKey(value.ToLower()))
            {
                throw new ArgumentException(ExceptionMessages.InvalidDough);
            }
            bakingTechnique = value.ToLower();
        }
    }
    public double Weight
    {
        get => weight;
        private set
        {
            if (value < 0 && value > 200)
            {
                throw new ArgumentException(ExceptionMessages.InvalidWeight);
            }
            weight = value;
        }
    }

    public double Calories
    {
        get
        {
            double flourTypeModifier = doughTypes[FlourType];
            double bakingTechniqueModifier = bakingTechs[BakingTechnique];

            return baseCalorie * Weight * flourTypeModifier * bakingTechniqueModifier;
        }
    }
}
