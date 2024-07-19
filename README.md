This is a test project that allow a buyer to calculate the total price of a vehicle (common or luxury) at a car auction.

This visual studio solution contains the following projects:
- an Asp.net core 8 API `Tranzaksyon.BidCalculation.Api`
- a library that's contains the data logic `Tranzaksyon.Calculator`
- a unit test project `Tranzaksyon.Test`
- The front end. A Vuejs project `tranzaksyon.vuejs`

# Task
The software must consider several costs in the calculation. The buyer must pay various fees for the transaction, all of which are calculated on the base price amount. The total amount calculated is the winning bid amount (vehicle base price) plus the fees based on the vehicle price and vehicle type. Fees must be dynamically computed.

## Fixed and Variable Costs
- Basic buyer fee: 10% of the price of the vehicle
  - Common: minimum $10 and maximum $50
  - Luxury: minimum 25$ and maximum 200$
- The seller's special fee:
  - Common: 2% of the vehicle price
  - Luxury: 4% of the vehicle price
- The added costs for the association based on the price of the vehicle:
  - $5 for an amount between $1 and $500
  - $10 for an amount greater than $500 up to $1000
  - $15 for an amount greater than $1000 up to $3000
  - $20 for an amount over $3000
- A fixed storage fee of $100