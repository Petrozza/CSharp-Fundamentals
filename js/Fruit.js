function moneyNeeded(fruit, grams, pricePerKg) {
    let priceInGrams = pricePerKg / 1000;
    let money = grams * priceInGrams;
    let weightInKg = grams / 1000;

    console.log(`I need $${money.toFixed(2)} to buy ${weightInKg.toFixed(2)} kilograms ${fruit}.`);
}

moneyNeeded('apple', 1563, 2.35);