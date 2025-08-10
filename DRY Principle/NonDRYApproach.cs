using System;

public namespace NonDRYApproach
{
    public class NonDRY
    {
        private readonly float FOOD_TAX_RATE = 0.07;
        private readonly float CLOTHING_TAX_RATE = 0.09;
        private readonly float ELECTRONICS_TAX_RATE = 0.18;
        float price = 100;
        public float CalculateFoodTax(float price)
        {
            return price * (FOOD_TAX_RATE + 1);
        }

        public float CalculateClothingTax(float price)
        {
            return price * (CLOTHING_TAX_RATE + 1);
        }

        public float CalculateElectronicsTax(float price)
        {
            return price * (ELECTRONICS_TAX_RATE + 1);
        }
    }
} 