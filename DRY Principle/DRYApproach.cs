using System;

public namespace DRYApproach
{
    public class DRY
    {
        private readonly float FOOD_TAX_RATE = 0.07;
        private readonly float CLOTHING_TAX_RATE = 0.09;
        private readonly float ELECTRONICS_TAX_RATE = 0.18;
        float price = 100;
        var foodTaxRate = CalculateTax(price, FOOD_TAX_RATE);
        var clothingTaxRate = CalculateTax(price, CLOTHING_TAX_RATE);
        var electronicsTaxRate = CalculateTax(price, ELECTRONICS_TAX_RATE);

        private float CalculateTax(float price, float taxRate)
        {
            return price * (taxRate + 1);
        }
    }
} 